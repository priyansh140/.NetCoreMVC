﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class Product
    {

        [Key]

        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? ISBN { get; set; }
        [Required]

        public string? Description { get; set; }

        [Required]

        public string? Author { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display (Name="List Price")]
        public double ListPrice { get; set; }

        [Required]
        [Range(1,1000)]
        [Display(Name = "Price")]
        public double Price { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Price for 50+")]
        public double Price50{ get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Price for 100+")]
        public double Price100 { get; set; }
    }
}
