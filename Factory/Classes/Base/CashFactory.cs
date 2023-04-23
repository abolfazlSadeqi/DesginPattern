namespace Factory.Classes.Base;

class CashFactory : PayFactory
{
    private string amount;
    public CashFactory(string Amount)
    {
        amount = Amount;

    }

    public override string GetPayType()
    {
        return "Pay Type:cash,Amount=" + amount;
    }
}

