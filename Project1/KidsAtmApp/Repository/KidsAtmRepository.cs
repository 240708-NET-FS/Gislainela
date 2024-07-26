using KidsAtmApp.Entities;
using Microsoft.EntityFrameworkCore;

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
}
}