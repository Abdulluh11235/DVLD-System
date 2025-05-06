using Domain_Layer;
using Domain_Layer.Models.Country;
using Presentaion_Layer.Views.People;
using Service_Layer.Interfaces.Person;
using Service_Layer.Interfaces.Country;
using Service_Layer.Common_Services;

namespace Presentaion_Layer.Presenters.Person;

public class AddPersonPresenter : IAddPersonPresenter
{
    IPersonServices _personServices;
    ICountryServices _countryServices;
    IAddEditPersonView _addEditPersonView;
    public  AddPersonPresenter(ICountryServices countryServices,IPersonServices personServices,IModelDataAnnotationCheck modelDataAnnotationCheck,
                               IAddEditPersonView form)
    {
        _personServices = personServices;
        _countryServices = countryServices;
        _addEditPersonView = form;      
        SetUp();
    }
    void SetUp()
    {
        _addEditPersonView.PersonSavedInDB += AddPerson;
        BindingSource bindingSource = new BindingSource();
        bindingSource.DataSource = _countryServices.GetAllCountries();
        _addEditPersonView.CountriesSource=bindingSource;
        _addEditPersonView.FormText = "Add Person";
        _addEditPersonView.DisplayedMemCountryList = "Name";
        _addEditPersonView.ValueMemCountryList="Id";
    }


    private bool AddPerson(IPersonModel person)
    {
      return _personServices.AddPerson(person).HasValue;
    }

    public IAddEditPersonView GetView()
    {
      return _addEditPersonView;  
    }
}
