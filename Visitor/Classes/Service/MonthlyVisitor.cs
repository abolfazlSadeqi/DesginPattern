using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Visitor.Classes.Domin;
using Visitor.Classes.interfaces;

namespace Visitor.Classes.Service;


public class MonthlyVisitor : IVisitor
{
    public double Amount { set; get; }

    public void Visit(ShortTermAccount element)
    {
        Amount += element.MinBalnace;
    }

    public void Visit(LongTermAccount element)
    {
        Amount += element.LastBalance;
    }
}
