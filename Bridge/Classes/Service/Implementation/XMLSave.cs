using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bridge.Classes.Service.Implementation;


// Each Concrete Implementation corresponds to a specific platform and
// implements the Implementation interface using that platform's API.

public class XMLSave : ISave
{

    public string Save(Product product)
    {
        //to do

        return "Code=" + product.Code + ",xml save";
    }
}
