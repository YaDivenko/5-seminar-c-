Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100);
}

foreach (var item in arr)
{
    System.Console.Write(item + " ");
}

int sum = 0;

for (int j = 0; j < arr.Length; j+=2)
    sum = sum + arr[j];
    System.Console.WriteLine("\n" + $"сумма элементов, стоящих на нечётных позициях {sum}");
