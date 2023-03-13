using PZ7_3;

List<Holiday> Holidays = new List<Holiday>();
List<Client> Clients = new List<Client>();

#region Клиенты

Client Fedor = new Client("Fedor", Status.VIP);
Client Nikolay = new Client("Nikolay", Status.VIP);
Client Tolik = new Client("Tolik", Status.Rookie);
Client Olega = new Client("Olega", Status.Rookie);
Client Nikitka = new Client("Nikitka", Status.Amateur);
Client Mihuil = new Client("Mihuil", Status.Amateur);
Client Dimas = new Client("Dimas", Status.Amateur);

Clients.Add(Fedor);
Clients.Add(Nikolay);
Clients.Add(Tolik);
Clients.Add(Olega);
Clients.Add(Nikitka);
Clients.Add(Mihuil);
Clients.Add(Dimas);

#endregion

#region Праздники

Holiday GirlsDay = new Holiday("GirlsDay", new DateTime(2023, 03, 8), Status.VIP);
Holidays.Add(GirlsDay);

Holiday DayOfWork = new Holiday("DayOfWork", new DateTime(2023, 5, 1), Status.VIP);
Holidays.Add(DayOfWork);

Holiday DayOfWin = new Holiday("DayOfWin", new DateTime(2023, 5, 9), Status.VIP);
Holidays.Add(DayOfWin);

Holiday Easter = new Holiday("Easter", new DateTime(2023, 4, 16), Status.Rookie);
Holidays.Add(Easter);

Holiday SpaceDay = new Holiday("SpaceDay", new DateTime(2023, 4, 12), Status.Rookie);
Holidays.Add(SpaceDay);

#endregion

#region Подписки

foreach (var h in Holidays)
{
    foreach (var c in Clients)
    {
        h.RegisterClient(c);
    }
}

#endregion
//6959959849848

while (true)
{
    DateTime date = requestDate();
    Notificate(getHolidays(date.AddDays(7)));
}

void Notificate(List<Holiday> holidays)
{
    holidays.ForEach(holiday => holiday.Notify());
}

List<Holiday> getHolidays(DateTime date)
{
    List<Holiday> holidays = new List<Holiday>();

    foreach (var item in Holidays)
    {
        if(item.date.Equals(date))
            holidays.Add(item);
    }

    return holidays;
}

DateTime requestDate()
{
    DateTime date = new DateTime();

    try
    {
        Console.WriteLine("Введите день");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите мемяц");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год");
        int year = Convert.ToInt32(Console.ReadLine());

        date = new DateTime(year, month, day);
    }
    catch { }
    
    return date;
}