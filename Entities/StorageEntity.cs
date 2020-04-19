﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        public string StorageId { get; set; }
        public DateTime LastUpdate { get; set; }
        public int PartialQuantity { get; set; }       
        [Required]
        public string WarehouseId { get; set; }
        [Required]
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public WarehouseEntity Warehouse { get; set; }
        public ICollection<InputOutputEntity> InOuts { get; set; }

    }
}
