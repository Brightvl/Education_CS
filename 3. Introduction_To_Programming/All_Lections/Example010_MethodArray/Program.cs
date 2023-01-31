int[] array = {1,4, 8, 46,7, 2, 5, 8};

int n = array.Length; //Определяет длину массива
int find = 8;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //Нужен для того чтобы остановить программу после первого же выполненого условия иначе покажет 2 индекса 8 
    }
    index++;
}
