using Template_Method.Classes.interfaces;
using Template_Method.Classes.Service;

Console.WriteLine("legal");


RegisterUser _legal = new legalPerson();
_legal.DoAction();
Console.WriteLine("Normal");

RegisterUser _Normal = new NormalPerson();
_Normal.DoAction();
Console.ReadKey();