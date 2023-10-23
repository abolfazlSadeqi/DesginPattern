

using Adapter.Classes.Domin;

namespace Adapter.Classes.Service.Parse.Interface;

public interface IParseProductToJson
{
    public string ConvertToJson(List<Product> products);
}
