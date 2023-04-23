

using Singleton.Classes.Base;
using Singleton.Classes.Instance;


EmployeeCURD Employees = SingletonBase<EmployeeCURD>.Instance;
string Result = Employees.GetNameCode(new Employee() { Name = "H", Code = "5" });
Console.WriteLine($"Result = {Result}");

EmployeeCURD Employees2 = SingletonBase<EmployeeCURD>.Instance;
Result = Employees2.GetNameCode(new Employee() { Name = "Haa", Code = "5" });
Console.WriteLine($"Result = {Result}");

Console.WriteLine("Hello, World!");
