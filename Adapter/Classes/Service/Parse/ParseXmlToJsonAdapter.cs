using Adapter.Classes.Service.Parse.Interface;
using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace Adapter.Classes.Service.Parse;

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
