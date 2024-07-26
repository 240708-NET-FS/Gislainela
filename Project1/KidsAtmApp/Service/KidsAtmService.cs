
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
      if (!int.TryParse(input, out int number))  
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

    //view
    public List<UserAccount> GetAllAccounts()
    {
       var accounts  = repository.GetAllAccounts();
       if(accounts == null || !accounts.Any())
       {
         throw new InvalidOperationException("No Account to display.");
        }
        return accounts;
    }


    public UserAccount GetUserAccountByID(int id)
    {
      var account = repository.GetUserAccountByID(id);
      if(account == null)
      {
       throw new KeyNotFoundException("oh no! invalid id.");
       }

       return account;
    }

    public void UpdateAccount(UserAccount userAccount)
    {
    //  if(string.IsNullOrWhiteSpace(userAccount.FirstName) || userAccount
    }




}
}


 