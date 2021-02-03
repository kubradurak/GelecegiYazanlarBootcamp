using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models
{
    public class UserLoginModel
    {
        // giriş yaparken girdiği bilgiler sadece
        [Required(ErrorMessage ="Kullanıcı adı boş olamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Parola adı boş olamaz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
