using Facade.Classes.Domin;
using Facade.Classes.interfaces;

namespace Facade.Classes.Service;


public class ProductService : IProductService
{
    public List<Product> GetProduct()
    {
        return new List<Product>() {
                                        new Product() { Id = 1, Count = 5, ProductName = "sam", StackId = 1 },
                                        new Product() { Id = 2, Count = 15, ProductName = "LG", StackId = 1 } ,
                                        new Product() { Id = 3, Count = 7, ProductName = "Apple", StackId = 1 } 
                                   };
    }
}

