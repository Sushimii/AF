using System;
//Puxando todas as bibliotecas básicas 
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        // Declaração da variável do tipo int
        int num;

        // Tela mostrando uma mensagem para o usuário dar um valor à variável "num"
        Console.Write("Digite um número inteiro positivo: ".ToString(CultureInfo.InvariantCulture));
        // Valor sendo atribuído à variável "num"
        num = int.Parse(Console.ReadLine());

        // Tela mostrando o resultado para o usuário
        Console.Write($"Os primeiros {num} números pares são: ".ToString(CultureInfo.InvariantCulture));

        // Condição para a variável 'i' = 2, 'i' menor ou igual ao valor da variável 'num' * 2, ele irá acrescentar 2 à variável "i"
        for (int i = 2; i <= num * 2; i += 2)
        {
            // Tela mostrando os valores da variável 'i' depois dos acréscimos 
            Console.Write(i + " ".ToString(CultureInfo.InvariantCulture));
        }


    }
}