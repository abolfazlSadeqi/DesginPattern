using Decorator.Classes.Domin;
using Decorator.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes.Service;

public class CalcauteBalanceDecorator : AccountBalanceDecorator
{
    public readonly IAccountBalanceServiceBase _IAccountBalanceServiceBase;
    public CalcauteBalanceDecorator(ICalcauteBalance _ICalcauteBalance)
       : base(_ICalcauteBalance)
    {
        _IAccountBalanceServiceBase = new AccountBalanceService();
    }


    public override bool CheckLoanConditions(long AccountId)
    {
        var minCheckLoanConditions = base.CheckLoanConditions(AccountId);
        var MaxCheckLoanConditions = _IAccountBalanceServiceBase.GetMaxBalance(AccountId) > BalanceSetting.Balance ? true : false;
        return minCheckLoanConditions && MaxCheckLoanConditions;
    }
}
