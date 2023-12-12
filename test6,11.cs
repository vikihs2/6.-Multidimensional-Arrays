string[] dimensions = Console.ReadLine().Split();
int n = int.Parse(dimensions[0]);
int m = int.Parse(dimensions[1]);
string[,] matrix = new string[n, m];
for (int row = 0; row < n; row++)
{
    string[] rowValues = Console.ReadLine().Split(' ');
    for (int col = 0; col < m; col++)
    {
        matrix[row, col] = rowValues[col];
    }
}
while (true)
{
    string input = Console.ReadLine();
    if (input == "END")
    {
        break;
    }
    string[] tokens = input.Split(' ');
    if (tokens.Length != 5 || tokens[0] != "exchange")
    {
        Console.WriteLine("The input is invalid!");
        continue;
    }
    int row1 = int.Parse(tokens[1]);
    int col1 = int.Parse(tokens[2]);
    int row2 = int.Parse(tokens[3]);
    int col2 = int.Parse(tokens[4]);
    if (row1 < 0 || row1 >= n || col1 < 0 || col1 >= m || row2 < 0 || row2 >= n || col2 < 0 || col2 >= m)
    {
        Console.WriteLine("The input is invalid!");
        continue;
    }
    string temp = matrix[row1, col1];
    matrix[row1, col1] = matrix[row2, col2];
    matrix[row2, col2] = temp;
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}