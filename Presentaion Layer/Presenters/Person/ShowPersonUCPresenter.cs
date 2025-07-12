using Domain_Layer;
using Presentaion_Layer.Views.People;
using Service_Layer.Interfaces.Person;

namespace Presentaion_Layer.Presenters.Person;

public class ShowPersonUCPresenter : IShowPersonUCPresenter
{
   public int PersonId { get; set; }
    readonly IShowPersonUC _showPersonUC;
    readonly IPersonServices _personServices;
    readonly IEditPersonPersenter _editPersonPersenter;
    public ShowPersonUCPresenter(IShowPersonUC showPersonUC,IEditPersonPersenter editPersonPersenter ,IPersonServices personServices)
    {
        _showPersonUC = showPersonUC;
        _personServices = personServices;
        _editPersonPersenter = editPersonPersenter;
    }
    bool notSubscribed=true;
    public IShowPersonUC GetView()
    {
       PersonModel? person = _personServices.GetPersonById(PersonId);
  
        if(notSubscribed) {                                
        _showPersonUC.showEdit += _showPersonUC_showEdit;
            notSubscribed = false;   
        }
      

        if (person is null) throw new Exception("Can\'t Show Form Without a Person");

        _showPersonUC.PersonModel = person;
        _showPersonUC.update();
        return _showPersonUC;
    }

    private void _showPersonUC_showEdit(object? sender, EventArgs e)
    {
       
        IAddEditPersonView editView= _editPersonPersenter.GetView();
        editView.PersonModel=_showPersonUC.PersonModel;
       
        Form editForm = (Form) editView;
        editForm.ShowDialog();
    }
}
