using Strategy.Classes.Domin;
using Strategy.Classes.interfaces;
using System.Xml;
using System.Xml.Serialization;

namespace Strategy.Classes.Service;

public class Xml : IDocSerialization
{
    public string Processing(ProductModel productModel)
    {
        XmlSerializer xsSubmit = new XmlSerializer(typeof(ProductModel));
      
        var xml = "";
        using (var sww = new StringWriter())
        {
            using (XmlWriter writer = XmlWriter.Create(sww))
            {
                xsSubmit.Serialize(writer, productModel);
                xml = sww.ToString(); 
            }
        }
        return xml;
    }
}