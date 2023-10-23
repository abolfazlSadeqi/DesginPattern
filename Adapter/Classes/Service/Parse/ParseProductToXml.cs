
using Adapter.Classes.Service.Parse.Interface;

using System.Xml.Linq;
namespace Adapter.Classes.Service.Parse
{

    public class ParseProductToXml: IParseProductToXml
    {
        public XDocument GetProductXml()
        {
            return new XDocument(new XElement("Products",
                       from pr in new ProductService().GetProducts()
                       select new XElement("Product",
                       new XElement("Id", pr.Id),
                       new XElement("Code", pr.Code))));
        }

    }
}
