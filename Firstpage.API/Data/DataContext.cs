using Firstpage.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Firstpage.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //Contructor
            
        }

        public DbSet<Value> Values { get; set;}
        
        public DbSet<User> Users { get; set; }

    }
}