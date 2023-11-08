using Builder.Classes.Instance;
using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes.Service;

//ConcreteBuilder2

public class SmsContent : IBaseContentBuilder
{
    BaseContent _BaseContent = new BaseContent();

    public override string Build()
    {
        return _BaseContent.Header + _BaseContent.Content + _BaseContent.Footer ;
    }

    public override IBaseContentBuilder SetContent(string Content)
    {
        _BaseContent.Content = "MyCompany" + Content;
        return this;
    }

    public override IBaseContentBuilder SetFooter(string Footer)
    {
        _BaseContent.Footer = Footer;
        return this;
    }

    public override IBaseContentBuilder SetHeader(string Header)
    {
        _BaseContent.Header = Header;
        return this;
    }

    public override IBaseContentBuilder SetSendDate(DateTime SendDate)
    {
        _BaseContent.SendDate = SendDate;
        return this;
    }

    public override IBaseContentBuilder SetWriter(string Writer)
    {
        _BaseContent.Writer = Writer;
        return this;
    }
}
