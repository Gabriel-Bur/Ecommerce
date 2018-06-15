using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Api.Models
{
    public class ModelProduct
    {

        [Key]
        public int Id { get; set; }


        [Required]
        public string ProductCode { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductDescription { get; set; }


        [Required]
        public string ProductCategory { get; set; }


        [Required]
        public string ProductImageURL { get; set; }


        [Required]
        public decimal ProductPrice { get; set; }


        [Required]
        public string ProductBrand { get; set; }

    }
}