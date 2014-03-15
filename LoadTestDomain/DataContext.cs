using System;
using System.Data.Entity;
using System.Threading;
using LoadTestWebApp.Domain.Models;

namespace LoadTestWebApp.Domain
{
    public class DataContext : DbContext
    {

        public DataContext() : base("Name=LoadTestWebAppConnection")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public override int SaveChanges()
        {
            var items = this.ChangeTracker.Entries<IAuditable>();
            foreach (var item in items)
            {
                item.Entity.UpdatedBy = Thread.CurrentPrincipal.Identity.Name;
                item.Entity.UpdateDate = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}
