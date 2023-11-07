namespace Template_Method.Classes.interfaces;
public abstract class RegisterUser
{

    public void DoAction()
    {

        ValidateUser();
       
        CreateUser();
        SendMessage();
    }
  


    public virtual void ValidateUser()
    {
        Console.WriteLine("ValidateUser");
    }

    public virtual void SendMessage()
    {
        Console.WriteLine("SendMessage");
    }

    public virtual void CreateUser()
    {
        Console.WriteLine("CreateUser");
    }
}
