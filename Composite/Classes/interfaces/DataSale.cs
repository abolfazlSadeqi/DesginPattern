using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Classes.interfaces;

//Component
public abstract class DataSale
{

    public string _storeName { get; set; }

    public DataSale(string storeName) => _storeName = storeName;


    public abstract long GetSale();
}