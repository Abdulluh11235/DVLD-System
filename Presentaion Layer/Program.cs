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
        // Register Models
        services.AddTransient<IPersonModel, PersonModel>();
        services.AddTransient<ICountryModel, CountryModel>();


        // Register Infrastruct 
        services.AddTransient<ICountryRepository>(provider =>
              new CountryRepository(connectionString! ) );
     
        services.AddTransient<IPersonRepository>(provider =>
        {
            var countryRepo = provider.GetRequiredService<ICountryRepository>();
            return new PersonRepository(connectionString!, countryRepo);
        });

        // Register Services 
        services.AddTransient<IPersonServices, PersonServices>();
        services.AddTransient<IModelDataAnnotationCheck, ModelDataAnnotationCheck>();

        // Register Views
        services.AddTransient<IMainView, MainForm>();
        services.AddTransient<IShowListView,ShowListUC>(); 

        // Register Presenters
        services.AddTransient<IMainPresenter, MainPresenter>();
        services.AddTransient<IShowPeopleListPresenter, ShowPeopleListPresenter>();


        var provider = services.BuildServiceProvider();

        var presenter = provider.GetRequiredService<IMainPresenter>();


        Application.Run((Form) presenter.GetMainView() );
    }
}