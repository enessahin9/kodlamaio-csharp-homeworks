﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] students = new string[4];
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";
//string[] students = new string[3] { "Engin", "Derin", "Salih" };
string[] students2 = { "Engin", "Derin", "Salih" };

foreach (string student in students2)
{
    Console.WriteLine(student);
}
Console.WriteLine("*********");
string[,] regions = new string[5, 3]
    {
        {"İstanbul","İzmit","Balıkesir" },
        {"Ankara","Konya","Kırıkkale" },
        {"Antalya","Adana","Mersin" },
        {"Rize","Trabzon","Samsun" },
        {"İzmir","Muğla","Manisa" }
    };

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("**************");
}
Console.ReadLine();
