using NumComplexoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kauã Cordeiro Durães de Lima - 12311ECP017

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a parte real (x) do primeiro número complexo: ");
        double real1 = double.Parse(Console.ReadLine());
        Console.Write("Digite a parte imaginária (y) do primeiro número complexo: ");
        double imaginario1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a parte real (x) do segundo número complexo: ");
        double real2 = double.Parse(Console.ReadLine());
        Console.Write("Digite a parte imaginária (y) do segundo número complexo: ");
        double imaginario2 = double.Parse(Console.ReadLine());

        NumComplexo z1 = new NumComplexo(real1, imaginario1);
        NumComplexo z2 = new NumComplexo(real2, imaginario2);

        NumComplexo soma = z1.Soma(z2);
        Console.WriteLine("Soma:");
        soma.ImprimeFormaPolar();

        NumComplexo produto = z1.Vezes(z2);
        Console.WriteLine("Produto:");
        produto.ImprimeFormaPolar();

        Console.ReadLine();
    }
}
