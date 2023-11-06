using Strategy.Classes.Domin;
using Strategy.Classes.interfaces;
using System.Text.Json;

namespace Strategy.Classes.Service;

public class Text : IDocSerialization
{
    public string Processing(ProductModel productModel)
        => $"Name={productModel.Name},Id={productModel.Id},Price={productModel.Price},Factory={productModel.Factory}";

}