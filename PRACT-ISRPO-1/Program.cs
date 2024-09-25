// создание двумерной матрицы
double[,] matr =
{
     { 5.4, 2.7, 9.1 },
{ 3.2, 8.6, 1.5 },
{ 7.8, 6.3, 4.9 }
};
// преобразование из двумерной матрицы в одномерную
int rowCount = matr.GetLength(0);
int colCount = matr.GetLength(1);
double[] flattenedMatrix = new double[rowCount * colCount];
int index = 0;
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
        flattenedMatrix[index] = matr[i, j];
        index++;
    }
}
// Сортируем одномерный массив по убыванию

static void sortmatrix(double[] flattenedMatrix)
{

    Array.Sort(flattenedMatrix, (a, b) => b.CompareTo(a));
}


// Вывод отсортированной матрицы
 void printmatr(double[,] matr)
{

    index = 0;
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            matr[i, j] = flattenedMatrix[index];
            index++;
        }
    }

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
printmatr(matr);