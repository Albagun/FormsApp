using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace FormsApp.Models{
   public class Product{
       
      [Display(Name="Urun Id")] 
      public int ProductId { get; set; }

      [Required(ErrorMessage ="Ürün adı giriniz")]
      [StringLength(100)]
      [Display(Name="Urun Adı")] 
      public string Name { get; set; }=null!;


      [Required(ErrorMessage ="Fiyat giriniz")]
      [Range(0,100001)]
      [Display(Name="Fiyat")] 
      public decimal? Price { get; set; }

      
      [Display(Name="Resim")] 
      public string? Image { get; set; } =string.Empty;
      public bool IsActive { get; set; }

      [Required]
      [Display(Name="Category")] 
      public int CategoryId { get; set; }

    

    }
}