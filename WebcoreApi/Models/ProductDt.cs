using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebcoreApi.Models
{
    public partial class ProductDt
    {
       [Key]
        public int Id { get; set; }
        public string Pro_name { get; set; }
        public int Pro_price { get; set; }
        public int Pro_quantity { get; set; }
        public string Pro_category { get; set; }
    }
}
