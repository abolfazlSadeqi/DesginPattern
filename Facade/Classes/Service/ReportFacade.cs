using Facade.Classes.Domin;
using Facade.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes.Service;

public class ReportFacade
{
    private readonly IStackProductServiceArchive _StackProductServiceArchive;
    private readonly IStackProductService _StackProductService;


    public ReportFacade()
    {
        _StackProductServiceArchive = new StackProductServiceArchive();
        _StackProductService = new StackProductService();
    }
    public List<Product> GetProduct()
    {
        var StackProduct = _StackProductServiceArchive.GetProduct();
        StackProduct.AddRange(_StackProductService.GetProduct());
        return StackProduct;

    }
}
