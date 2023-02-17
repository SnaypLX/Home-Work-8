// Составить частотный словарь элементов двумерного массива


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


Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = 0;
int[,] list = new int[m * n, 2];
int k = 0;

bool exist = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int r = 0; r < k; r++)
        {
            if (list[r, 0] == array[i, j])
            {
                list[r, 1]++;
                exist = true;
                break;
            }
        }
        if (exist == false)
        {
            list[k, 0] = array[i, j];
            list[k, 1]++;
            k++;
        }
    }
}
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < list.GetLength(1); j++)
    {
        Console.Write($"{list[i, j]} ");
    }
    Console.WriteLine();
}