using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Classes.Domin;

namespace Visitor.Classes.interfaces;

public interface IElement
{
    void Accept(IVisitor visitor);
}

