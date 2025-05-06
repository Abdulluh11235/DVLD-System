using Presentaion_Layer.Presenters.Person;
using Presentaion_Layer.Properties;
using Presentaion_Layer.Views;
using Domain_Layer;
using Presentaion_Layer.Views.People;
using Service_Layer.Interfaces.Person;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentaion_Layer.Presenters;

public class ShowPeopleListPresenter : IShowPeopleListPresenter
{
    private readonly IShowListView _showListView;
    private readonly IPersonServices _personServices;
    private readonly IAddPersonPresenter _addPersonPresenter;
    private readonly IEditPersonPersenter _editPersonPersenter;
    private readonly IShowItemPresenter _showPersonPresenter;


    private readonly Dictionary<string, Action> _searchHandlers;
    private readonly BindingSource last = new();

    public ShowPeopleListPresenter(
        IShowListView showListView,IShowItemPresenter showPersonPresenter,
        IPersonServices personServices,
        IAddPersonPresenter addPersonPresenter,IEditPersonPersenter editPersonPersenter)
    {
        _showListView = showListView;
        _personServices = personServices;
        _addPersonPresenter = addPersonPresenter;
        _editPersonPersenter = editPersonPersenter;
        _showPersonPresenter = showPersonPresenter;

        _searchHandlers = new Dictionary<string, Action>
        {
            { "Person ID", SearchByPersonId },
            { "National No.", SearchByNationalNo },
            { "First Name", SearchByFirstName },
            { "Last Name", SearchByLastName }
        };

        Setup();
    }

    private void Setup()
    {
        _showListView.ImageForAddBtn = Resources.man_with_add_sign;
        _showListView.SearchBy = _searchHandlers.Keys.ToList();
        _showListView.Head = "Manage People";

        var people = _personServices.GetAllPeople();
        last.DataSource = new BindingList<IPersonModel>(people.ToList());

        _showListView.SetListBindingSource(last);
        _showListView.HideColumn("Country");

        _showListView.AddToList += _showListView_AddToList;
        _showListView.RemoveFromList += _showListView_RemoveFromList;
        _showListView.EditItemInList += _showListView_EditItemInList;
        _showListView.Search += _showListView_Search;
        _showListView.ShowDetailsForItem += _showListView_ShowDetailsForItem;
    }

    private void _showListView_ShowDetailsForItem(object? sender, EventArgs e)
    {
         _showPersonPresenter.PersonID=_showListView.SelectedID;
        IShowItemForm showPersonForm= _showPersonPresenter.ShowPersonView();
        Form showfrm=(Form)showPersonForm;   showfrm.ShowDialog();
    }

    public IShowListView GetShowPeopleList() => _showListView;

    private void _showListView_AddToList(object? sender, EventArgs e)
    {
        var addF = _addPersonPresenter.GetView();
        addF.DataBack += AddF_DataBack;
        ((Form)addF).ShowDialog();
    }

    private void AddF_DataBack(object? sender, IPersonModel? personModel)
    {
        if (personModel == null) return;
        if (_personServices.AddPerson(personModel).HasValue)
        {  
            MessageBox.Show($" Person With Id  {personModel.PersonID} Was Successfuly Updated ");
        last.Add(personModel);
        }
        else
        {
            MessageBox.Show($" Something Went Wrong ");
        }
    }
     

    private void _showListView_Search(object? sender, EventArgs e)
    {
        if (_searchHandlers.TryGetValue(_showListView.SearchByCategory, out var handler))
        {
            handler.Invoke();
            _showListView.HideColumn("Country");
        }
    }

    private void SearchByFirstName()
    {
        UpdateList(_personServices.GetByFirstName(_showListView.SearchByTxt));
    }

    private void SearchByLastName()
    {
        UpdateList(_personServices.GetByLastName(_showListView.SearchByTxt));
    }

    private void SearchByNationalNo()
    {
        UpdateList(_personServices.GetByNationalNo(_showListView.SearchByTxt));
    }

    private void SearchByPersonId()
    {
        if (int.TryParse(_showListView.SearchByTxt, out int id))
        {
            var person = _personServices.GetPersonById(id);
            UpdateList(person != null ? new List<IPersonModel> { person } : Enumerable.Empty<IPersonModel>());
        }
        else if(string.IsNullOrWhiteSpace(_showListView.SearchByTxt))
        {
            UpdateList(_personServices.GetAllPeople());
        }
        else
        {
            MessageBox.Show("Input Must Be An ID Number");
            UpdateList(_personServices.GetAllPeople());
        }
    }

    private void UpdateList(IEnumerable<IPersonModel> people)
    {
        last.DataSource = new BindingList<IPersonModel>(people.ToList());
        _showListView.SetListBindingSource(last);
    }

    private void _showListView_EditItemInList(object? sender, EventArgs e)
    {

        var edF = _editPersonPersenter.GetView();
        IPersonModel p = _personServices.GetPersonById(_showListView.SelectedID)!;
        edF.PersonModel = p;
        edF.DataBack += EdF_DataBack;
        ((Form)edF).ShowDialog();
        
     
    }

    private void EdF_DataBack(object? sender, IPersonModel? p)
    {
        
        if (_personServices.UpdatePerson(p!))
        {
            last[_showListView.SelectedIndex] = p;
            MessageBox.Show($" Person With Id  {p.PersonID} Was Successfuly Updated ");
        }
        else
        {
            MessageBox.Show($" Something Went Wrong ");
        }
    }

    private void _showListView_RemoveFromList(object? sender, EventArgs e) // Message Box Should Be In View 
    {
        if (_personServices.DeletePerson( _showListView.SelectedID) )
        {
            last.RemoveAt(_showListView.SelectedIndex);
            MessageBox.Show($" Person With Id  {_showListView.SelectedID} Was Successfuly Deleted " );
        }
        else {
            MessageBox.Show($" Something Went Wrong ");
        }
    }
}
