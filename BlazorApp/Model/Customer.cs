using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class Customer
    {
        public int Id { get; set; }

       
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; } = new DateTime(2024,01,01); //DateTime.Now;
        public int Price { get; set; }
    }
}
