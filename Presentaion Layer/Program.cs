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
        services.AddTransient<IModelDataAnnotationCheck, ModelDataAnnotationCheck>();
        services.AddTransient<IUserServices,UserServices>();
        services.AddSingleton<IPasswordHasher,PasswordHasher>();
        // Register Views
        services.AddTransient<IMainView, MainForm>();
        services.AddTransient<IShowListView,ShowListUC>();
        services.AddTransient<IAddEditPersonView, AddEditPersonForm>();
        // change name for a general container for shows
        services.AddTransient<IShowItemForm, ShowItemForm>();
        
        services.AddTransient<IShowPersonUC, ShowPersonUC>();
        // Register Presenters
        services.AddTransient<IMainPresenter, MainPresenter>();
        services.AddTransient<IShowPeopleListPresenter, ShowPeopleListPresenter>();
        services.AddTransient<IShowUsersListPresenter, ShowUsersListPresenter>();

        services.AddTransient<IAddPersonPresenter, AddPersonPresenter>();
        services.AddTransient<IEditPersonPersenter, EditPersonPersenter>();
        services.AddTransient<IShowPersonUCPresenter, ShowPersonUCPresenter>();
        // change name for a general container for shows
        services.AddTransient<IShowItemPresenter, ShowItemPresenter>();



        var provider = services.BuildServiceProvider();

        var presenter = provider.GetRequiredService<IMainPresenter>();

     // Application.Run(new SignInForm() );
     Application.Run((Form) presenter.GetMainView() );
    }
}