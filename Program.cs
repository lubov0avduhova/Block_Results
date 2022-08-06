
//string[] array = {"hello", "2", "world", ":-)"};// Задаем массив на старте

System.Console.WriteLine("Введите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine());
string[] array = new string[count];


FillMassive (array);
PrintArray (FindThree (array));



string[] FillMassive(string[] array) // Метод ручного заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("Введите элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}


string[] FindThree(string[] array) // Метод нахождения строк, длина которых меньше либо равна 3 символа.
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}

void PrintArray(string[] array) //Вывод массива на консоль
{ System.Console.Write("Результат: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
