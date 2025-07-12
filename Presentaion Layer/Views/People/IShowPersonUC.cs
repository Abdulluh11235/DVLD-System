using Domain_Layer;

namespace Presentaion_Layer.Views.People
{
    public interface IShowPersonUC
    {
        PersonModel? PersonModel { get; set; }

        event EventHandler showEdit;
        public void update();
    }
}