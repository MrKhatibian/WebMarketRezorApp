using System;
using System.ComponentModel.DataAnnotations;

namespace WebMarket.Models
{
    public class Elements
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Pleas Input Text")]
        [Display(Name = "Text")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Pleas Input Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pleas Input Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pleas Input PhonNumber")]
        [Display(Name = "PhonNumber")]
        public int PhonNumber { get; set; }
        [Required(ErrorMessage = "Pleas Input FileAddress")]
        [Display(Name = "FileAddress")]
        public string FileAddress { get; set; }
        [Required(ErrorMessage = "Pleas Input Date")]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Pleas Input Time")]
        [Display(Name = "Time")]
        public DateTime Time { get; set; }
        [Required(ErrorMessage = "Pleas Input BodyText")]
        [Display(Name = "BodyText")]
        public string BodyText { get; set; }
        public DateTime CreatTime { get; set; } = DateTime.Now;
    }
}
