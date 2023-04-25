Console.Write("Введите цену за кг конфет: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите граммовку общего кол-ва конфет: ");
double y = double.Parse(Console.ReadLine());
Console.Write("Ваш бюджет: ");
double k = double.Parse(Console.ReadLine());

Console.WriteLine(y + "кг  конфет будут стоить " + (x * y) + "р");
Console.WriteLine("на " + k + "р вы можете купить" + k/x + "кг конфет");