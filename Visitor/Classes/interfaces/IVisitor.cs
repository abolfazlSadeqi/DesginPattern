using Visitor.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Visitor.Classes.Domin;

namespace Visitor.Classes.interfaces;

public interface IVisitor
{
    void Visit(ShortTermAccount element);
    void Visit(LongTermAccount element);
    
}
