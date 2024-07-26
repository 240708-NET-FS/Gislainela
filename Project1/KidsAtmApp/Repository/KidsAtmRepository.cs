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
  public List<UserAccount> GetAllAccounts()//view
  {
    using var context = new ApplicationDbContext();
    return context.UserAccounts.ToList();
  }
  public void UpdateAccount(UserAccount userAccount)
  {
    throw new NotImplementedException();
  }

  public UserAccount? GetUserAccountByID(int id)
  {
    using var context = new ApplicationDbContext();
    if(context.UserAccounts == null)
    {
      Console.WriteLine(" empty");
    }
    return context.UserAccounts!
                  .Include(u => u.CardDigits)
                  .FirstOrDefault(a => a.UserAccountId == id);
  }

  


}
}