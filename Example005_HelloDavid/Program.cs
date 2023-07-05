Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
 
if (username.ToLower() == "david")
{
    Console.WriteLine("Салют, рад что ты вернулся " + username);
}
else
{
    Console.WriteLine("Добро пожаловать " + username);
}