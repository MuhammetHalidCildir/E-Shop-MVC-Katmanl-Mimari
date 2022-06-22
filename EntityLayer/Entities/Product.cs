using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Boş Geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string  Name { get; set; }
       

        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır")]
        public string Description { get; set; }
       
        [Display(Name = "Fiyat")]
      
        public decimal? Price { get; set; }
        
        [Display(Name = "Stok")]
        
        public int? Stock { get; set; }
      
        [Display(Name = "Popüler")]

        public bool? Popular { get; set; }
     
        [Display(Name = "Onay")]

        public bool? IsApproved { get; set; }
       
        [Display(Name = "Resim")]

        public string Image { get; set; }
       
   

        
       
        [Display(Name = "Kategori")]

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
