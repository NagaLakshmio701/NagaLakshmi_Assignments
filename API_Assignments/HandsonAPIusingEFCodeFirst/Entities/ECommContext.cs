using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HandsonAPIusingEFCodeFirst.Entities
{
    public class ECommContext:DbContext 
    {
        //Entity Set 
        public IConfiguration configuration;

        public ECommContext(IConfiguration configuration)
        {
            
            this.configuration= configuration;

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }





        //CONFIGURE 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("EcommConnection"));
/*            optionsBuilder.UseSqlServer("Data Source=DAUGHTER-OF-SRI;Initial Catalog=Ecomm2;Integrated Security=True;Trust Server Certificate=True");
 *            
 *            op
*/
        }



    }
}
