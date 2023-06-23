using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes.Service;

public class EmployeeService
{
    public EmployeeService() { }

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
