using Presentaion_Layer.Views.Tests;
using Service_Layer.Interfaces.Test;
using Domain_Layer.Models.Test;

namespace Presentaion_Layer.Presenters.Test
{
    public class TestTypeEditPresenter : ITestTypeEditPresenter
    {
        readonly ITestServices _testServices;
        readonly ITestTypeEditView _testTypeEditView;


        public TestTypeEditPresenter(ITestServices testServices
            , ITestTypeEditView testTypeEditView)
        {
            _testServices = testServices;
            _testTypeEditView = testTypeEditView;
            Setup();
        }

        private async void Setup()
        {

            _testTypeEditView.TestTypeSavedInDB += _testTypeEditView_TestTypeSavedInDB; ;
        }

        private async Task<bool> _testTypeEditView_TestTypeSavedInDB(TestTypeModel testType)
        {
            if (testType is null) return false;
            return await _testServices.UpdateTestType(testType);
        }

        public ITestTypeEditView GetView() => _testTypeEditView;

    }
}
