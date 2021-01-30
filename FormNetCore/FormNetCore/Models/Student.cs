using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormNetCore.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Lütfen isimini giriniz..")]
        [MinLength(2, ErrorMessage ="İsminiz 2 harften kısa olamaz...")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Lütfen okul numaranızı giriniz...")]
        public int SchoolNumber { get; set; }
        [EmailAddress(ErrorMessage ="Eposta formatınız doğru değil!")]
        public string Email { get; set; }
        [MaxLength(11, ErrorMessage = "Telefon numarası 11 karakterden oluşmalıdır")]
        [MinLength(11, ErrorMessage = "Telefon numarası 11 karakterden oluşmalıdır")]
        public string Phone { get; set; }
        public Departmen Departmen { get; set; }
        public Gender StGender { get; set; }        

    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum Departmen
    {
       ComputerEngineering,
       CivilEngineering,
       ElectricalElectronicEngineering,
       IndustrialEngineering,
       MechanicalEngineering
    }
}
