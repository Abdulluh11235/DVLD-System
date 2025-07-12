using Presentaion_Layer.Views.People;
using Service_Layer.Interfaces.Person;

namespace Presentaion_Layer.Presenters.Person
{
    public class ShowItemPresenter : IShowItemPresenter
    {
    
        IShowItemForm _showPersonview;
        public ShowItemPresenter(IShowItemForm showPersonview)
        {
            _showPersonview = showPersonview;
        }
      

        public IShowItemForm ShowView() {  return _showPersonview; }
    }
}
