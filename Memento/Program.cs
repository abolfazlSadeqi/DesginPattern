using Memento.Classes.Service;

AppSettings settings = new AppSettings();
SettingCareTaker _SettingCareTaker = new SettingCareTaker();


settings._Setting = new Memento.Classes.Domin.Settings(50, "test", "test", 152);

_SettingCareTaker.Save(settings.Save());

settings._Setting._Title = "test50";
settings._Setting._PageSize = 1002;

Console.WriteLine($"PageSize= {settings._Setting._PageSize}");
Console.WriteLine($"Title= {settings._Setting._Title}");

Console.WriteLine("----Restore----");
settings.Restore(_SettingCareTaker.GetLast());

Console.WriteLine($"PageSize= {settings._Setting._PageSize}");
Console.WriteLine($"Title= {settings._Setting._Title}");



Console.ReadKey();