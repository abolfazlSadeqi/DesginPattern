using Adapter.Classes.Domin;
using Adapter.Classes.Service.Parse.Interface;
using Newtonsoft.Json;

namespace Adapter.Classes.Service.Parse;

public class ParseProductToJson: IParseProductToJson
{
    public string ConvertToJson(List<Product> products)
    {
        return JsonConvert.SerializeObject(products);
    }

}
