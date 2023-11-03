using Decorator.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes.Service;

public class AccountBalanceDecorator : ICalcauteBalance
{
    readonly ICalcauteBalance _iCalcauteBalance;
    protected AccountBalanceDecorator(ICalcauteBalance _ICalcauteBalance)
    {
        _iCalcauteBalance = _ICalcauteBalance;
    }
    public virtual bool CheckLoanConditions(long AccountId)
    {
        return _iCalcauteBalance.CheckLoanConditions(AccountId);
    }
}
