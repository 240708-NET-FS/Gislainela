using KidsAtmApp.Entities;

namespace KidsAtmApp.Repository{


     public interface IKidsAtmRepository 
     {
      public void AddAccount(UserAccount userAccount); 
      List<UserAccount>GetAllAccounts();
      UserAccount? GetUserAccountByID(int id);
      public void UpdateAccount(UserAccount userAccount);
      public void DeleteAccount(int id);

 


}



}