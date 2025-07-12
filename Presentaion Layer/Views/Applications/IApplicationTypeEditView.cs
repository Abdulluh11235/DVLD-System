using Domain_Layer.Models.Application;

namespace Presentaion_Layer.Views.Applications
{
    public interface IApplicationTypeEditView
    {

        public event ApplicationTypeSavedHandler? ApplicationTypeSavedInDB;
        ApplicationTypeModel applicationType { get; set; }
        event EventHandler<ApplicationTypeModel?> DataBack;
    }
}