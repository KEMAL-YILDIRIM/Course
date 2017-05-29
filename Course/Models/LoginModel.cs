using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Course.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email adresi zorunludur")]
        [EmailAddress(ErrorMessage = "Geçersiz Email adresi girdiniz")]
        public string Email { get; set; }

        //Burada unique olmasi icin email kullanmak gerekir

        [Required(ErrorMessage = "Şifre zorunludur")]
        [DataType(DataType.Password, ErrorMessage = "Geçersiz şifre girdiniz")]
        //[RegularExpression(@"^.*(?=.*[!@#$%^&*\(\)_\-+=]).*$",
        //ErrorMessage = "Sifre sembol iceremez")]
        public string Password { get; set; }
    }
}