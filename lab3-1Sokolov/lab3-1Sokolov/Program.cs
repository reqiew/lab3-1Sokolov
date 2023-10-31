//средний уровень 18
try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    double Z = 1;
    double S = 0;
    for (int j = -1; j <= k; j++)
    {
        if (j != -14) Z *= (j - j * j) / (j + 14);
        for (int i = j; i <= k+3; i++)
        {
            if (i != k + 2) S += (Math.Pow(Math.Abs(i - 5), 1 / 4)) / (Math.Abs(i-7));
        }
    }
    Console.WriteLine($"Z={Z*S:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}