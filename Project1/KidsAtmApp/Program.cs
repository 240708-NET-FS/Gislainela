using System.ComponentModel;
using KidsAtmApp.Entities;
using KidsAtmApp.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using KidsAtmApp.Controller;
using KidsAtmApp.Service;
using KidsAtmApp.Helpers;



class Program
{

    public static void Main(string[] args)
     {  


      //Setting up Dependency injection...
      //create a variable that stores 

       var ServiceProvider  = new ServiceCollection()
                                  .AddScoped<IKidsAtmRepository, KidsAtmRepository>()
                                  .AddScoped<KidsAtmService>()
                                  .AddScoped<KidsAtmController>()
                                  .BuildServiceProvider();
      var KidsAtmService = ServiceProvider.GetService<KidsAtmService>();
      Console.WriteLine($"this is a test ; {KidsAtmService}");
      if(KidsAtmService != null)
      {
        try{
           AtmHelpers.Initialize(KidsAtmService);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);

        }
      }
    

       var app   = ServiceProvider.GetService<KidsAtmController>();
       app.Run();

           }
}
