int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
for (int row = 0; row < n; row++)
{
    string rowData = Console.ReadLine();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = rowData[col];
    }
}
char symbolToFind = char.Parse(Console.ReadLine());
bool found = false;
int foundRow = -1;
int foundCol = -1;
for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (matrix[row, col] == symbolToFind)
        {
            found = true;
            foundRow = row;
            foundCol = col;
            break;
        }
    }
    if (found)
    {
        break;
    }
}
if (found)
{
    Console.WriteLine($"({foundRow}, {foundCol})");
}
else
{
    Console.WriteLine($"{symbolToFind} does not occur in the matrix");
}