﻿// See https://aka.ms/new-console-template for more information

static void Menu()
{
    Menu();
}
Console.Clear();

Console.WriteLine("O que deseja fazer?");
Console.WriteLine("1 Soma");
Console.WriteLine("2 Subritação");
Console.WriteLine("3 Mutiplicação");
Console.WriteLine("4 Divisão");
Console.WriteLine("5 Sair");

Console.WriteLine("-----------");
Console.WriteLine("Selecione uma opção");

short res = short.Parse(Console.ReadLine());

switch (res)
{
    case 1: Soma(); break;
    case 2: Subtacao(); break;
    case 3: Divisao(); break;
    case 4: Multiplicacao(); break;
    case 5: System.Environment.Exit(0); break;
    default: Menu(); break;

}
static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2;
    // Console.WriteLine("O resultado da soma é " + resultado);
    Console.WriteLine($"O resultado da soma é {resultado}");
    // Console.WriteLine("O resuldato da soma é {v1 + v2}");
    // Console.WriteLine("O resuldato da soma é + (v1 + v2)");
    Console.ReadKey();
    Menu();

}
static void Subtacao()
{
Console.WriteLine();

Console.WriteLine("Primeiro valor:");
float v1 = float.Parse(Console.ReadLine());

Console.WriteLine("Segundo valor:");
float v2 = float.Parse(Console.ReadLine());

Console.WriteLine("");

float resultado = v1 - v2;
Console.WriteLine($"O resultado da subtração é {resultado}");
Console.ReadKey();
Menu();
}
static void Divisao()
{
Console.WriteLine();

Console.WriteLine("Primeiro valor:");
float v1 = float.Parse(Console.ReadLine());

Console.WriteLine("Segundo valor:");
float v2 = float.Parse(Console.ReadLine());

Console.WriteLine("");

float resultado = v1 / v2;
Console.WriteLine($"O resultado da divisão é {resultado}");
Console.ReadKey();
Menu();
}
static void Multiplicacao()
{
Console.WriteLine();

Console.WriteLine("Primeiro valor:");
float v1 = float.Parse(Console.ReadLine());

Console.WriteLine("Segundo valor:");
float v2 = float.Parse(Console.ReadLine());

Console.WriteLine("");

float resultado = v1 * v2;
Console.WriteLine($"O resultado da Multiplicação é {v1 * v2}");
Console.ReadKey();
Menu();
}
