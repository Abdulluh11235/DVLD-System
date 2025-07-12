using Presentaion_Layer.Presenters.Person;
using Presentaion_Layer.Properties;
using Presentaion_Layer.Views;
using Domain_Layer;
using Service_Layer.Interfaces.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Service_Layer.Interfaces;

namespace Presentaion_Layer.Presenters;

public class ShowPeopleListPresenter : BaseShowListPresenter<PersonModel, IPersonServices>, IShowPeopleListPresenter
{
    private readonly IAddPersonPresenter _addPersonPresenter;
    private readonly IEditPersonPersenter _editPersonPresenter; 
    private readonly IShowPersonUCPresenter _showPersonUCPresenter;
    private readonly IShowItemPresenter _showPersonPresenter;

    public ShowPeopleListPresenter(
        IShowListView showListView,
        IPersonServices personServices,
        IAddPersonPresenter addPersonPresenter,
        IEditPersonPersenter editPersonPresenter,
        IShowPersonUCPresenter showPersonUCPresenter,
        IShowItemPresenter showPersonPresenter)
        : base(showListView, personServices)
    {
        _addPersonPresenter = addPersonPresenter;
        _editPersonPresenter = editPersonPresenter;
        _showPersonPresenter = showPersonPresenter;
        _showPersonUCPresenter= showPersonUCPresenter;
    }

    protected override void InitializeSearchHandlers()
    {
        _searchHandlers.Add("Person ID", SearchByPersonId);
        _searchHandlers.Add("National No.", SearchByNationalNo);
        _searchHandlers.Add("First Name", SearchByFirstName);
        _searchHandlers.Add("Last Name", SearchByLastName);
    }

    protected async  override void Setup()
    {
        base.Setup();

        _showListView.ImageForAddBtn = Resources.man_with_add_sign;
        _showListView.Head = "Manage People";

        var people = await _services.GetAllPeople();

        UpdateList(people);


        _showListView.AddToList += _showListView_AddToList;
        _showListView.RemoveFromList += _showListView_RemoveFromList;
        _showListView.EditItemInList += _showListView_EditItemInList;
        _showListView.ShowDetailsForItem += _showListView_ShowDetailsForItem;
    }

    private  void  _showListView_AddToList(object? sender, EventArgs e)
    {
        var addForm = _addPersonPresenter.GetView();
        addForm.DataBack += AddForm_DataBack;
        ((Form)addForm).ShowDialog();
    }

    private void AddForm_DataBack(object? sender, PersonModel? personModel)
    {
        if (personModel is not  null) 
        {
            MessageBox.Show($"Person With Id {personModel.PersonID} Was Successfully Added");
            last.Add(personModel);
        }
    }

    private void _showListView_RemoveFromList(object? sender, EventArgs e)
    {
        if (_services.DeletePerson(_showListView.SelectedID))
        {
            MessageBox.Show($"Person With Id {_showListView.SelectedID} Was Successfully Deleted");
            last.RemoveAt(_showListView.SelectedIndex);
        }
        else
        {
            MessageBox.Show("Something Went Wrong");
        }
    }

    private void _showListView_EditItemInList(object? sender, EventArgs e)
    {
        var editForm = _editPersonPresenter.GetView();
        var person = _services.GetPersonById(_showListView.SelectedID);
        if (person == null) return;

        editForm.PersonModel = person;
        editForm.DataBack += EditForm_DataBack;
        ((Form)editForm).ShowDialog();
    }

    private void EditForm_DataBack(object? sender, PersonModel? updatedPerson)
    {
        if (updatedPerson == null) return;

        if (_services.UpdatePerson(updatedPerson))
        {
            last[_showListView.SelectedIndex] = updatedPerson;
            MessageBox.Show($"Person With Id {updatedPerson.PersonID} Was Successfully Updated");
        }
        else
        {
            MessageBox.Show("Something Went Wrong");
        }
    }

    private void _showListView_ShowDetailsForItem(object? sender, EventArgs e)
    {
        int id=_showListView.SelectedID;
        _showPersonUCPresenter.PersonId = id;
        var showPersonControl = _showPersonUCPresenter.GetView();

      var showPersonForm=   _showPersonPresenter.ShowView();
        showPersonForm.AddControl((Control)showPersonControl);
        ((Form)showPersonForm).ShowDialog();
    }

    private async void SearchByPersonId()
    {
        if (int.TryParse(_showListView.SearchByTxt, out int id))
        {
            var person = _services.GetPersonById(id);
            UpdateList(person != null ? new[] { person } : Array.Empty<PersonModel>());
        }
        else if (string.IsNullOrWhiteSpace(_showListView.SearchByTxt))
        {

            var people = await _services.GetAllPeople();
            UpdateList(people);

        }
        else
        {
            MessageBox.Show("Input Must Be An ID Number");
        }
    }

    private async void SearchByNationalNo()
    {
        var results = await _services.GetByNationalNo(_showListView.SearchByTxt);
        UpdateList(results);
    }

    private async void SearchByFirstName()
    {
        var results = await _services.GetByFirstName(_showListView.SearchByTxt);
        UpdateList(results);
    }

    private async void SearchByLastName()
    {
        var results = await _services.GetByLastName(_showListView.SearchByTxt);
        UpdateList(results);
    }

    public IShowListView GetShowPeopleList() => _showListView;
}
