
using Adapter.Classes.Service.Parse.Interface;
using Iterator.Classes.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

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
