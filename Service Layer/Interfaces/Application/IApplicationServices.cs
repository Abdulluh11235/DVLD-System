using Domain_Layer.Models.Application;

namespace Service_Layer.Interfaces.Application
{
    public interface IApplicationServices
    {
        Task<ApplicationTypeModel?> GetApplicationType(int id);
        Task<IEnumerable<ApplicationTypeModel>> GetApplicationTypes();
        Task<bool> UpdateApplicationType(ApplicationTypeModel? ApplicationType);
    }
}