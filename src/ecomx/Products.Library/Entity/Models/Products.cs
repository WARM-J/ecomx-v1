using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Products.Library.Entity.Models
{
    public class ProductsInfo
    {

        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string Rating { get; set; }
        public string Brand { get; set; }
        [Required]
        public int MRP { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string AddedOn { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string Updatedby { get; set; }
        public bool IsActive { get; set; }
        [NotMapped]
        [DisplayName("Upload file")]
        public IFormFile ImageFile { get; set; }
        public int offsett { get; set; }
        public int limit { get; set; }

    }
}
