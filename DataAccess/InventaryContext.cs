using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost; Database=InventoryDb;User Id=sa; Password=itdata");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Videos Juegos" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumeria" }
                );
            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName="Bodega Central", WarehouseAddress="av peru 123 SMP" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName="Bodega Callao", WarehouseAddress="av callao 1823 Callao Callao" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName="Bodega Lima", WarehouseAddress="av Lima 1423 Lima Breña" }
                );


        }


    }
}
