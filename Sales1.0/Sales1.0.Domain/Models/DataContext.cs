namespace Sales1._0.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Sales1._0.Common.Models.Product> Products { get; set; }
    }
}
