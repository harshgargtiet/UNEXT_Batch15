using Microsoft.EntityFrameworkCore;
namespace StudentDetails.Models

{
using Microsoft.EntityFrameworkCore;


        public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
            public UserContext(DbContextOptions<UserContext>options) : base(options) 
            { 

            }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

            }
    }
    }

//dotnet-ef migrations add --context UserContext UserTableAddition