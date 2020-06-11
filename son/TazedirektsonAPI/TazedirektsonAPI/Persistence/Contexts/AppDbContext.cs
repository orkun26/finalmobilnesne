using Microsoft.EntityFrameworkCore;
using TazedirektsonAPI.Core.Models;
using TazedirektsonAPI.Domain.Models;

namespace TazedirektsonAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sepet> Sepet { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
            builder.Entity<Category>().HasData
            (
                new Category { Id = 100, Name = "sebze meyve" }, // Id set manually due to in-memory provider
                new Category { Id = 101, Name = "et urunleri" },
                new Category { Id = 102, Name = "sut ve sut urunleri" },
                new Category { Id = 103, Name = "kahvaltilik urunler" },
                new Category { Id = 104, Name = "temel gidalar" },
                new Category { Id = 105, Name = "atistirmaliklar" },
                new Category { Id = 106, Name = "unlu mamuller" },
                new Category { Id = 107, Name = "icecekler" },
                new Category { Id = 108, Name = "bebek cocuk urunleri" },
                new Category { Id = 109, Name = "ozel beslenme" }
            );
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Url).IsRequired();
            builder.Entity<Product>().Property(p => p.Cost).IsRequired();
            builder.Entity<Product>().Property(p => p.Marka).IsRequired();
            builder.Entity<Product>().Property(p => p.PreviousCost).IsRequired();
            builder.Entity<Product>().Property(p => p.NumberInStock).IsRequired();
            builder.Entity<Product>().Property(p => p.Info).IsRequired();
            builder.Entity<Product>().Property(p => p.KargoFiyatı).IsRequired();
            builder.Entity<Product>().Property(p => p.ToplamSiparisSayisi).IsRequired();
            builder.Entity<Product>().Property(p => p.Tag).IsRequired();
            builder.Entity<Product>().HasMany(p => p.Images).WithOne(p => p.Product).HasForeignKey(p => p.ProductId);
           builder.Entity<Product>().HasMany(p => p.Sepetler).WithOne(p => p.Product).HasForeignKey(p => p.ProductID);
          builder.Entity<Product>().HasMany(p => p.Siparisler).WithOne(p => p.Product).HasForeignKey(p => p.ProductID);
            builder.Entity<Product>().HasData
            (
                new Product
                {
                    Id = 100,
                    Name = "Dana Eti",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28260004/28260004-d31b17-221x148.jpg",
                    Cost = 59,
                    CategoryId = 101,
                    PreviousCost = 47,
                    NumberInStock = 15,
                    Info = "Mehmet Emin Sever Çiftliği",
                    KargoFiyatı = 0,
                    Tag = ProductTags.ÖneÇıkanlar
                },
                new Product
                {
                    Id = 101,
                    Name = "Maydanoz Demet",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28160000/28160000-5e99aa-221x148.jpg",
                    CategoryId = 101,
                    Cost = 69,
                    PreviousCost = 63,
                    NumberInStock = 9,
                    Info = "Organicasa",
                    KargoFiyatı = 0,
                    Tag = ProductTags.Diğer
                },
                new Product
                {
                    Id = 102,
                    Name = "Sakız Kabak 500 g",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28131000/28131000-753133-221x148.jpg",
                    CategoryId = 101,
                    Cost = 49,
                    PreviousCost = 45,
                    NumberInStock = 10,
                    Info = "Muzaffer Kul Çiftliği",
                    KargoFiyatı = 0,
                    Tag = ProductTags.ÖneÇıkanlar
                },
                new Product
                {
                    Id = 103,
                    Name = "Badem Hıyar 500 g",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28120006/28120006-ac18e3-221x148.jpg", 
                    CategoryId = 101,
                    Cost = 43,
                    PreviousCost = 50,
                    NumberInStock = 8,
                    Info = "Farge Organik Çiftliği",
                    KargoFiyatı = 0,
                    Tag = ProductTags.Diğer
                },
                new Product
                {
                    Id = 104,
                    Name = "Organik Havuç 1 kg",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28010004/28010004-bf02a9-221x148.jpg",
                    CategoryId = 101,
                    Cost = 49,
                    PreviousCost = 50,
                    NumberInStock = 15,
                    Info = "Sevgi Bayat Çiftliği",
                    KargoFiyatı = 0,
                    Tag=ProductTags.FırsatÜrünü

                },
                new Product
                {
                    Id = 105,
                    Name = "Avokado Adet",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28140000/28140000-119887-221x148.jpg",
                    CategoryId = 101,
                    Cost = 29,
                    PreviousCost = 20,
                    NumberInStock = 3,
                    Info = "Excelente",
                    KargoFiyatı = 0,
                    Tag = ProductTags.FırsatÜrünü
                },
                new Product
                {
                    Id = 106,
                    Name = "Organik Kıvırcık Adet",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28380001/28380001-1cfac9-221x148.jpg",
                    CategoryId = 101,
                    Cost = 29,
                    PreviousCost = 25,
                    NumberInStock = 35,
                    Info = "Si&Ha",
                    KargoFiyatı = 0,
                    Tag = ProductTags.ÖneÇıkanlar
                },
                new Product
                {
                    Id = 107,
                    Name = "Semizotu 1 Demet",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/27210036/27210036-cfcc2e-221x148.jpg",
                    CategoryId = 101,
                    Cost = 19,
                    PreviousCost = 10,
                    NumberInStock = 5,
                    Info = "Organicasa2",
                    KargoFiyatı = 0,
                    Tag = ProductTags.FırsatÜrünü
                },
                new Product
                {
                    Id = 108,
                    Name = "Organik Kiraz 500 g",
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28089034/28089034-ff8fc0-221x148.jpg",
                    CategoryId = 101,
                    Cost = 69,
                    PreviousCost = 60,
                    NumberInStock = 12,
                    Info = "Reyhan Erdoğan Çiftliği2",
                    KargoFiyatı = 0,
                    Tag = ProductTags.Diğer
                }
                

            ); ;
            builder.Entity<Image>().ToTable("Images");
            builder.Entity<Image>().HasKey(p => p.Id);
            builder.Entity<Image>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Image>().Property(p => p.Url).IsRequired();
            builder.Entity<Image>().Property(p => p.Name).IsRequired();
            builder.Entity<Image>().HasData
            (
                new Image
                {
                    Id = 100,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/27210036/27210036-cfcc2e-221x148.jpg",
                    Name = "Organik Limon 500 g",
                    ProductId = 100
                },
                new Image
                {
                    Id = 101,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28140000/28140000-119887-221x148.jpg",
                    Name = "Önpişirilmiş Nohut Unu 250 g",
                    ProductId = 101
                },
                new Image
                {
                    Id = 102,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28041000/28041000-4d8ce8-221x148.jpg",
                    Name = "Reyhan Erdoğan Çiftliği2",
                    ProductId = 102
                },
                new Image
                {
                    Id = 103,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28015911/28015911-44811d-221x148.jpg",
                    Name = "Gluno Glutensiz",
                    ProductId = 103
                },
                new Image
                {
                    Id = 104,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28100018/28100018-375fd1-221x148.jpg",
                    Name = "Çiğ Karabuğday Unu 250 g",
                    ProductId = 104
                },
                new Image
                {
                    Id = 105,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28015911/28015911-44811d-221x148.jpg",
                    ProductId = 105,
                    Name = "Organik Roka 1 demet"
                },
                new Image
                {
                    Id = 106,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/28450033/28450033-ec0dac-221x148.jpg",
                    ProductId = 106,
                    Name = "Organik Yerli Muz 1 kg"
                },
                new Image
                {
                    Id = 107,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/9100096/09100096-84cdb9-221x148.jpg",
                    ProductId = 107,
                    Name = "Ispanak 700 g"
                },
                new Image
                {
                    Id = 108,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/05016881/05016881-1ca485-221x148.jpg",
                    ProductId = 108,
                    Name = "Semizotu 1 Demet"
                },
                new Image
                {
                    Id = 109,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5010115/05010115-d58e10-221x148.jpg",
                    ProductId = 109,
                    Name = "Pembe Domates 1 kg"
                },
                new Image
                {
                    Id = 110,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5061335/05061335-dde69b-221x148.jpg",
                    ProductId = 110,
                    Name = "Domates 1 kg"
                },
                new Image
                {
                    Id = 111,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/5039658/05039658-d07ba9-221x148.jpg",
                    ProductId = 111,
                    Name = "Organik Erik 500 g"
                },
                new Image
                {
                    Id = 112,
                    Url = "https://migros-dali-storage-prod.global.ssl.fastly.net/tazedirekt/product/11559359/11559359-b2ca5f-221x148.jpg",
                    ProductId = 112,
                    Name = "Araka Bezelye 500 g"
                }

               
            );
            builder.Entity<Sepet>().ToTable("Sepet");
            builder.Entity<Sepet>().HasKey(p => p.SepetId);
            builder.Entity<Sepet>().Property(p => p.SepetId).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Siparis>().Property(p => p.Adet).IsRequired();
            builder.Entity<Siparis>().Property(p => p.UserId).IsRequired();
            builder.Entity<Siparis>().Property(p => p.ProductID).IsRequired();
            builder.Entity<Sepet>().HasData
            (
                 new Sepet
                 {
                     SepetId = 1,
                     Adet = 1,
                     UserId = 1,
                     ProductID = 117

                 },
                 new Sepet
                 {
                     SepetId = 2,
                     Adet = 1,
                     UserId = 2,
                     ProductID = 118

                 }
            );


            builder.Entity<Siparis>().ToTable("Siparis");
            builder.Entity<Siparis>().HasKey(p => p.SiparisId);
            builder.Entity<Siparis>().Property(p => p.SiparisId).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Siparis>().Property(p => p.Adet).IsRequired();
            builder.Entity<Siparis>().Property(p => p.UserId).IsRequired();
            builder.Entity<Siparis>().Property(p => p.ProductID).IsRequired();
            builder.Entity<Siparis>().HasData
            (
                 new Siparis
                 {
                     SiparisId = 1,
                     Adet = 1,
                     UserId = 1,
                     ProductID = 117



                 },
                new Siparis
                {
                    SiparisId = 2,
                    Adet = 1,
                    UserId = 2,
                    ProductID = 118
                }
             ) ;

            builder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });




            builder.Entity<User>().ToTable("User");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.Email).IsRequired();
            builder.Entity<User>().Property(p => p.Name).IsRequired();
            builder.Entity<User>().Property(p => p.LastName).IsRequired();
            builder.Entity<User>().Property(p => p.UserName).IsRequired();
            builder.Entity<User>().Property(p => p.Password).IsRequired();
            builder.Entity<User>().HasMany(p => p.Sepetler).WithOne(p => p.User).HasForeignKey(b => b.UserId);
            builder.Entity<User>().HasMany(p => p.Siparisler).WithOne(p => p.User).HasForeignKey(p => p.UserId);
            builder.Entity<User>().HasData
            (

                new User { Id = 1, Name = "Emre", LastName = "Aydemir", UserName = "AydemirEmre", Email = "aydemir@gmail.com", Password = "1234" },
                new User { Id = 2, Name = "Yusuf", LastName = "Akdeniz", UserName = "AkdenizYusuf", Email = "akdeniz@gmail.com", Password = "4567" }
            );


            builder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });
        }
    }
}
