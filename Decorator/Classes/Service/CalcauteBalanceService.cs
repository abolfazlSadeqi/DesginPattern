using Decorator.Classes.Domin;
using Decorator.Classes.interfaces;

namespace Decorator.Classes.Service;


public class CalcauteBalanceService : ICalcauteBalance
{
    public readonly IAccountBalanceServiceBase _IAccountBalanceServiceBase;
    public CalcauteBalanceService()
    {
        _IAccountBalanceServiceBase = new AccountBalanceService();
    }
    public bool CheckLoanConditions(long AccountId) => _IAccountBalanceServiceBase.GetMinBalance(AccountId) > BalanceSetting.Balance ? true : false;

}
