using Bridge.Classes.Service.Implementation;
using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Classes.Service.Abstraction;



public class CompanyOrderProduct : DataSave
{

    public CompanyOrderProduct(ISave Save) : base(Save)
    {
    }

    public string SaveContent(Product product)
    {

        //to do
        return save.Save(product);

    }

}
