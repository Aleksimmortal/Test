Console.WriteLine("Hello, World!");

int a = 6;
int b = 7;
int sum = a + b;
Console.WriteLine(sum);
Console.ReadLine();

for (int i = 0; i < sum; i++)
{
    Console.WriteLine(i);
}

Console.ReadLine();

int [] mas = new int [5];

for (int i = 0;i < mas.Length;i++)
{
    mas[i] = i;
    Console.WriteLine(i);
}

Console.WriteLine("Введите высоту треугольника:  ");
int height = int.Parse(Console.ReadLine());

for (int i = 0; i < height; i++)
{
    for (int j = height; j > i; j--)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.ReadLine();
