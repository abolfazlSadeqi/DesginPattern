
using State.Classes.interfaces;
using State.Classes.Service;

namespace State.Classes.Domin;
public class Customer
{
    public IState _state { set; get; }



    public Customer()
       => _state = new RankOne();



    public void Calculatebenefit()
      =>
        _state.Calculatebenefit(this);








}

