using Service_Layer.Interfaces.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain_Layer;

namespace Presentaion_Layer.Presenters.Person
{
    public class filterPersonUCPresenter : IfilterPersonUCPresenter
    {
        readonly IFilterPersonUC _filterPersonUC;
        readonly IPersonServices _personServices;
        readonly IShowPersonUCPresenter _showPersonUCPresenter;
        public filterPersonUCPresenter(IPersonServices personServices, IFilterPersonUC filterPersonUC,
            IShowPersonUCPresenter showPersonUCPresenter)
        {
            _filterPersonUC = filterPersonUC;
            _personServices = personServices;
            _showPersonUCPresenter = showPersonUCPresenter;

            _filterPersonUC.SearchForPersonID += _filterPersonUC_SearchForPersonID; ;
            _filterPersonUC.SearchForPersonNationalNo += _filterPersonUC_SearchForPersonNationalNo;
        }

        private void _filterPersonUC_SearchForPersonID(object? sender, SearchByIdEventArgs e)
        {
            PersonModel? p = _personServices.GetPersonById(e.PersonId);
            if (p != null)
            {
                e.Person = p;
                _showPersonUCPresenter.PersonId = e.PersonId;
                _filterPersonUC.PersonModel = p;
                _filterPersonUC.AddPersonCard(_showPersonUCPresenter.GetView());
            }
        }

        private void _filterPersonUC_SearchForPersonNationalNo(object? sender, SearchByNationalNoEventArgs e)
        {
            PersonModel? p = _personServices.GetPersonByNationalNo(e.NationalNo);

            if (p != null)
            {
                e.Person = p;
                _showPersonUCPresenter.PersonId = p.PersonID;
                _filterPersonUC.PersonModel = p;
                _filterPersonUC.AddPersonCard(_showPersonUCPresenter.GetView());
            }
        }


        public IFilterPersonUC GetView() => _filterPersonUC;

    }
}
