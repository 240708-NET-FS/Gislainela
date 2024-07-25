using KidsAtmApp.Repository;
using KidsAtmApp.Entities;
using KidsAtmApp.Helpers;
namespace KidsAtmApp.Controller{

public class KidsAtmController
{
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
        
     var userInput  = Console.ReadLine();

     switch(userInput)
     {
        case "1":
        AtmHelpers.AddAccount();
        break;
        case "2":
        AtmHelpers.ViewAccount();
        break;
        case "3":
        AtmHelpers.UpdateAccount();
        break;
        case "4":
        AtmHelpers.DeleteAccount();
        break;
        case  "5":
        AtmHelpers.LogOut();
        break;
        default: 
        Console.WriteLine("Invalid Input..Press any key to continue."); //any other key default.
        Console.ReadLine();
        break;
     }
        }

    }
  
}

} 
