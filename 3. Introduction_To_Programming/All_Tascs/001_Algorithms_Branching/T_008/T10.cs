/* Проверяется правильность введенного логина строго из 5 букв
и пароля из 6 и более цифр. */

// string myLog = "qwerty", myPas = "asdf";
// string mes = "", mesYes = "Добро пожаловать!", mesNo = "Вход воспрещен!";

// Console.Write("Введите логин: ");
// string log = Console.ReadLine(); // вводим логин
// // проверяем длину и совпадение логина

// if (log.Length < 6) mes = "Логин очень короткий!\n" + mesNo;
// else if (log != myLog) mes = "Неверный логин!\n" + mesNo;
// else
// // в случае истинности логина вводим и проверяем пароль
// { 
//     Console.Write("Введите пароль: ");
//     string pas = Console.ReadLine(); // вводим пароль
//     mes = (pas == myPas) ? mesYes : "Неверный пароль!\n" + mesNo;
// }
// Console.WriteLine(mes); // выводим сообщения
// Console.ReadKey();

string myLog = "qwert", myPas = "123456";
string mes = "", mesYes = "Добро пожаловать!", mesNo = "Вход воспрещен!";

Console.Write("Введите логин: ");
string log = Console.ReadLine(); // вводим логин

if (log.Length != 5) mes = "Incorrect login Length!\n" + mesNo; // проверяем длину логина
else if (log != myLog) mes = "Неверный логин!\n" + mesNo; //Проверяем совпадение логина
else // в случае истинности логина вводим и проверяем пароль
{ 
    Console.Write("Введите пароль: ");
    string pas = Console.ReadLine(); // вводим пароль
    if (pas.Length >= 6 && int.TryParse(pas, out int intPas) && pas == myPas)
    {
        mes = mesYes;
    }
    else
    {
        mes = "Неверный пароль!\n" + mesNo;
    }
}
Console.WriteLine(mes); // выводим сообщения