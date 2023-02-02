//  Ввести массив с клавиатуры, вычислить произведение элементов и записать его в новый массив.
// 1. Вводим с клавиатуры количество элементов массива
int GetNumberByUser()
{
    Console.WriteLine("Введите число N: ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Создаем массив с заданным количеством элементов
int[] CreateArray(int size)
{
    return new int[size];
}


// 3. Заполняем массив данными с клавиатуры
void FillArrayByUser(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Число {i + 1} = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// 4. Создаем новый массив для записи перемноженных элементов
int[] CreateNewArray(int size)
{
    int[] matr;
    if (size % 2 == 0)
    {
        matr = new int[size / 2];
    }
    else matr = new int[size / 2 + 1];
    return matr;
}

// 5. Заполняем массив перемноженными элементами
void FillArrayByMultiply(int[] array, int[] matr)
{
    if (array.Length % 2 == 0)          // Цикл если четное количество элементов массива byUser
    {
        for (int i = 0; i <= matr.Length - 1; i++)
        {
            matr[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    else
    {
        for (int i = 0; i < matr.Length - 1; i++)       // Цикл при нечетном кол-ве элтов ByUser
        {
            matr[i] = array[i] * array[array.Length - 1 - i];
        }
        matr[matr.Length - 1] = array[matr.Length - 1];
    }
}

// 6. Печать нового массива после перемножения элементов
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
}

int number = GetNumberByUser();
Console.WriteLine();
int[] massiveByUser = CreateArray(number);
FillArrayByUser(massiveByUser);
int[] result = CreateNewArray(number);
FillArrayByMultiply(massiveByUser, result);
Console.WriteLine();
Console.WriteLine("Новый массив: ");
PrintArray(result);


