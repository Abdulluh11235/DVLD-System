using Domain_Layer.Models.Application;
using Presentaion_Layer.Views;
using Presentaion_Layer.Views.Applications;
using Service_Layer.Interfaces.Application;
using Service_Layer.Services.Application_Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters.Application
{
    internal class ShowApplicationTypesListPresenter : BaseShowListPresenter<ApplicationTypeModel, IApplicationServices>, 
        IShowApplicationTypesList
    {
       readonly  IApplicationTypeEditPresenter _applicationTypeEditPresenter;

        public ShowApplicationTypesListPresenter(IApplicationTypeEditPresenter applicationTypeEditPresenter   ,IShowListView showListView, IApplicationServices services) :
            base(showListView, services)
        {
            _applicationTypeEditPresenter = applicationTypeEditPresenter;
        }

        protected async override void Setup()
        {
            base.Setup();

            var appTypes = await _services.GetApplicationTypes();
            UpdateList(appTypes);
            _showListView.Head = "Manage Application Types";
            _showListView.BasicEditOnly = true;
            _showListView.EditItemInList += _showListView_EditItemInList;
           

        }

        private async void _showListView_EditItemInList(object? sender, EventArgs e)
        {
          var applicationTypeEditView=  _applicationTypeEditPresenter.GetView();
            var appType = await _services.GetApplicationType(_showListView.SelectedID);
            if (appType == null) return;

            applicationTypeEditView.applicationType = appType;
            applicationTypeEditView.DataBack += ApplicationTypeEditView_DataBack;
            ((Form)applicationTypeEditView).ShowDialog();
        }

        private void ApplicationTypeEditView_DataBack(object? sender, ApplicationTypeModel? e)
        {
            if (e == null) return;
            last[_showListView.SelectedIndex] = e;
        }

        public IShowListView GetShowApplicationTypesListView() => _showListView;

    }
}
