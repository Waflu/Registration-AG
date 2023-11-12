using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Registrations
    {
        [Required(ErrorMessage = "Podaj swoje Imie")]
        [MinLength(2)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Podaj swoje nazwisko")]
        [MinLength(2)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Podaj email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Podaj prawidlowy email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj haslo")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej 8 znaków, przynajmniej jedną małą literę, jedną dużą literę i jedną cyfrę.")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdz haslo")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Podane hasla nie sa takie same")]
        public string ConfirmPassword { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Range(10, 80, ErrorMessage = "Dozwolony wiek to 10 - 80.")]
        public int Age { get; set; }

        public string Miasto { get; set; }

    } 
}
