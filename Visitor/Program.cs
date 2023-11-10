using Visitor.Classes.Domin;
using Visitor.Classes.interfaces;
using Visitor.Classes.Service;

var Accounts = new List<IElement>
        {
            new ShortTermAccount(10),
         new LongTermAccount(20)  , new ShortTermAccount(30),
         new LongTermAccount(40)
        };

// monthly
var _monthlyVisitor = new MonthlyVisitor();
Accounts accounts1 = new Accounts(Accounts);
accounts1.Accept(_monthlyVisitor);
Console.WriteLine($"{_monthlyVisitor.Amount:C}");


// tax
var _TaxsVisitor = new TaxsVisitor();

accounts1 = new Accounts(Accounts);
accounts1.Accept(_TaxsVisitor);

Console.WriteLine($"{_TaxsVisitor.Amount}");
Console.ReadLine();