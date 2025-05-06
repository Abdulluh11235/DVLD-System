using Presentaion_Layer.Views.People;

namespace Presentaion_Layer.Presenters.Person
{
    public interface IShowPersonUCPresenter
    {
        int PersonId { get; set; }

        IShowPersonUC GetView();
    }
}