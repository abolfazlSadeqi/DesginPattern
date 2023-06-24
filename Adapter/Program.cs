using Adapter.Classes.Service.Parse;
using Adapter.Classes.Service.Parse.Interface;

IParseProductToXml _ParseProductToXml = new ParseProductToXml();

IParseXmlToJsonAdapter _ParseXmlToJsonAdapter = new ParseXmlToJsonAdapter(_ParseProductToXml);

var _result = _ParseXmlToJsonAdapter.GetDataJson(); ;

Console.WriteLine(_result.ToString());
