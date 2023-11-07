using State.Classes.Domin;
using State.Classes.interfaces;

namespace State.Classes.Service;

public class RankTwo : IState
{


    public void Calculatebenefit(Customer customer)
    {
       
        Console.WriteLine($"Calculatebenefit proccess ,benefit is 15");
    }

}

