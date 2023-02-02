Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[size];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = genRndDouble(0,100);
}

foreach (var item in arr)
{
    System.Console.WriteLine(Math.Round(item,2));
}

double genRndDouble (int a, int b)
{
    Random rnd = new Random ();
    double rndDouble = a + rnd.NextDouble() * (b - a);

    return rndDouble;
}

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > max)
        {
            max = arr[j];
        }
    if (arr[j] < min)
        {
            min = arr[j];
        }
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round((max - min),2)}");