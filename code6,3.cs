int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    string[] rowValues = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = int.Parse(rowValues[j]);
    }
}
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += matrix[i, i];
}
Console.WriteLine(sum);