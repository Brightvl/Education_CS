Console.Write("Введите имя пользователя ");
string? name = Console.ReadLine();

if(name?.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}

//Приветсвие любимого пользователя, без проверок.