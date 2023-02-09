Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "амир")
{
    Console.WriteLine("Приветствую, милорд");
}
else
{
    Console.Write("Почему ты не на полях под палящим солнцем, ");
    Console.WriteLine(username);
}