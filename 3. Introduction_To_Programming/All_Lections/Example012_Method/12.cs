/* 1 вид метода:
Ничего не принимают ничего не возвращают */
void Method1()
{
    Console.WriteLine("Автор...");
}

//Method1(); //Вызов метода


/* 2 вид метода:
Принимает аргументы, но ничего не возвращает */
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

//допустим надо вызвать сообщение определенное коллчисевто раз
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21(msg: "Текст", count: 4);
//Method21(count:4, msg: "ТЕКСТ");

/* 3 вид метода:
возвращают но не принимают аргументы */

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

/* Методы которые что то принимают и возвращают */

string Method4(int count, string text)
{
    string result = String.Empty; //Пустая строка

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
//Console.WriteLine(res);

/* Цикл в цикле
Таблица умножения */

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

/* Дан текст. В тексте нужно все пробелы заменить черточками, 
маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
маленькими “с”. */

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого "
//             + "Винценгероде, вы бы взяли приступом согласие "
//             + "прусского короля. Вы так красноречивы. Вы "
//             + "дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;//пустая строка;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|'); // у char одинарные кавычки

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);


//от наиментьшего к наибольшему перебор 
int[] arr = { 1, 23, 213, 4, 4, 56, 7, 72, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++) //поиск макс
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; //смена
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
