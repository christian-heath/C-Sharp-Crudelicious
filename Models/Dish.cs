using System.ComponentModel.DataAnnotations;
using System;

namespace crudelicious.Models
{
    public class Dish
    {
        [Key]
        public int id {get; set;}

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        [Display(Name = "Name of Dish:")]
        public string Name{get; set;}

        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        [Display(Name = "Chef's Name:")]
        public string Chef{get; set;}

        [Required]
        [Range(1,10000)]
        [Display(Name = "# of Calories:")]
        public int Calories{get;set;}

        [Required]
        [Range(1,6)]
        [Display(Name = "Tastiness:")]
        public int Tastiness{get;set;}

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        [Display(Name = "Description:")]
        public string Description{get; set;}
        public DateTime CreatedAt{get; set;}
        public DateTime UpdatedAt{get; set;}
    }
}