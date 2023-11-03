using Decorator.Classes.Domin;
using Decorator.Classes.interfaces;

namespace Decorator.Classes.Service;

public class AccountBalanceService : IAccountBalanceServiceBase
{
    public long GetMaxBalance(long AccountId) => GetAccountBalances().First(d => d.AccountId == AccountId && d.BalanceDate.Date == DateTime.Now.Date).MinBalance;
    public long GetMinBalance(long AccountId) => GetAccountBalances().First(d => d.AccountId == AccountId && d.BalanceDate.Date == DateTime.Now.Date).MaxBalance;
    private List<AccountBalance> GetAccountBalances()
    {
        return new List<AccountBalance>() {
            new AccountBalance() { AccountId=1,MaxBalance=110,MinBalance=200,BalanceDate=DateTime.Now.Date },
            new AccountBalance() { AccountId=2,MaxBalance=1400,MinBalance=1300,BalanceDate=DateTime.Now.Date },
            new AccountBalance() { AccountId=3,MaxBalance=300,MinBalance=150,BalanceDate=DateTime.Now.Date },

        };
    }
}
