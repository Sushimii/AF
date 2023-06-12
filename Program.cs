using System;

class Program
{
    public static void Main(string[] args)
    {
        // Declaração da variavel do tipo int
        int num;

        do
        {
            // Solicita ao usuario que digite um numero entre 1 e 10
            Console.Write("Digite um numero entre 1 e 10: ");
            //Lendo o valor para adicionar a variavel
            num = int.Parse(Console.ReadLine());

            // Condição para verificar se o número está dentro do intervalo de 1 a 10
        } while (num < 1 || num > 10);

        // Tela mostrando uma mensagem, contendo o numero que o usuario digitou
        Console.WriteLine("Voce digitou o numero " + num + ".");


    }
}