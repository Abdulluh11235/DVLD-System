using Domain_Layer.Models.Application;

namespace Infrastructure_Layer.DataAccess.Repositories.Specific.Application
{
    public interface IApplicationRepository
    {
        Task<ApplicationTypeModel?> GetApplicationType(int id);
        Task<IEnumerable<ApplicationTypeModel>> GetApplicationTypes();
        Task<bool> UpdateApplicationType(ApplicationTypeModel? ApplicationType);
    }
}