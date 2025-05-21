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

public class ShowPeopleListPresenter : BaseShowListPresenter<IPersonModel, IPersonServices>, IShowPeopleListPresenter
{
    private readonly IAddPersonPresenter _addPersonPresenter;
    private readonly IEditPersonPersenter _editPersonPresenter; 
    private readonly IShowItemPresenter _showPersonPresenter;

    public ShowPeopleListPresenter(
        IShowListView showListView,
        IPersonServices personServices,
        IAddPersonPresenter addPersonPresenter,
        IEditPersonPersenter editPersonPresenter,
        IShowItemPresenter showPersonPresenter)
        : base(showListView, personServices)
    {
        _addPersonPresenter = addPersonPresenter;
        _editPersonPresenter = editPersonPresenter;
        _showPersonPresenter = showPersonPresenter;
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

    private void _showListView_AddToList(object? sender, EventArgs e)
    {
        var addForm = _addPersonPresenter.GetView();
        addForm.DataBack += AddForm_DataBack;
        ((Form)addForm).ShowDialog();
    }

    private void AddForm_DataBack(object? sender, IPersonModel? personModel)
    {
        if (personModel == null) return;

        if (_services.AddPerson(personModel).HasValue)
        {
            MessageBox.Show($"Person With Id {personModel.PersonID} Was Successfully Added");
            last.Add(personModel);
        }
        else
        {
            MessageBox.Show("Something Went Wrong");
        }
    }

    private void _showListView_RemoveFromList(object? sender, EventArgs e)
    {
        if (_services.DeletePerson(_showListView.SelectedID))
        {
            last.RemoveAt(_showListView.SelectedIndex);
            MessageBox.Show($"Person With Id {_showListView.SelectedID} Was Successfully Deleted");
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

    private void EditForm_DataBack(object? sender, IPersonModel? updatedPerson)
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
        _showPersonPresenter.PersonID = _showListView.SelectedID;
        var showPersonForm = _showPersonPresenter.ShowPersonView();
        ((Form)showPersonForm).ShowDialog();
    }

    private async void SearchByPersonId()
    {
        if (int.TryParse(_showListView.SearchByTxt, out int id))
        {
            var person = _services.GetPersonById(id);
            UpdateList(person != null ? new[] { person } : Array.Empty<IPersonModel>());
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

    private void SearchByNationalNo()
    {
        var results = _services.GetByNationalNo(_showListView.SearchByTxt);
        UpdateList(results);
    }

    private void SearchByFirstName()
    {
        var results = _services.GetByFirstName(_showListView.SearchByTxt);
        UpdateList(results);
    }

    private void SearchByLastName()
    {
        var results = _services.GetByLastName(_showListView.SearchByTxt);
        UpdateList(results);
    }

    public IShowListView GetShowPeopleList() => _showListView;
}
