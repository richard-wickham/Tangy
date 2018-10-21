using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tangy.Models
{
    public class MenuItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }

        public string Spicyness { get; set; }
        public enum ESpicy {  NA=0, Spicy=1, VerySpicy=2 }

        [Range(1, int.MaxValue, ErrorMessage = "Price should be greater than R1")]
        public double Price { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "Sub Category")]
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public virtual Category SubCategory { get; set; }
    }
}
