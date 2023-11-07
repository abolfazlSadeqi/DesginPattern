using State.Classes.Domin;
using State.Classes.interfaces;

namespace State.Classes.Service;

public class RankOne : IState
{


    public void Calculatebenefit(Customer customer)
    {
     
        Console.WriteLine($"Calculate benefit proccess ,benefit is 10");
    }

}
