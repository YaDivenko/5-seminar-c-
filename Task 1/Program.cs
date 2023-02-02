Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100,1000);
}

foreach (var item in arr)
{
    System.Console.Write(item + " ");
}
int count = 0;

for (int j = 0; j < arr.Length; j++)
if (arr[j] % 2 == 0)
count++;

Console.WriteLine("\n" + $"четных чисел {count}");

