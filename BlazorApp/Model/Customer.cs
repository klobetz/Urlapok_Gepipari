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

        [Required(ErrorMessage ="A mező kitöltése kötelező")]
        [MinLength(8, ErrorMessage ="A jelszónak minimum 8 karaktert kell tartalmaznia")]
        [MaxLength(20, ErrorMessage = "A jelszónak max 20 karaktert kell tartalmaznia")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$", ErrorMessage ="A jelszónak kisbető nagybetű és számot kell tartalmaznia")]
        public string? Password { get; set; }

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

        public int Age()
        {
            int age = DateTime.Now.Year-BirthDay.Year;
            if (DateTime.Now.Month < BirthDay.Month || DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day)
            {
                age--;
            }
            return age;
        }

    }
}
