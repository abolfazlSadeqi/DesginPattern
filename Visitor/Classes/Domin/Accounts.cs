using Visitor.Classes.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Classes.interfaces;

namespace Visitor.Classes.Domin;


public class Accounts
{
    private List<IElement> _Accounts = new List<IElement>();
    public Accounts(List<IElement> accounts)
    {
        _Accounts = accounts;
    }

    public void Attach(IElement Account)
    {
        _Accounts.Add(Account);
    }
    public void Detach(IElement Account)
    {
        _Accounts.Remove(Account);
    }
    public void Accept(IVisitor visitor)
    {
        foreach (var Account in _Accounts)
        {
            Account.Accept(visitor);
        }
        Console.WriteLine();
    }
}
