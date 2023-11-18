

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int size = 2;

int[] GetFirstLineCoefficient(int size)
{
    int[] firstLine = new int[size];
    Console.WriteLine("Input coefficient k1");

    firstLine[0] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input coefficient b1");
    firstLine[1] = Convert.ToInt32(Console.ReadLine());

    return firstLine;

}

int[] GetSecondLineCoefficient(int size)
{
    int[] secondLine = new int[size];
    Console.WriteLine("Input coefficient k2");

    secondLine[0] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input coefficient b2");
    secondLine[1] = Convert.ToInt32(Console.ReadLine());

    return secondLine;

}

bool CheckLine(int[] coefficientFirstLine, int[] coefficientSecondLine)
{
    if (coefficientFirstLine[0] == coefficientSecondLine[0])
    {

        if (coefficientFirstLine[1] == coefficientSecondLine[1])
        {
            Console.WriteLine("Lines are coincide");
            return false;
        }

        Console.WriteLine("Lines are parallel");
        return false;
    }
    return true;


}

void GetInterdictionCoordinate(int size,  int[] firstLine, int[] secondLine)
{
    double[] coordinate = new double[size];

    coordinate[0] = (double)(secondLine[1] - firstLine[1]) / (double)(firstLine[0] - secondLine[0]);
    coordinate[1] = firstLine[0] * coordinate[0] + firstLine[1];

    Console.WriteLine($"coordinate interdiction line: X = {coordinate[0]} Y = {coordinate[1]}");
}

int[] firstLine = GetFirstLineCoefficient(size);
int[] secondLine = GetSecondLineCoefficient(size);

if(CheckLine(firstLine, secondLine))
{
    GetInterdictionCoordinate(size, firstLine, secondLine);
}

