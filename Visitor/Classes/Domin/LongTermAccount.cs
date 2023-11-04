using Visitor.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Classes.interfaces;

namespace Visitor.Classes.Domin;


public class LongTermAccount : Account, IElement
{
    public int LastBalance { get; set; }
    // Constructor
    public LongTermAccount(int lastBalance)
        
    {
        LastBalance = lastBalance;
    }
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
