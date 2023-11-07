using Template_Method.Classes.interfaces;

namespace Template_Method.Classes.Service;
public class NormalPerson : RegisterUser
{
    public override void ValidateUser()
    {
        Console.WriteLine("With Normal Person");
    }

    public override void SendMessage()
    {
        Console.WriteLine("Send Normal Person");
    }

   
}
