using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InputOutputEntity
    {
        [Key]
        public string InOutId { get; set; }
        public DateTime InOutDate { get; set; }
        public int Quantity { get; set; }
        public bool IsInput { get; set; }
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
