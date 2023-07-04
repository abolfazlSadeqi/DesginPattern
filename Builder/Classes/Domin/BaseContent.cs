using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes.Domin;

public class BaseContent
{
    public string Header { get; set; }
    public string Content { get; set; }

    public string Footer { get; set; }
    public DateTime SendDate { get; set; }
    public string Writer { get; set; }



}

//public interface IMail
//{
//    string Topic { get; }
//    IRecipient Recipient { get; }
//    string Body { get; }
//    List<IRecipient> Recipients { get; }
//}

//public class Mail : IMail
//{
//    public string body;
//    public string topic;
//    public IRecipient recipient;
//    public List<IRecipient> recipients = new List<IRecipient>();

//    public string Topic => topic;
//    public string Body => body;
//    public IRecipient Recipient => recipient;
//    public List<IRecipient> Recipients => recipients;
//}

//public interface IRecipient
//{

//    string Name { get; }
//}

//public class Recipient : IRecipient
//{
//    private string name;
//    public Recipient(string _name)
//    {
//        name = _name;
//    }
//    string Name => name;

//}

//public interface IMailBuilder
//{
//    IMailBuilder SetBody();
//    IMailBuilder SetTopic();
//    IMailBuilder SetRecipient();
//    IMailBuilder AddRecipient();
//    IMail GetMail();
//}

//public class MailBuilder : IMailBuilder
//{
//    private IMail mail = new Mail();
//    public MailBuilder SetBody(string body)
//    {
//        mail.body = body;
//        return this;
//    }

//    public MailBuilder SetTopic(string topic)
//    {
//        mail.topic = topic;
//        return this;
//    }

//    public MailBuilder SetRecipient(IRecipient recipient)
//    {
//        mail.recipient = recipient;
//        return this;
//    }

//    public MailBuilder AddRecipient(IRecipient recipient)
//    {
//        mail.recipients.append(recipient);
//        return this;
//    }

//    public IMail GetMail()
//    {
//        if (mail.body != null && mail.recipients != null)
//        {
//            return mail;
//        }

//        throw new Exception("The letter doesn't contain required attributes");
//    }

//    public static void Main(string[] args)
//    {
//        var mailBuilder = new MailBuilder().SetBody("text")
//                                           .SetTopic("topic")
//                                           .SetRecipient(new Recipient("Bob"))
//                                           .AddRecipient(new Recipient("Alisa"));

//        var mail = mailBuilder.GetMail();

//    }
//}
