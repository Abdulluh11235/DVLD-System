using Domain_Layer;

namespace Presentaion_Layer.Views.People
{
    public interface IShowPersonUC
    {
        IPersonModel PersonModel { get; set; }

        event EventHandler showEdit;
    }
}