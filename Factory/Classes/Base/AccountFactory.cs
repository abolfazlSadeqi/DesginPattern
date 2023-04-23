using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes.Base;
class AccountFactory : PayFactory
{
    private string amount;

    public AccountFactory(string Amount)
    {
        amount = Amount;

    }

    public override string GetPayType()
    {
        return "Pay Type:Account,Amount=" + amount;
    }
}

