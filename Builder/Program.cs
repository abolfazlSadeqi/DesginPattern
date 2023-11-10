using Builder.Classes.Service;

var _EmailContent = new EmailContent();
var ff = _EmailContent.SetWriter("testwri").SetContent("testcontnt").SetFooter("testfooter").SetHeader("testheader").SetSendDate(DateTime.Now);


BaseContentCreator creatorEmail = new BaseContentCreator(ff);
var _EmailContentfinal = creatorEmail.Build();



var _SmsContent = new SmsContent();
var data = _SmsContent.SetContent("testcontnt").SetFooter("testfooter").SetHeader("testheader");


BaseContentCreator creatorsms = new BaseContentCreator(data);
var _smsContentfinal = creatorsms.Build();

Console.WriteLine(string.Join(" ", "Email=", _EmailContentfinal));

Console.WriteLine(string.Join(" ", "sms=", _smsContentfinal));
