using KidsAtmApp.Service;

namespace KidsAtmApp.Helpers{
public static class AtmHelpers
{
    private static KidsAtmService service;
   
   
   public static void Initialize(KidsAtmService  kidsAtmService)
   {
     service = kidsAtmService;
   }

    public static void PressAnyKey()
    {
      Console.WriteLine("Press Any key to Continue...");
      Console.ReadLine();
    }
    public static void AddAccount()
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
    }
  
    public static void ViewAccount()
   {


   }

   public static void UpdateAccount()
   {

   }
   public static void DeleteAccount()
  {

  }

  public static void LogOut()
  {
    Environment.Exit(0);

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

}
}