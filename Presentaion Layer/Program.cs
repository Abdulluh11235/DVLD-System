using Microsoft.Extensions.DependencyInjection;
using Presentaion_Layer.Presenters;
using Presentaion_Layer.Views;
using Service_Layer.Interfaces.Person;
using Service_Layer.Interfaces;
using System.Windows.Forms;
using Infrastructure_Layer.DataAccess.Repositories.Specific.Person;
using Service_Layer.Interfaces.Country;
using Infrastructure_Layer.DataAccess.Repositories.Specific.Country;
using Microsoft.Extensions.Configuration;
using Domain_Layer;
using Domain_Layer.Models.Country;
using Microsoft.VisualBasic.ApplicationServices;
using Service_Layer.Common_Services;
using Presentaion_Layer.Views.People;
using Presentaion_Layer.Presenters.Person;
using Service_Layer.Interfaces.User;
using Infrastructure_Layer.DataAccess.Repositories.Specific.User;
using Service_Layer;
using Service_Layer.Services.User_Services;
using Presentaion_Layer.Presenters.User;
using Presentaion_Layer.Views.Users;
using Presentaion_Layer.Views.Applications;
using Service_Layer.Interfaces.Application;
using Service_Layer.Services.Application_Services;
using Presentaion_Layer.Presenters.Application;
using Infrastructure_Layer.DataAccess.Repositories.Specific.Application;
using Presentaion_Layer.Presenters.Test;
using Presentaion_Layer.Views.Tests;
using Service_Layer.Interfaces.Test;
using Service_Layer.Services.Test_Services;
using Infrastructure_Layer.DataAccess.Repositories.Specific.Test;
namespace Presentaion_Layer;
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        ApplicationConfiguration.Initialize();
        // config
        var configuration = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())  
         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
         .Build();

        var connectionString = configuration.GetConnectionString("Default");
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        var services = new ServiceCollection();


        // Register Infrastruct 
        services.AddTransient<ICountryRepository>(provider =>
              new CountryRepository(connectionString! ) );
        services.AddTransient<IApplicationRepository>(provider =>
        new ApplicationRepository(connectionString!));
        
        services.AddTransient<ITestRepository>(provider =>
         new TestRepository(connectionString!));

        services.AddTransient<IPersonRepository>(provider =>
        {
            var countryRepo = provider.GetRequiredService<ICountryRepository>();
           return new PersonRepository(connectionString!, countryRepo);
        });

        services.AddTransient<IUserRepository>(provider =>
        {
            var PersonRepo = provider.GetRequiredService<IPersonRepository>();
            return new UserRepository(connectionString!, PersonRepo);
        }  );

        // Register Services 
        services.AddTransient<IPersonServices, PersonServices>();
        services.AddTransient<ICountryServices, CountryServices>();
        services.AddSingleton<IModelDataAnnotationCheck, ModelDataAnnotationCheck>();
        services.AddSingleton<IApplicationServices, ApplicationServices>();
        services.AddTransient<IUserServices,UserServices>();
        services.AddSingleton<IPasswordHasher,PasswordHasher>();
        services.AddTransient<ITestServices, TestServices>();
        // Register Views
        services.AddTransient<IMainView, MainForm>();
        services.AddTransient<IFilterPersonUC, FilterPersonUC>();
        services.AddTransient<IShowListView,ShowListUC>();
        services.AddTransient<IShowApplicationTypesList, ShowApplicationTypesListPresenter>();
        services.AddTransient<ITestTypeEditView, TestTypeEditView>();
        services.AddTransient<IApplicationTypeEditView, ApplicationTypeEditView>();
        services.AddTransient<IAddEditPersonView, AddEditPersonForm>();
        services.AddTransient<IAddEditUserView, AddEditUserForm>();

        // change name for a general container for shows
        services.AddTransient<IShowItemForm, ShowItemForm>();
        
        services.AddScoped<IShowPersonUC, ShowPersonUC>();
        services.AddScoped<IShowUserUC, ShowUserUC>();
        services.AddScoped<ISignInView, SignInForm>();


        // Register Presenters
        services.AddTransient<IMainPresenter, MainPresenter>();
        services.AddTransient<IfilterPersonUCPresenter, filterPersonUCPresenter>();
        services.AddTransient<IShowPeopleListPresenter, ShowPeopleListPresenter>();
        services.AddTransient<IShowTestTypesListPresenter,ShowTestTypesListPresenter>();
        services.AddTransient<ITestTypeEditPresenter, TestTypeEditPresenter>();
        services.AddTransient<IApplicationTypeEditPresenter, ApplicationTypeEditPresenter>();
        services.AddTransient<IShowUsersListPresenter, ShowUsersListPresenter>();
        services.AddTransient<IShowUserUCPresent, ShowUserUCPresent>();
        services.AddTransient<ISignInPresenter, SignInPresenter>();
        services.AddScoped<IAddPersonPresenter, AddPersonPresenter>();
        services.AddTransient<IEditPersonPersenter, EditPersonPersenter>();
        services.AddTransient<IShowPersonUCPresenter, ShowPersonUCPresenter>();
        services.AddTransient<IAddEditUserPresenter, AddEditUserPresenter>();

        // change name for a general container for shows
        services.AddTransient<IShowItemPresenter, ShowItemPresenter>();



        var provider = services.BuildServiceProvider();
        var presenter = provider.GetRequiredService<IMainPresenter>();
      Application.Run((Form) presenter.GetMainView() );
    }
}