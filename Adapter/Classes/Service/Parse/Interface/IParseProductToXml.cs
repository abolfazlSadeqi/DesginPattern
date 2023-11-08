using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter.Classes.Service.Parse.Interface;


// implementation
public interface IParseProductToXml
{
    public XDocument GetProductXml();
}
