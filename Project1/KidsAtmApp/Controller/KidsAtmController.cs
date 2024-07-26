using KidsAtmApp.Repository;
using KidsAtmApp.Entities;
using KidsAtmApp.Service;
using Microsoft.Extensions.DependencyInjection;
 
namespace KidsAtmApp.Controller{
 
public class KidsAtmController
{
 
    //Variable for dependency injection
    private readonly KidsAtmService service;
 
    //Constructor
    public KidsAtmController(KidsAtmService kidsAtmService){
        service = kidsAtmService;
    }
    public void Run()
    {  
        while(true){
        Console.Clear();
        Console.WriteLine("****************     KIDS ATM APP MENUE   ************************");
        Console.WriteLine("  |                                                              |");
        Console.WriteLine("  | 1 - Add Account                                              |");
        Console.WriteLine("  | 2 - View Account                                             |");  
        Console.WriteLine("  | 3 - Update Account                                           |");
        Console.WriteLine("  | 4 - Delete Account                                           |");
        Console.WriteLine("  | 5 - LogOut                                                   |");  
        Console.WriteLine("*****************************************************************|");
     
     Console.WriteLine("Select valid option from menu: ");
     var userInput  = Console.ReadLine();
 
     switch(userInput)
     {
        case "1":
        AddAccount();
        break;
        case "2":
        ViewAccount();
        break;
        case "3":
        UpdateAccount();
        break;
        case "4":
        DeleteAccount();
        break;
        case  "5":
        LogOut();
        break;
        default:
        Console.WriteLine("Invalid Input..Press any key to continue."); //any other key default.
        Console.ReadLine();
        break;
     }
        }
 
    }
 
 
    //Methods for menu
        private void PressAnyKey()
    {
      Console.WriteLine("Press Any key to Continue...");
      Console.ReadLine();
    }
    private void AddAccount()
    {
       Console.WriteLine("Enter your First Name:");
       var FName = Console.ReadLine();
 
      try
      {
        service.IsEmptyOrNullString(FName);
      }
      catch(Exception e)
      {
       Console.WriteLine(e.Message);
       PressAnyKey();
       return ;
      }
     
      Console.WriteLine("Enter your Last Name: ");
      var LName = Console.ReadLine();
      try{
        service.IsEmptyOrNullString(LName);
      }
      catch(Exception e)
      {
       Console.WriteLine(e.Message);
       PressAnyKey();
       return;
      }
 
      Console.WriteLine("Enter your PIN:");
      var Pin = Console.ReadLine();
     
      try
      {
        service.IsValidPin(Pin);
 
      }
      catch(Exception e)
      {
       Console.WriteLine(e.Message);
       PressAnyKey();
       return;
      }
 
UserAccount user = new UserAccount {FirstName = FName, LastName = LName};
      service.AddAccount(user);
    }
 
    private void ViewAccount()
   {
 
 
   }
 
   private void UpdateAccount()
   {
 
   }
   private void DeleteAccount()
  {
 
  }
 
private void LogOut()
  {
    Environment.Exit(0);
 
  }
 
 
}
 
}
