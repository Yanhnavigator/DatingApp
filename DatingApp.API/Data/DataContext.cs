using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        //type in ctor+ tap key to create a constructor 
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        //This is property represents a table in database
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}