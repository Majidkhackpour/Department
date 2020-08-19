using System.Data.Entity;
using Persistence.Entities;
using Persistence.Migrations;

namespace Persistence.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ModelContext, Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerLog> CustomerLog { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Reception> Reception { get; set; }
        public virtual DbSet<SafeBox> SafeBox { get; set; }
        public virtual DbSet<SmsLog> SmsLog { get; set; }
        public virtual DbSet<SmsPanels> SmsPanels { get; set; }
        public virtual DbSet<UserLog> UserLog { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
    }
}
