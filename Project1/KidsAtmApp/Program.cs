using System.ComponentModel;
using KidsAtmApp.Entities;
using KidsAtmApp.Repository;
using Microsoft.Extensions.DependencyInjection;
using KidsAtmApp.Controller;
using KidsAtmApp.Service;
 
 
 
 
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
       
       if (app!=null)
       {
       app.Run();
       
       }else
       {
        Console.WriteLine("Something went wrong...");
        Environment.Exit(1);
       }
 
           }
}
 