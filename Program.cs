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
