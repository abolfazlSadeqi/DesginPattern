using Facade.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes.interfaces;

public interface IProductCache
{
    public void Insert(List<Product> products);


    public List<Product> GetAll();


    public bool HasData();
}
