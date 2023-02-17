// Найти произведение двух матриц


void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
void multiplication(int[,] array, int[,] matrix, int[,] mult)
{

    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            {
                mult[m, n] = array[m, n] * matrix[m, n];
            }
            
        }
   }
}



Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
int[,] matrix = new int [m, n];
int[,] mult = new int [m, n];


FillArray(array);
FillArray(matrix);
PrintArray(array);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
multiplication(array, matrix, mult);
PrintArray(mult);