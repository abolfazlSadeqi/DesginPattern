namespace Decorator.Classes.interfaces
{
    public interface IAccountBalanceServiceBase
    {

        public long GetMaxBalance(long AccountId);
        public long GetMinBalance(long AccountId);
    }
}