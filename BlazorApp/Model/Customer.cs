using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ezt a mezőt kötelező kitölteni!")]
        public string? Fname { get; set; }

        [Required(ErrorMessage = "Ezt a mezőt kötelező kitölteni!")]
        public string? Lname { get; set; }

        [Required (ErrorMessage ="Ezt a mezőt kötelező kitölteni!")]
        [RegularExpression(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W]{1,})$", ErrorMessage = "Rossz e-mail.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Ezt a mezőt kötelező kitölteni!")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Ezt a mezőt kötelező kitölteni!")]
        [DataType(DataType.DateTime)]
        [Range(typeof(DateTime),"1950-01-01", "2024-02-01", ErrorMessage ="A születési év 1950.01.01-2024.02.01 között adható meg" )]
        public DateTime BirthDay { get; set; } = new DateTime(2024,01,01); //DateTime.Now;

        [Required(ErrorMessage = "Ezt a mezőt kötelező kitölteni!")]
        [Range(0, 100000, ErrorMessage ="Az ár 0-a és 100.000 között lehet")]
        public int Price { get; set; }


        public string GetFullName()
        {
            return $"{Fname} {Lname}";          
        }
    }
}
