using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Classes.Service.Parse.Interface;

public interface IParseProductToJson
{
    public string ConvertToJson(List<Product> products);
}
