using Visitor.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Classes.interfaces;

namespace Visitor.Classes.Domin;


public class ShortTermAccount : Account, IElement
{
    public int MinBalnace { get; set; }
    // Constructor
    public ShortTermAccount(int MinBalnace)
      
    {
        this.MinBalnace = MinBalnace;
    }

    public void Accept(IVisitor visitor) => visitor.Visit(this);

}