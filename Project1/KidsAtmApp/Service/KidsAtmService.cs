
using KidsAtmApp.Repository;
using KidsAtmApp.Entities;
using Microsoft.IdentityModel.Tokens;
 
namespace KidsAtmApp.Service{

 
    public class KidsAtmService
    {
       private readonly IKidsAtmRepository repository;
       public KidsAtmService(IKidsAtmRepository kidsAtmRepository)
       {
          repository  = kidsAtmRepository;
 
       }
       public bool  IsEmptyOrNullString(string input)
       {  
         if(string.IsNullOrEmpty(input))
         {
           throw new ArgumentException("Input can not be Null.");
       
          }
          return true;
       }
 
    public bool IsValidPin(string input)
    {

    //Check if the input is a valid integer
      if (!int.TryParse(input, out int number))  //changed int to long
      {            
        throw new ArgumentException("Input must be a valid integer.", nameof(input));        
      }
// Check if the integer has exactly 6 digits
      if(input.Length != 6 || number < 100000 || number > 999999)
      {
        throw new ArgumentException("Input must be a 6-digit integer.", nameof(input));
      }
      return true;
    } 

    
    public void AddAccount(UserAccount userAccount)
    {
       repository.AddAccount(userAccount);
   
    }
    

    //view ...
    public List<UserAccount> GetAllAccounts()
    {
       var accounts  = repository.GetAllAccounts();
       if(accounts == null || !accounts.Any())
       {
         throw new InvalidOperationException("No Account to display.");
        }
        return accounts;
    }
   
     /// <summary>
     /// get accountbyId for delete update...
     /// </summary>
     /// <param name="UserAccountId"></param>
     /// <returns></returns>
     /// <exception cref="KeyNotFoundException"></exception>
    public UserAccount GetUserAccountByID(int UserAccountId)
    {
      var account = repository.GetUserAccountByID(UserAccountId);
      if(account == null)
      {
        throw new KeyNotFoundException("invalid id.");
       }

       return account;
    }
   
    //update Not working
    public void UpdateAccount(UserAccount userAccount) //before was like addacount only returning repository
    {
      if(string.IsNullOrEmpty(userAccount.FirstName) || string.IsNullOrEmpty(userAccount.LastName))
      {
        throw new ArgumentException("Please Type your Name: ");

      }
      repository.UpdateAccount(userAccount);
    }


     public void DeleteAccount(int accountid)
     {
       var userAccount = repository.GetUserAccountByID(accountid); 
       if(userAccount == null)
       {
          throw new KeyNotFoundException("The account does not exist.");
      }
      repository.DeleteAccount(accountid);
     }

       
    }

}


 