using Domain_Layer.Models.Test;
using Service_Layer.Common_Services;
using Service_Layer.Interfaces.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Services.Test_Services
{
    public class TestServices : ITestServices
    {
        readonly ITestRepository _testRepository;
        readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public TestServices(IModelDataAnnotationCheck modelDataAnnotationCheck,
            ITestRepository testRepository)
        {
            _testRepository = testRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }
        public async Task<TestTypeModel?> GetTestType(int id)
        {
            if (id <= 0) throw new ArgumentException("Can\'t be less than zero");
           return await _testRepository.GetTestType(id);
        }

        public async Task<IEnumerable<TestTypeModel>> GetTestTypes()
        {
            return await _testRepository.GetTestTypes();
        }

        public async Task<bool> UpdateTestType(TestTypeModel? testType)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(testType);
            return await _testRepository.UpdateTestType(testType);
        }
    }
}
