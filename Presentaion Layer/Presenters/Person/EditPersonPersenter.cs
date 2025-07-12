using Domain_Layer;
using Presentaion_Layer.Views.People;
using Service_Layer.Common_Services;
using Service_Layer.Interfaces.Country;
using Service_Layer.Interfaces.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters.Person
{
    public class EditPersonPersenter : IEditPersonPersenter
    {
        IPersonServices _personServices;
        ICountryServices _countryServices;
        IAddEditPersonView _addEditPersonView;
        public EditPersonPersenter(ICountryServices countryServices, IPersonServices personServices, IModelDataAnnotationCheck modelDataAnnotationCheck,
                                   IAddEditPersonView form)
        {
            _personServices = personServices;
            _countryServices = countryServices;
            _addEditPersonView = form;
            SetUp();
        }
        async void SetUp()
        {
            _addEditPersonView.PersonSavedInDB += editPerson;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = await _countryServices.GetAllCountries();
            _addEditPersonView.CountriesSource = bindingSource;
            _addEditPersonView.FormText = "Edit Person";
            _addEditPersonView.DisplayedMemCountryList = "Name";
            _addEditPersonView.ValueMemCountryList = "Id";
        }


        private bool editPerson(PersonModel person)
        {
            _addEditPersonView.PersonModel = person;
            return _personServices.UpdatePerson(person);
        }

        public IAddEditPersonView GetView()
        {
            return _addEditPersonView;
        }


    }
}
