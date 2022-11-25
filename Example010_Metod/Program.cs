int[] array = {1, 12, 31, 18, 15, 16, 17, 18};

int n = array.Length;       // длина массива
int find = 18;              // ищем число в массиве 

int index = 0;              //  счетчик 

while (index < n)           // условие пока индекс меньши дленны массива
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;                          // если есть одинаковые числа в массиве и нужно найти только одно
    }
    //index = index + 1;
    index++;

}

