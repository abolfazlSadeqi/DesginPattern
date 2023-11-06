using Composite.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite.Classes.Service;

//leaf
public class BranchStore : DataSale
{
    public long _Sale { get; }

    public BranchStore(string storeName, long Sale) : base(storeName)
        => _Sale = Sale;

    public override long GetSale()
      => _Sale;

}
