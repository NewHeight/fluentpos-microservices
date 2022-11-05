using FluentPOS.Catalog.Application.Products.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentPOS.Catalog.Application.Data
{
    public sealed class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
    }
}