using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HandsonAPIusingEFCodeFirst.Entities
{
    public class ECommContext:DbContext 
    {
        //Entity Set 

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }





        //CONFIGURE 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DAUGHTER-OF-SRI;Initial Catalog=Ecomm1;Integrated Security=True;Trust Server Certificate=True");

        }



    }
}
