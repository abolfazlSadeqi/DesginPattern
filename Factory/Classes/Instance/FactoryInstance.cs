using Factory.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Classes.Instance
{
    public class FactoryInstance
    {
        public static string GetPayType(string typePay, string amount)
        {
       
            if (typePay == "cash")
                return new CashFactory(amount).GetPayType();

            return new AccountFactory(amount).GetPayType();

        }

    }
}
