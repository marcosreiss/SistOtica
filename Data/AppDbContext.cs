using Microsoft.EntityFrameworkCore;
using SistOtica.Data.Mapping;
using SistOtica.Models.Client;
using SistOtica.Models.Product;
using SistOtica.Models.Sale;
using SistOtica.Models.Service;

namespace SistOtica.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ClientMap(modelBuilder.Entity<ClientModel>());
            new ProductMap(modelBuilder.Entity<ProductModel>());
            new SaleMap(modelBuilder.Entity<SaleModel>());

            base.OnModelCreating(modelBuilder);
        }

        //Client
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<ClientContact> Contacts { get; set; }
        public DbSet<ClientReferences> References { get; set; }

        //Product and Service
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ServiceModel> Services { get; set; }

        //Sale
        public DbSet<SaleModel> Sales { get; set; }
        public DbSet<SaleProtocolModel> SaleProtocols { get; set; }
        public DbSet<PrescriptionModel> Prescriptions { get; set; }
        public DbSet<FrameModel> Frames { get; set; }
        public DbSet<PaymentModel> Payments { get; set; }
        public DbSet<SistOtica.Models.Client.ClientViewModel> ClientViewModel { get; set; } = default!;

    }
}
