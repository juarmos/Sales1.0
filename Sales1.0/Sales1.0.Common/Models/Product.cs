﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales1._0.Common.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Description { get; set; }

        public Decimal Price { get; set; }

        public bool IsAvailable{ get; set; }

        public DateTime PublishOn { get; set; }
    }

    
}
