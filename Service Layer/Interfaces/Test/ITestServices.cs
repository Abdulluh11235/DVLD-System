using Domain_Layer.Models.Test;

namespace Service_Layer.Interfaces.Test
{
    public interface ITestServices
    {
        Task<TestTypeModel?> GetTestType(int id);
        Task<IEnumerable<TestTypeModel>> GetTestTypes();
        Task<bool> UpdateTestType(TestTypeModel? testType);
    }
}