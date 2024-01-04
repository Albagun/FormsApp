using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;

namespace FormsApp.Models{
    
   public class Repository{
    private static readonly List<Product> _products = new();

    private static readonly List<Category> _categories = new();

    static Repository() {

          _categories.Add(new Category{CategoryId=1, Name="Telefon", });
          _categories.Add(new Category{CategoryId=2, Name="Bilgisayar"});

          _products.Add(new Product{ProductId=1, Name= "iPhone-12", Price=20000, IsActive = false , CategoryId =1, Image ="1.jpg"});
           _products.Add(new Product{ProductId=2, Name= "iPhone-13", Price=30000, IsActive = true, CategoryId =1, Image ="2.jpg"});
            _products.Add(new Product{ProductId=3, Name= "iPhone-14", Price=40000, IsActive = false , CategoryId =1, Image ="3.jpg"});
             _products.Add(new Product{ProductId=4, Name= "iPhone-15", Price=50000, IsActive = true , CategoryId =1, Image ="4.jpg"});
             _products.Add(new Product{ProductId=5, Name="macbook",Price=80000, IsActive= true, CategoryId=2, Image="5.jpg"});
             _products.Add(new Product{ProductId=6, Name="macbook pro", Price= 100000, IsActive=true, CategoryId=2, Image="6.jpg"} );
     
    }


    public static List<Product> Products{

        get{
            return _products;
        }

    }

    public static void CreateProduct(Product entity){
        
        _products.Add(entity);
    }
     public static void EditProducts(Product updatedProduct){
        
      var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
      
      if(entity != null){
        if(!string.IsNullOrEmpty(updatedProduct.Name)){
        entity.Name = updatedProduct.Name;}

        entity.Price = updatedProduct.Price;
        entity.Image = updatedProduct.Image;
        entity.CategoryId = updatedProduct.CategoryId;
        entity.IsActive=updatedProduct.IsActive;
      }

     }

     
     public static void EditIsActive(Product updatedProduct){
        
      var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
      
      if(entity != null){
       
        entity.IsActive=updatedProduct.IsActive;
      }

     }

     public static void DeleteProducts(Product deletedProduct ){
       
          var entity = _products.FirstOrDefault(p=> p.ProductId == deletedProduct.ProductId);
          
          if(entity!= null){
            _products.Remove(entity);
          }

     }

     public static List<Category> Categories{

        get{
            return _categories;
        }

    }


   }

}