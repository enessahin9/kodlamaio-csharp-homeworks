// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//for (int i = 1; i <=100; i+=2) 
//{
//    Console.WriteLine(i);
//}   
//for (int i = 100; i >=0; i-=2) 
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Finished");

//ForLoop();
//WhileLoop();
//DoWhile();
//ForeachLoop();

if (IsPrimeNumber(6))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is not a prime number");
}



Console.ReadLine();

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }

    }
    return result;
}

static void ForeachLoop()
{
    string[] students = new string[3] { "Engin", "Derin", "Salih" };
    foreach (string student in students)
    {
        Console.WriteLine(student);
    }
}

static void DoWhile()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

static void ForLoop()
{
    for (int i = 100; i >= 0; i -= 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished");
}