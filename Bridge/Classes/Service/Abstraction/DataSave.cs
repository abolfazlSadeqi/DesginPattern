using Bridge.Classes.Service.Implementation;
using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Classes.Service.Abstraction;


// The Abstraction defines the interface for the "control" part of the two
// class hierarchies. It maintains a reference to an object of the
// Implementation hierarchy and delegates all of the real work to this
// object.
public abstract class DataSave
{
    protected ISave save;
    public DataSave(ISave save)
    {
        this.save = save;
    }
    public virtual string SaveContent(Product product)
    {
      return  save.Save(product);
    }
}
