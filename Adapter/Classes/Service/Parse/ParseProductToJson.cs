using Adapter.Classes.Service.Parse.Interface;
using Iterator.Classes.Domin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Adapter.Classes.Service.Parse;

public class ParseProductToJson: IParseProductToJson
{
    public string ConvertToJson(List<Product> products)
    {
        return JsonConvert.SerializeObject(products);
    }

}
