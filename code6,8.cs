string[] dimensions = Console.ReadLine().Split();
int n = int.Parse(dimensions[0]);
int m = int.Parse(dimensions[1]);
int[,] matrix = new int[n, m];
for (int row = 0; row < n; row++)
{
    string[] rowValues = Console.ReadLine().Split();
    for (int col = 0; col < m; col++)
    {
        matrix[row, col] = int.Parse(rowValues[col]);
    }
}
int maxSum = int.MinValue;
int startRow = 0;
int startCol = 0;
for (int row = 0; row <= n - 3; row++)
{
    for (int col = 0; col <= m - 3; col++)
    {
        int currentSum = CalculateSum(matrix, row, col);
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            startRow = row;
            startCol = col;
        }
    }
}
Console.WriteLine($"Sum = {maxSum}");
for (int i = startRow; i < startRow + 3; i++)
{
    for (int j = startCol; j < startCol + 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
static int CalculateSum(int[,] matrix, int startRow, int startCol)
{
    int sum = 0;
    for (int i = startRow; i < startRow + 3; i++)
    {
        for (int j = startCol; j < startCol + 3; j++)
        {
            sum += matrix[i, j];
        }
    }
    return sum;
}