using System.ComponentModel.DataAnnotations;

namespace ELearning.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Nazwa musi mieć od 3 do 150 znaków")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; } = string.Empty;

        [StringLength(20, ErrorMessage = "Kod może mieć maksymalnie 20 znaków")]
        [RegularExpression(@"^[A-Za-z0-9\-]*$", ErrorMessage = "Kod może zawierać tylko litery, cyfry i myślnik")]
        [Display(Name = "Kod przedmiotu")]
        public string? Code { get; set; }

        [StringLength(4000, ErrorMessage = "Opis może mieć maksymalnie 4000 znaków")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Opis")]
        public string? Description { get; set; }

        [Display(Name = "Utworzono")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
