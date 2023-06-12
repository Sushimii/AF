using System;
//Puxando todas bibliotecas basicas
using System.Globalization;
class Program
{
    public static void Main(string[] args)
    {
        //Declaração de variaveis
        double num, i = 1;

        //Tela pedindo para o usuario digitar um numero
        Console.WriteLine("Digite um número positivo".ToString(CultureInfo.InvariantCulture));
        //Adicionando o valor digitado a variavel "num"
        num = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


        //Condicional enquanto variavel "i" possuir valor menor igual ao valor da variavel "num"
        while (i<= num)
        {
            //Tela mostrando a sequencia de numeros até o que o usuario digitou
            Console.WriteLine(i.ToString(CultureInfo.InvariantCulture)+ "  ");
            //somando um numero a mais na variavel
            i++;
        }
    }
}