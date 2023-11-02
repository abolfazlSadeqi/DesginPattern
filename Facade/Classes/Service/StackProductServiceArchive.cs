using Facade.Classes.Domin;
using Facade.Classes.interfaces;

namespace Facade.Classes.Service;


public class StackProductServiceArchive : IStackProductServiceArchive
{
    public  List<Product> GetProduct()
    {
        return new List<Product>() { new Product() { Id = 1, Count = 5, ProductName = "sam", StackId = 2 },
        new Product() { Id = 2, Count = 15, ProductName = "LG", StackId =2 } ,
        new Product() { Id = 3, Count = 7, ProductName = "Apple", StackId = 2 } ,
         new Product() { Id = 4, Count = 7, ProductName = "AppleOld", StackId = 2 } };
    }
}
