using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes.Domin;

public class AccountBalance
{
    public long AccountId { get; set; }
    public long MinBalance { get; set; }
    public long MaxBalance { get; set; }
    public DateTime BalanceDate { get; set; }

}
