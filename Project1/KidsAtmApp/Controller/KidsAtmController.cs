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
        while(true)
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
 
    public void ViewAccount() //view by GetAllAccounts
    {
      try{
          var accounts = service.GetAllAccounts();
          foreach(var account in accounts)
          {
          Console.WriteLine($" First Name : {account.FirstName} Last Name:  {account.LastName} Account Id : {account.UserAccountId} " );
          
        
          }
        
      }
      catch(InvalidOperationException ex){
           Console.WriteLine(ex.Message);
         }
      
         Console.ReadLine(); //keep going...

    }
    
    /// <summary>
    /// Get user account by ID using method GetUserAccountById ..
    /// </summary>
    
    private void UpdateAccount() //update by id
    {
      Console.WriteLine("Enter the Account Id You want to update:");
        if(int.TryParse(Console.ReadLine(), out int accountid))
        {
          try
          {
            var account = service.GetUserAccountByID(accountid);
            Console.WriteLine($"This is the Current First and Last Name we have on File: ");
            Console.WriteLine($" First Name: {account.FirstName} Last Name: {account.LastName}");
            Console.WriteLine();
            Console.WriteLine("Enter the Information you want to update.");
            Console.WriteLine("Enter new First Name:");
            var firstn = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            var lastn = Console.ReadLine();
           // var updateInfo = Console.ReadLine();
            
            account.FirstName = firstn;
            account.LastName = lastn; //if does not work check his text validation
            //Console.ReadLine();
            try{
              service.UpdateAccount(account);
              Console.WriteLine("First and Last Name successfully updated.");

            }
            catch(ArgumentException e)
            {
              Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
          }catch(KeyNotFoundException e)
          {
            Console.WriteLine(e.Message);
          }

        }else
          {
            Console.WriteLine("Please, enter a valid number.");
          }


    }
             
    private void DeleteAccount()
    {
      Console.WriteLine("Please, enter the Account Id you want to delete: ");
      if(int.TryParse(Console.ReadLine(), out int accountid))
      {
        try
        {
          service.DeleteAccount(accountid);
          Console.WriteLine($"You deleted:This account was successfully deleted.");
  
        }
        catch(KeyNotFoundException e){
          Console.WriteLine(e.Message);
        }
        Console.ReadLine();

      }
      else{
        Console.WriteLine("You did not entered a valid input...Operation Cancelled!.");
      }       
       
    }
 
   private void LogOut()
   {
    Environment.Exit(0);
 
   }
 
 
}
 
}
