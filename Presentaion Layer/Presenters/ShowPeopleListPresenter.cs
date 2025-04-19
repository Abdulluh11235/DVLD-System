using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentaion_Layer.Properties;
using Presentaion_Layer.Views;
using Service_Layer.Interfaces;
using Service_Layer.Interfaces.Person;



namespace Presentaion_Layer.Presenters
{
    public class ShowPeopleListPresenter
    {
        IShowListView _showListView;
        IPersonServices _personServices;
        ShowPeopleListPresenter(IShowListView showListView,IPersonServices personServices) {

            _showListView= showListView;
            _personServices = personServices;
         
            setup();
        }

        private void setup()
        {
            _showListView.ImageForAddBtn = Resources.man_with_add_sign;
            _showListView.SearchBy = new List<string>() {"Person ID","National No.","First Name","Last Name"};
            // Data Bind
            var people = _personServices.GetAllPeople(); 
            var bindingSource = new BindingSource();
            bindingSource.DataSource = people;
            _showListView.SetListBindingSource(bindingSource);
            // Events 
            _showListView.AddToList += _showListView_AddToList;
            _showListView.RemoveFromList += _showListView_RemoveFromList;
            _showListView.EditItemInList += _showListView_EditItemInList;
            _showListView.Search += _showListView_Search;

        }

        private void _showListView_Search(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _showListView_EditItemInList(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _showListView_RemoveFromList(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _showListView_AddToList(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
