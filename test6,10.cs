int N = int.Parse(Console.ReadLine());
int[,] matrix = new int[N, N];
for (int i = 0; i < N; i++)
{
    string[] rowValues = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        matrix[i, j] = int.Parse(rowValues[j]);
   }
}
int sum = 0;
for (int i = 0; i < N; i++)
{
    sum += matrix[i, i];
}
int sum2 = 0;
for (int i = 0; i < N; i++)
{
    sum2 += matrix[i, N - 1 - i];
}
int difference = sum2 - sum;
Console.WriteLine(difference);