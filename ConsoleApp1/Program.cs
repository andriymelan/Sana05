using ConsoleApp1;


MyDate StartDate = new MyDate(2000, 12, 1, 17, 50);
MyDate FinishDate = new MyDate(2000, 12, 2, 11, 03);
Airplane airplane = new Airplane("Kyiv", "London", StartDate, FinishDate);
Airplane airplane1 = new Airplane(airplane);
Console.WriteLine(airplane.GetTotalTime());
Console.WriteLine(airplane.IsArrivingToday());

Currency dollar = new Currency("USD", "38,50");
Currency euro = new Currency("EUR", "42,15");
Currency pln = new Currency("PLN", "9,50");
Product product = new Product("phone","560,5",euro,120,"Samsung","130,2");
Product product1 = new Product(product);
Console.WriteLine(product.GetPriceInUAH());
Console.WriteLine(product.GetTotalPriceInUAH());
Console.WriteLine(product.GetTotalWeight());