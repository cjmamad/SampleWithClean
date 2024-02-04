using Microsoft.EntityFrameworkCore;
using Domain.Entities.Users;
using Application.InterFaces;


namespace Persistence.Context
{
    public class DataBaseContext:DbContext ,IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<User> Users { get ; set ; }
    }
}
