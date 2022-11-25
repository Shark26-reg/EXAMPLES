void FillArray(int[] collection)                  // метод который берет 10 случайных чисел и записывает в массив
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
        
    }
}

void PrintArray(int[] col)                        // метод который распечатывает массив 
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    } 
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;                                           //указываем начальную позицию поиска можно поставить вместо 0 -1 и будем интерпретировать что такой элемент не найден
    while (index < count)
    {
        if(collection[index] == find)                         // ищем совпадения в массиве заданному числу
        {
            position = index;
            break;                                            // с этим опиратором останавливаем поиск после нахождения первого совпадения, без него ищет последнее совпадение а предыдущее пропускает
        }
        index++;
    }
    return position;
}
int[] array = new int[10];   // создай новый массив в котором будет 10 элементов

FillArray(array);
array[4] = 4;                                        //принудительно добавили 4 на 4 индекс и на 6     
array[6] = 4;

PrintArray(array);
Console.WriteLine();                           // убедимся что не является частью вывода массива

int pos = Index0f(array, 44);                   // определили переменную pos и положим результат работы метода Index0f, array-передаем наш массив и ищем 4       
Console.WriteLine(pos);