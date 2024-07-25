using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace KidsAtmApp.Entities{

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

   public ApplicationDbContext(){}

   public DbSet<UserAccount> UserAccounts { get; set; }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       if(!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json")
                                    .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);                       

        }
    }

}

}

