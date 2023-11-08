using Iterator.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Classes.Instance
{
    ////Builder 
    public abstract class IBaseContentBuilder
    {
        public abstract IBaseContentBuilder SetHeader(string Header);
        public abstract IBaseContentBuilder SetFooter(string Footer);
        public abstract IBaseContentBuilder SetSendDate(DateTime SendDate);
        public abstract IBaseContentBuilder SetContent(string Content);

        public abstract IBaseContentBuilder SetWriter(string Writer);

        public abstract string Build();
    }
}
