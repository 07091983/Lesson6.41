// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите количество чисел М");
int a = Convert.ToInt32(Console.ReadLine());
int[] Array = new int [a];

void mas (int a)

{
    for (int i = 0; i < a; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        Array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
}

int kol(int[] Array)

{
    int i = 0;
    int sum = 0;
    while (i<Array.Length)
    {
        if(Array[i]>0)
        sum = sum + 1;
        i = i+1;
    }
    return sum;
}

mas(a);
 Console.Write($"\n Чисел больше нуля {kol(Array)}");