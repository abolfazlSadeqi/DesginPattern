
Setting appSetting = new Setting();
appSetting.Pagesize = 100;
appSetting.Title = "Test";

Setting newapp =appSetting.Clone();
newapp.Pagesize = 150;

Console.WriteLine(appSetting.GetPagesize());
Console.WriteLine(newapp.GetPagesize());


Console.ReadKey();
