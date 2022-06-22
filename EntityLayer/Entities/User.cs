using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int? Id { get; set; }
        
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string Name { get; set; }
       
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string SurName { get; set; }
       
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "E-mail formatı şeklinde giriniz")]
        public string Email { get; set; }
     
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string UserName { get; set; }
      
        [Display(Name = "Ad")]
        [StringLength(10, ErrorMessage = "Max 10 karakter olmalıdır")]
        [DataType(DataType.Password)]   
        public string Password { get; set; }
      
        [Display(Name = "Şifre")]
        [StringLength(10, ErrorMessage = "Max 10 karakter olmalıdır")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]

        public string RePassword { get; set; }
       
        [StringLength(10, ErrorMessage = "Max 10 karakter olmalıdır")]
        public string Role { get; set; }
    }
}
