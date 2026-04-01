using MicroBE.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroBE.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<DataModel> DataModels { get; set; }
    }
}
