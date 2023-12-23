DateTime date = new DateTime(2002,10,1);

DateTime dateTime = DateTime.Now;
DateTime date1 = DateTime.UtcNow;

DateTime future = dateTime.AddDays(1);

Console.WriteLine(future.DayOfWeek.ToString());
