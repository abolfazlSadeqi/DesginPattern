using Composite.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Classes.Service;
//Composite
public class SupervisionStore : DataSale
{

    private List<DataSale> _Childern = new List<DataSale>();
    public SupervisionStore(string storeName) : base(storeName)
    {
    }

    public void Add(DataSale dataSale)
       => _Childern.Add(dataSale);


    public void Remove(DataSale dataSale)
       => _Childern.Remove(dataSale);

    public override long GetSale()
     => _Childern.Sum(x => x.GetSale());

}
