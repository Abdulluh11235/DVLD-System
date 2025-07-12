using Domain_Layer;
using Presentaion_Layer.Views.People;

namespace Presentaion_Layer.Presenters.Person
{
    public interface IFilterPersonUCView
    {
        PersonModel? PersonModel { get; set; }

        event EventHandler<SearchByIdEventArgs>? SearchForPersonID;
        event EventHandler<SearchByNationalNoEventArgs>? SearchForPersonNationalNo;

        void AddPersonCard(IShowPersonUC card);
    }
}