int m = 3; //количество строк
int n = 4; //количество столбцов

double[,] matrix = {
            {5.9, 2.3, 8.1, 3.7},
            {1.2, 4.5, 6.2, 0.9},
            {3.4, 7.8, 2.1, 5.6}
        };

SortMatrixDescending(matrix, m, n);

Console.WriteLine("Отсортированная матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


static void SortMatrixDescending(double[,] matrix, int m, int n)
{
    double[] temp = new double[m * n];
    int index = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            temp[index] = matrix[i, j];
            index++;
        }
    }

    Array.Sort(temp);
    Array.Reverse(temp);

    index = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = temp[index];
            index++;
        }
    }
}