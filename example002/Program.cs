Console.WriteLine("Введите ваше имя");
string? username = Console.ReadLine ();
if (username == null)
Console.WriteLine ("Нельзя ввести null");
Console.WriteLine("Привет, ");
Console.WriteLine(username);