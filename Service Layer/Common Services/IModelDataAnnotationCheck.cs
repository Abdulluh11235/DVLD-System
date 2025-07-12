namespace Service_Layer.Common_Services
{
    public interface IModelDataAnnotationCheck
    {
        void  ValidateModelDataAnnotations<TModel>(TModel domainModel);
    }
}