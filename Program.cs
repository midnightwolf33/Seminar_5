// Урок 5. Функции и одномерные массивы

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.



// void FillArray(int [] array);
// {
//     for (int i=0; i<array.Lenght; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int [] array);
// {
//     foreach (int el in array)
//     {
//         Console.WriteLine($"{el} ");
//     }    
//     Console.WriteLine();
// }

// void Summa(int [] array);
// {
//     int sump = 0;
//     int sumn = 0;
//     for (int i = 0; i < array.Length; i++);
//         if (array [i] > 0) sump += array[i];
//         else sumn+=array[i];

//     int[] results = {sump,sumn};
//     return results; 
// }


// int [] array = new int[12];
// FillArray(array);
// PrintArray(array);
// Summa(array);
// int []rez Summa2(array);
// PrintArray(Summa2(array));
// Console.WriteLine($"Сумма положительных элементов равна {rez[0]}");
// Console.WriteLine($"Сумма отрицательных элементов равна {rez[1]}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// Random rnd = new Random();
// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// int[] create1DArray(int len, int num1, int num2)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
//     }
//     return arr;
// }
// void show1DArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
// int[] reverse1DArray(int[] array)
// {
//     int[] arr=array;
//     for (int i = 0; i < array.Length; i++)
//     {
//         arr[i]*=-1;
//     }
//     return arr;
// }
// int len = InputNum("Введите длинну массива: ");
// int num1 = InputNum("Введите минимум для значений в массиве: ");
// int num2 = InputNum("Введите максимум для значений в массиве: ");
// Console.WriteLine("Оригинал:");
// int[]arr=create1DArray(len,num1,num2);
// show1DArray(arr);
// Console.WriteLine("реверс:");
// int[]reverse_arr=reverse1DArray(arr);
// show1DArray(arr);



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string res)
// {
//     Console.WriteLine(res);
// }

// int[] Gen1DArray(int len, int minValue, int maxValue)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// int Search(int[] arr, int e)
// {
//     int res = -1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == e)
//         {
//             res = i;
//             break;
//         }
//     }
//     return res;
// }

// int[] testArr = Gen1DArray(12, -9, 9);
// Print1DArr(testArr);
// int element = ReadData("Какой элемент найти?: ");
// int result = Search(testArr, element);

// if (result >= 0)
// {
//     PrintData("Элемент найден в позиции: " + (result+1));
// }
// else
// {
//     PrintData("В массиве элемент не найден!");
// }


// Задача 35: Задайте одномерный массив из 12 случайных чисел от -100 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5,
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int [] array )  
{      
    for (int i =0; i<array.Length; i++)          
    array[i] = new Random().Next(-100,101);  
}   
void PrintArray(int [] array)  
{      
    foreach (int el in array)      
    {          
        Console.Write($"{el} ");      
    }      
    Console.WriteLine();  
}  
int Count(int [] array) 
{ 
    int count=0; 
    foreach(int el in array) 
    { 
        if(el>=10 && el<100) count++ ;           
         
    } 
    return count; 
} 
 
int [] array  = new int [12];  
FillArray(array); 
PrintArray(array); 
Console.WriteLine($"Количество цифр от 10 до 99 {Count(array)}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

int[] Sum(int[] array)
{
    int[] res = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        res[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    {
        res[array.Length / 2] = array[array.Length / 2];
    }

    return res;

}


Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

FillArray(array);
PrintArray(array);
int[] result = Sum(array);
PrintArray(result);