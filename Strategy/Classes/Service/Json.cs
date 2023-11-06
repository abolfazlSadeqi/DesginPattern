using Strategy.Classes.Domin;
using Strategy.Classes.interfaces;
using System.Text.Json;

namespace Strategy.Classes.Service;

//Concrete Strategies
public class Json : IDocSerialization
{
    public string Processing(ProductModel productModel)
       => JsonSerializer.Serialize<ProductModel>(productModel);

}