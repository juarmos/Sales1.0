namespace Sales1._0.Backend.Models
{
    using Sales1._0.Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Sales1._0.Common.Models.Product> Products { get; set; }
    }
}