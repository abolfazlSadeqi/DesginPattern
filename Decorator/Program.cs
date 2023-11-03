using Decorator.Classes.interfaces;
using Decorator.Classes.Service;

int AccountId = 1;
ICalcauteBalance calcauteBalanceService = new CalcauteBalanceService();
Console.WriteLine("Check="+ calcauteBalanceService.CheckLoanConditions(AccountId));

var AccountBalanceDecorator = new CalcauteBalanceDecorator(calcauteBalanceService);
Console.WriteLine("Checknew=" + AccountBalanceDecorator.CheckLoanConditions(AccountId));

Console.ReadLine();