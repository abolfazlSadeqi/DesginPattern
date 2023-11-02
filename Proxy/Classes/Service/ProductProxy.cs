using Facade.Classes.Domin;
using Facade.Classes.interfaces;
using Proxy.Classes.Domin;
using Proxy.Classes.interfaces;
using Proxy.Classes.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes.Service;


public class ProductServiceProxy : IProductService
{
    private readonly IProductService _ProductService;
    private readonly IProductCache _ProductCache;
    private readonly CacheConfiguration _cacheConfiguration;


    public ProductServiceProxy()
    {
        _ProductService = new ProductService();
        _ProductCache = new ProductCache();
        _cacheConfiguration = CacheConfiguration.both;
    }
    public ProductServiceProxy(CacheConfiguration cacheConfiguration)
    {
        _ProductService = new ProductService();
        _ProductCache = new ProductCache();
        _cacheConfiguration = cacheConfiguration;
    }

    public List<Product> GetProduct()
    {
        if (_cacheConfiguration == CacheConfiguration.Cache)
            return _ProductCache.GetAll();
        if (_cacheConfiguration == CacheConfiguration.DataBase)
            return _ProductService.GetProduct();

        if (!_ProductCache.HasData())
            _ProductCache.Insert(_ProductService.GetProduct());

        return _ProductCache.GetAll();
    }


}