// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System.Globalization;

int GetDesiredNumber()
{
    Console.WriteLine("Enter the desired number:");
    int M = Convert.ToInt32(Console.ReadLine());
    return M;
}

int number = GetDesiredNumber();

int[] GetArrayNumber(int size)
{
    int[] arrayNumber = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("enter number");
        arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrayNumber;
}

int SelectArray(int[] arr)
{    
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            result++;
        }
        
    }
    return result;
}


void PrintArray(int[] arr)
{
    Console.WriteLine($"Array: [{String.Join(", ", arr)}]");
}
void PrintResult(int res)
{
    Console.WriteLine($"number > 0 =  {res}");
}
int [] array = GetArrayNumber(number);

void MainFunction(int[] arr)
{
    PrintArray(arr);
    PrintResult(SelectArray(arr));
}

MainFunction(array);



