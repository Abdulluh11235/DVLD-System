using Domain_Layer.Models.Test;

namespace Presentaion_Layer.Views.Tests
{
    public interface ITestTypeEditView
    {
        TestTypeModel TestType { get; set; }

        event EventHandler<TestTypeModel?> DataBack;
        event TestTypeModelSavedHandler? TestTypeSavedInDB;
    }
}