using FitWorld.Models.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitWord.Models
{
    public class Plan
    {
        [Key]
        [Required]
        public int planId { get; set; }
        [Required(ErrorMessage ="Plan name is required")]
        [MaxLength(30, ErrorMessage ="Max lenght of plan name is 30")]
        public string planName { get; set; }
        [Required(ErrorMessage = "Plan description is required")]
        [MaxLength(250)]
        public string planDescription { get; set; }
        [Required(ErrorMessage = "Plan days are required")]
        [Range(2,7, ErrorMessage ="Plan days must be between 2 and 7")]
        public int planDays { get; set; }
        [Required]
        [Range(0, 2)]
        public int planLevel { get; set; }
        [Required]
        public byte[] pdfPlan { get; set; }
        public string PlanOwnerId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
