
using Composite.Classes.interfaces;
using Composite.Classes.Service;

DataSale Branch1 = new BranchStore("Branch1", 1400);
DataSale Branch2 = new BranchStore("Branch2", 2540);
DataSale Branch3 = new BranchStore("Branch3", 1400);
DataSale Branch4 = new BranchStore("Branch4", 14045);

SupervisionStore Area1 = new SupervisionStore("Area1");
SupervisionStore Area2 = new SupervisionStore("Area2");

Area1.Add(Branch1);
Area2.Add(Branch2);
Area2.Add(Branch3);
Area2.Add(Branch4);

Console.WriteLine($"Sales Branch1= {Branch1.GetSale()}");

Console.WriteLine($"Sales Area1= {Area1.GetSale()}");

Console.WriteLine($"Sales Area2= {Area2.GetSale()}");

Console.Read();