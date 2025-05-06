using Presentaion_Layer.Views.People;

namespace Presentaion_Layer.Presenters.Person
{
    public interface IShowItemPresenter
    {
        int PersonID { get; set; }

        IShowItemForm ShowPersonView();
    }
}