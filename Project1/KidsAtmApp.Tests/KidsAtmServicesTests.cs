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

        var exception = Record.Exception(()=> service.GetUserAccountByID(4000)); //invalid Id

       // Assert
        Assert.Equal("Invalid id.", exception.Message);
        
    }

    [Fact]
    public void IsEmptyOrNullString_ShouldNotBeNullString()
    {
        //Arrange//Act//Assert
       // var stringValidation = new UserAccount
       
        var repositoryFake = new Mock<IKidsAtmRepository>();
        var service = new KidsAtmService(repositoryFake.Object);
      //  service.IsEmptyOrNullString(stringValidation);

        var exception = Record.Exception(()=>service.IsEmptyOrNullString("Gilberto"));//valid
        Assert.Null(exception);//this is a valid input so no exception thrown.
      //  repositoryFake.Verify(repoFake=>repoFake.IsEmptyOrNullString(It.Is<UserAccount>(u=>u.FirstName =="Gilberto")), Times.Once);

    }




    /* UserAccount user= new UserAccount{FirstName = "Gi", LastName = "Liu"};
        var repository = new KidsAtmRepository();
        var service = new KidsAtmService(repository);

        service.AddAccount(user); */
        
   

            
    }


      
    }

