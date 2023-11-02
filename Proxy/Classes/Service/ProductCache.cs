using Facade.Classes.Domin;
using Proxy.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes.Service;

public class ProductCache: IProductCache
{
    private List<Product> _ProductCache;
    public ProductCache()
    {
        _ProductCache = new List<Product>();
    }

    public void Insert(List<Product> products) => _ProductCache = products;


    public List<Product> GetAll() => _ProductCache;


    public bool HasData() => _ProductCache.Any();

}
