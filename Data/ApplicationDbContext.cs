using Microsoft.EntityFrameworkCore;

using iStock.Models;



namespace iStock.Data;
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Fournisseur> Fournisseurs { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
	public DbSet<Produit> Produits { get; set; }             

}
    