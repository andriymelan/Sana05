using ConsoleApp1;

MyDate StartDate = new MyDate(2000, 12, 1, 17, 50);
MyDate FinishDate = new MyDate(2000, 12, 2, 11, 03);
Airplane airplane = new Airplane("Kyiv", "London", StartDate, FinishDate);
Console.WriteLine(airplane.GetTotalTime());
Console.WriteLine(airplane.IsArrivingToday());