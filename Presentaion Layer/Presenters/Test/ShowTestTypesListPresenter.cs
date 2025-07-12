using Domain_Layer.Models.Application;
using Domain_Layer.Models.Test;
using Presentaion_Layer.Presenters.Application;
using Presentaion_Layer.Views;
using Service_Layer.Interfaces.Application;
using Service_Layer.Interfaces.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters.Test
{
    internal class ShowTestTypesListPresenter : BaseShowListPresenter<TestTypeModel, ITestServices>, IShowTestTypesListPresenter
    {
        readonly ITestTypeEditPresenter _testTypeEditPresenter;

        public ShowTestTypesListPresenter(ITestTypeEditPresenter testTypeEditPresenter, IShowListView showListView
            , ITestServices services) :
            base(showListView, services)
        {
            _testTypeEditPresenter = testTypeEditPresenter;
        }

        protected async override void Setup()
        {
            base.Setup();

            var testTypes = await _services.GetTestTypes();
            UpdateList(testTypes);
            _showListView.Head = "Manage Test Types";
            _showListView.BasicEditOnly = true;
            _showListView.EditItemInList += _showListView_EditItemInList;


        }

        private async void _showListView_EditItemInList(object? sender, EventArgs e)
        {
            var testTypeEditView = _testTypeEditPresenter.GetView();
            var testType = await _services.GetTestType(_showListView.SelectedID);
            if (testType == null) return;

            testTypeEditView.TestType = testType;
            testTypeEditView.DataBack += TestTypeEditView_DataBack;
            ((Form)testTypeEditView).ShowDialog();
        }

        private void TestTypeEditView_DataBack(object? sender, TestTypeModel? testType)
        {
            if (testType == null) return;
            last[_showListView.SelectedIndex] = testType;
        }

        public IShowListView GetShowTestTypesListView() => _showListView;

    }

}
