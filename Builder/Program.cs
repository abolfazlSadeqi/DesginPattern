using Builder.Classes.Instance;
using Builder.Classes.Service;


var _EmailContent = new EmailContent();
var ff= _EmailContent.SetWriter("wri").SetContent("CCC").SetFooter("fdfd").SetHeader("he").SetSendDate(DateTime.Now);


BaseContentCreator creatorEmail = new BaseContentCreator(ff);
var _EmailContentfinal= creatorEmail.Build();



var _SmsContent = new SmsContent();
var data = _SmsContent.SetContent("CCC").SetFooter("fdfd").SetHeader("he");


BaseContentCreator creatorsms = new BaseContentCreator(data);
var _smsContentfinal = creatorsms.Build();

Console.WriteLine(string.Join(" ", "Email=", _EmailContentfinal));

Console.WriteLine(string.Join(" ", "sms=", _smsContentfinal));



