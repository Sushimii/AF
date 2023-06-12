using System;
//Puxando todas bibliotecas basicas
using System.Globalization;
class Program
{
    public static void Main(string[] args)
    {
        double num, i = 1;

        Console.WriteLine("Digite um número positivo".ToString(CultureInfo.InvariantCulture));
        num = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        while (i<= num)
        {
            Console.WriteLine(i.ToString(CultureInfo.InvariantCulture)+ "  ");
            i++;
        }
    }
}