using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes.interfaces;

public interface ICalcauteBalance
{
    bool CheckLoanConditions(long AccountId);
}
