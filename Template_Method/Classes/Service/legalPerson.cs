using Template_Method.Classes.interfaces;

namespace Template_Method.Classes.Service;
public class legalPerson : RegisterUser
{
    public override void ValidateUser()
    {
        Console.WriteLine("With legal");
    }

    public override void SendMessage()
    {
        Console.WriteLine("Send Email legal");
    }

   
}
