using Presentaion_Layer.Views.Applications;
using Service_Layer.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Presenters.Application
{
    internal class ApplicationTypeEditPresenter : IApplicationTypeEditPresenter
    {
        readonly IApplicationServices _applicationServices;
        readonly IApplicationTypeEditView _applicationTypeEditView;


        public ApplicationTypeEditPresenter(IApplicationServices applicationServices
            , IApplicationTypeEditView applicationTypeEditView)
        {
            _applicationServices = applicationServices;
            _applicationTypeEditView = applicationTypeEditView;
            Setup();
        }

        private async void Setup()
        {

            _applicationTypeEditView.ApplicationTypeSavedInDB +=  _applicationTypeEditView_ApplicationTypeSavedInDB;
        }

        public IApplicationTypeEditView GetView() => _applicationTypeEditView;
        private async Task<bool> _applicationTypeEditView_ApplicationTypeSavedInDB(Domain_Layer.Models.Application.ApplicationTypeModel applicationType)
        {
            if (applicationType is null) return false;
            return await _applicationServices.UpdateApplicationType(applicationType);
        }
    }
}
