using State.Classes.Domin;
using State.Classes.Service;


var _RankOne = new Customer() { _state = new RankOne() };
_RankOne.Calculatebenefit();


var _RankTwo = new Customer() { _state = new RankTwo() };
_RankTwo.Calculatebenefit();

Console.ReadKey();


