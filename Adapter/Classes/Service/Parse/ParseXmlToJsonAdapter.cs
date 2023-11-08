using Adapter.Classes.Domin;
using Adapter.Classes.Service.Parse.Interface;


namespace Adapter.Classes.Service.Parse;

////Adapter
public class ParseXmlToJsonAdapter : IParseXmlToJsonAdapter
{
    private readonly IParseProductToXml _parseProductToXml;
    public ParseXmlToJsonAdapter(IParseProductToXml parseProductToXml)
    {
        _parseProductToXml = parseProductToXml;
    }

    public string GetDataJson()
    {
        var List = _parseProductToXml.GetProductXml();

        var Products = List
                .Element("Products").Elements("Product")
                .Select(m => new Product { Id = int.Parse(m.Element("Id").Value), Code = m.Element("Code").Value });


        return new ParseProductToJson().ConvertToJson(Products.ToList());
    }

}
