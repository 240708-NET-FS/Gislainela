using KidsAtmApp.Entities;
using KidsAtmApp.Service;
using KidsAtmApp.Repository;
using Xunit;
using Microsoft.EntityFrameworkCore.Query;
using Moq;



namespace KidsAtmApp.Tests
{

public class KidsAtmServicesTests
{   
    [Fact]
    public void GetUserAccountByID_ShouldThrowAnExceptionIfInvalidId()
    {   

        //arrange-set up
        UserAccount user= new UserAccount{FirstName = "Gi", LastName = "Liu"};
        var repository = new Mock<IKidsAtmRepository>();//Mock pass to interface : fake,  using the generics
        var service = new KidsAtmService(repository.Object); // calling the Mock or fake repository object
        //arrange/act and assert
        //act -> calling -> assert with throws when you want exc
      //  var exception = Assert.Throws<KeyNotFoundException>(() => service.GetUserAccountByID(4000));  

        var exception = Record.Exception(()=> service.GetUserAccountByID(4000));

       // Assert
        Assert.Equal("Invalid id.", exception.Message);
        


        
    

    }

    /* UserAccount user= new UserAccount{FirstName = "Gi", LastName = "Liu"};
        var repository = new KidsAtmRepository();
        var service = new KidsAtmService(repository);

        service.AddAccount(user); */
        
   

            
    }


      
    }

