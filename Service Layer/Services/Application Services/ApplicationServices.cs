using Domain_Layer.Models.Application;
using Infrastructure_Layer.DataAccess.Repositories.Specific.Application;
using Service_Layer.Common_Services;
using Service_Layer.Interfaces.Application;

namespace Service_Layer.Services.Application_Services
{
    public class ApplicationServices : IApplicationServices
    {
        readonly IApplicationRepository _applicationRepository;
        readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;
        public ApplicationServices(IApplicationRepository applicationRepository,
            IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _applicationRepository = applicationRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public async Task<ApplicationTypeModel?> GetApplicationType(int id)
        {
            if (id <= 0) throw new ArgumentException("Must be greater than zero", nameof(id));
            return await _applicationRepository.GetApplicationType(id);
        }

        public async Task<IEnumerable<ApplicationTypeModel>> GetApplicationTypes()
        {
            return await _applicationRepository.GetApplicationTypes();
        }

        public async Task<bool> UpdateApplicationType(ApplicationTypeModel? ApplicationType)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(ApplicationType);
            return await _applicationRepository.UpdateApplicationType(ApplicationType);
        }
    }
}
