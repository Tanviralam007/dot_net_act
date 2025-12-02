using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab_5_assignment.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Qty { get; set; }

        public int C_Id { get; set; }

    }
}