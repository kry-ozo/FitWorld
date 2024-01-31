using FitWorld.Models.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitWord.Models
{
    public class Meal
    {
        [Key]
        [Required]
        public int?  mealId { get; set; }
        [Required(ErrorMessage ="Meal name is required")]
        [MaxLength(30, ErrorMessage ="Max length of meal name is 30")]
        public string?  mealName { get; set;}
        [Required(ErrorMessage = "Meal description is required")]
        [MaxLength(250)] 
        public string? mealDescription { get; set;}
        [Required(ErrorMessage = "Proteins are required")]
        [Range(1,100, ErrorMessage ="Max amount of proteins is 100g")]
        public int? mealProtein { get; set; }
        [Required(ErrorMessage = "Fats are required")]
        [Range(1, 100, ErrorMessage = "Max amount of fats is 100g")]
        public int? mealFat { get; set;}
        [Required(ErrorMessage = "Carbs are required")]
        [Range(1, 100, ErrorMessage = "Max amount of carbs is 100g")]
        public int? mealCarbs { get; set;}
        [Required]
        public byte[] pdfMeal { get; set;}
        
        public string MealOwnerId { get; set; }
        public  ApplicationUser User { get; set; }



    }
}
