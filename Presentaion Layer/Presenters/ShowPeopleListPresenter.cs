using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Required for BindingSource
using Presentaion_Layer.Properties;
using Presentaion_Layer.Views;
using Service_Layer.Interfaces;
using Service_Layer.Interfaces.Person;

namespace Presentaion_Layer.Presenters
{
    public class ShowPeopleListPresenter : IShowPeopleListPresenter
    {
        private readonly IShowListView _showListView;
        private readonly IPersonServices _personServices;
        private readonly Dictionary<string, Action> _searchHandlers;

        public ShowPeopleListPresenter(IShowListView showListView, IPersonServices personServices)
        {
            _showListView = showListView;
            _personServices = personServices;

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

            // Data Binding
            var people = _personServices.GetAllPeople();
            var bindingSource = new BindingSource
            {
                DataSource = people
            };
            _showListView.SetListBindingSource(bindingSource);

            // Events
            _showListView.AddToList += _showListView_AddToList;
            _showListView.RemoveFromList += _showListView_RemoveFromList;
            _showListView.EditItemInList += _showListView_EditItemInList;
            _showListView.Search += _showListView_Search;
        }
        public IShowListView GetShowPeopleList()
        {
            return _showListView;
        }

        private void SearchByLastName()
        {
            var bs = new BindingSource();

            if (!string.IsNullOrWhiteSpace(_showListView.SearchByTxt))
                bs.DataSource = _personServices.GetByLastName(_showListView.SearchByTxt);
            else
                bs.DataSource = _personServices.GetAllPeople();

            _showListView.SetListBindingSource(bs);
        }

        private void SearchByFirstName()
        {
            var bs = new BindingSource();

            if (!string.IsNullOrWhiteSpace(_showListView.SearchByTxt))
                bs.DataSource = _personServices.GetByFirstName(_showListView.SearchByTxt);
            else
                bs.DataSource = _personServices.GetAllPeople();

            _showListView.SetListBindingSource(bs);
        }

        private void SearchByNationalNo()
        {
            var bs = new BindingSource();

            if (!string.IsNullOrWhiteSpace(_showListView.SearchByTxt))
                bs.DataSource = _personServices.GetByNationalNo(_showListView.SearchByTxt);
            else
                bs.DataSource = _personServices.GetAllPeople();

            _showListView.SetListBindingSource(bs);
        }

        private void SearchByPersonId()
        {
            var bs = new BindingSource();
            if (int.TryParse(_showListView.SearchByTxt, out int id) || !string.IsNullOrWhiteSpace(_showListView.SearchByTxt))
            {
                bs.DataSource = _personServices.GetPersonById(id);
            }
            else
            {
                bs.DataSource = _personServices.GetAllPeople();
            }

            _showListView.SetListBindingSource(bs);
        }
        private void _showListView_Search(object? sender, EventArgs e)
        {
            if (_searchHandlers.TryGetValue(_showListView.SearchByTxt, out var handler))
            {
                handler?.Invoke();
            }
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