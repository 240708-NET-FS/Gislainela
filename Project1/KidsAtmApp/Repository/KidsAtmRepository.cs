using KidsAtmApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
 
namespace KidsAtmApp.Repository{

 
    // other classes will implement the methods defined inside Interface.
   public class KidsAtmRepository : IKidsAtmRepository
   {

   public void AddAccount(UserAccount userAccount)
   {
     using var context = new ApplicationDbContext();
     context.UserAccounts.Add(userAccount);
     context.SaveChanges();
   }

   //get all accounts from View account
   public List<UserAccount> GetAllAccounts()
   {
     using var context = new ApplicationDbContext();
     return context.UserAccounts.ToList();
   }
  
   
   public UserAccount? GetUserAccountByID(int accountid)  //check
   {
     using var context = new ApplicationDbContext();
     if(context.UserAccounts == null)
     {
       Console.WriteLine(" empty");
     }
      return context.UserAccounts!.FirstOrDefault(u=>u.UserAccountId == accountid);
  }

  //update existing 
  /// <summary>
  /// update account by UserAccountId and parameter passing accountid
  /// </summary>
  /// <param name="accountid"></param>
   public void UpdateAccount(UserAccount userAccount)
   {
     using var context = new ApplicationDbContext(); //maybe use null here lets try first
     context.UserAccounts.Update(userAccount);
     context.SaveChanges();
   }

  public void DeleteAccount(int accountid)
  {
    using var context = new ApplicationDbContext();
    var userAccount = context.UserAccounts.FirstOrDefault(u=> u.UserAccountId == accountid);
    if(userAccount != null)
    {
      context.UserAccounts.Remove(userAccount);
      context.SaveChanges();
    }

  }  

}
}