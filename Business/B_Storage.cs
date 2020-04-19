using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public List<StorageEntity> StorageProductsByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse)
                    .Where(s => s.WarehouseId == idWarehouse)
                    .ToList();
            }
        }

        public void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public bool IsProductInWarehouse(string IdStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList()
                    .Where(s => s.StorageId == IdStorage);
                var x = product.Any();
                return x;
            }
        }

        public void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }

        public void DeleteStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Remove(oStorage);
                db.SaveChanges();
            }
        }

    }
}
