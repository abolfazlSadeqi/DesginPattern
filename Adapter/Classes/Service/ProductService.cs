
using Adapter.Classes.Domin;

namespace Adapter.Classes.Service;

public class ProductService
{
    public ProductService() { }

    public List<Product> GetProducts()
    {
        List<Product> products = new List<Product>();


        products.Add(new Product() { Id = 1, Code = "A1 - Mobile - iphone_13" });
        products.Add(new Product() { Id = 2, Code = "A1 - Mobile - iphone_13" });
        products.Add(new Product() { Id = 3, Code = "A1 - Mobile - iphone_13" });
        products.Add(new Product() { Id = 4, Code = "A1 - Mobile - iphone_12" });
        products.Add(new Product() { Id = 5, Code = "A1 - Mobile - iphone_12" });
        products.Add(new Product() { Id = 6, Code = "A1 - Mobile - iphone_10" });

        return products;
    }

}
