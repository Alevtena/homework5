// Task 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/* int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++)
        array[i] = new Random().Next(100,1000);
    return array;
}

void ShowArray (int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int CountChet(int[] array)
{
   int count = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i]%2 == 0) count += 1;
    return count;
}

Console.Write("Input a size of array"+" ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(length);
ShowArray(myArray);
int n =  CountChet(myArray);
Console.WriteLine($"Число четных элементов в массиве {n}"); */

// Task 2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/* int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
        array[i] = new Random().Next(-10, 20);
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumElementOnNechetPosition(int[] array)
{
    int sum = 0;
    for (int i=1; i<array.Length; i=i+2)
        sum = sum + array[i];
    return sum;
}

Console.WriteLine ("Input a size massiva" + " ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);
int result = SumElementOnNechetPosition(myArray);
Console.WriteLine($"Cумма элементов,стоящих на нечетных позициях равна  {result} "); */

// Task 3. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i=0; i<size; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double DifferetMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i=0; i<array.Length; i++)
    {
        if(min>array[i]) min=array[i];
        else if(max<array[i]) max=array[i];
    }
    return Math.Round(max-min,2);
   
}
Console.Write("Input a size  of massiv" + " ");
int length = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(length);
ShowArray(myArray);
double result = DifferetMaxMin(myArray);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {result}");