using KidsAtmApp.Repository;
using KidsAtmApp.Entities;

namespace KidsAtmApp.Controller{

public class KidsAtmController
{
    public void Run()
    {
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
        break;
        case "2":
        break;
        case "3":
        break;
        case "4":
        break;
        case  "5":
        break;
        default: 
        break;
     }

    }
}

} 
/*string name = Console.ReadLine();
       using(var context = new ApplicationDbContext())
        {

             var user = new UserAccount{FirstName = "gigi", LastName = "kirk", AccountNUmber = 123456, CardDigits=433443, CardPin=123123, AccountBalance=20.00m }; 
             // context.UserAccount.Add(user);
             // context.SaveChanges();
    
         /*   var transaction = new Transaction{ Description = " deposit",TranctionAmount = 30.00};
           
            context.Transaction.Add(transaction);
            context.SaveChanges();*/
