namespace KidsAtmApp.Helpers{
public static class AtmHelpers
{
    public static void AddAccount()
    {

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