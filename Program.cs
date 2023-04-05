// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int N = GetInt();

int GetInt()
{
    System.Console.WriteLine("Введите целое пятизначное число: ");
    int N = int.Parse(Console.ReadLine());
    return N;
}

int M = Last();

int Last()
{
    int M = N % 10;
    return M;
}

int H = First();

int First()
{
    int H = N / 10000;
    return H;
}

int K = Sec();

int Sec()
{
    int K = N / 1000;
    return K;
}

int B = Forth();

int Forth()
{
    int B = N / 10;
    return B;
}

if (M == H)
{
    int sec = K % 10;
    int forth = B % 10;

    if (sec == forth)
    {
        Console.WriteLine("Число полиндром");
    }
    else
    {
        Console.WriteLine("Число не полиндром");
    }
}
else
{   
    Console.WriteLine("Число не полиндром");
}

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int Read(string coordinate)
{
    System.Console.WriteLine($"Введите координату {coordinate}:");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x1 = Read("x1");
int y1 = Read("y1");
int z1 = Read("z1");
int x2 = Read("x2");
int y2 = Read("y2");
int z2 = Read("z2");

double vect = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);

Console.WriteLine("Длина отрезка: ");
Console.WriteLine(vect);

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.