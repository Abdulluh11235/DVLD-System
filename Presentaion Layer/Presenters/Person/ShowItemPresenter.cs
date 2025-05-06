using Presentaion_Layer.Views.People;
using Service_Layer.Interfaces.Person;

namespace Presentaion_Layer.Presenters.Person
{
    public class ShowItemPresenter : IShowItemPresenter
    {
        public int PersonID { get; set; }

        IShowPersonUCPresenter _showPersonUCPresenter;
        IShowItemForm _showPersonview;
        public ShowItemPresenter(IShowItemForm showPersonview,
              IShowPersonUCPresenter showPersonUCPresenter)
        {
            _showPersonUCPresenter = showPersonUCPresenter;
            _showPersonview = showPersonview;
        }
        void SetUp()
        {
            _showPersonUCPresenter.PersonId = PersonID;
            _showPersonview.AddControl((Control)_showPersonUCPresenter.GetView());
        }

        public IShowItemForm ShowPersonView() { SetUp(); return _showPersonview; }
    }
}
