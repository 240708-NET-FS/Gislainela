using System.ComponentModel;
using KidsAtmApp.Entities;
using KidsAtmApp.Repository;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using KidsAtmApp.Controller;
using KidsAtmApp.Service;

namespace KidsAtmApp.Services{

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
      
       var app   = ServiceProvider.GetService<KidsAtmController>();
       app.Run();

           }
}
}