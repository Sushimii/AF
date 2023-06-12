using System;
//Puxando todas bibliotecas basicas
using System.Globalization;
class Program


{
    //Criando metodo Soma
    public static double Soma(double a, double b)
    {
        //Formula do metodo soma
        double soma = a + b;
        //Parar a execução do metodo e retornar o valor a variavel "soma"
        return soma;
    }
    //Criando metodo Sub
    public static double Sub(double a, double b)
    {
        //Formula do metodo Sub
        double sub = a;
        //Parar a execução do metodo e retornar o valor a variavel "sub"
        return sub;
    }
    //Criando metodo Mult
    public static double Mult(double a, double b)
    {
    //Formula do metodo mult
     double mult = a * b;
        //Parar a execução do metodo e retornar o valor a variavel "mult"
        return mult;
    }

    //Criando metodo Div
    public static double Div (double a, double b)
    {
        //Formula do metodo Div
        double div = a / b;
        //Parar a execução do metodo e retornar o valor a variavel "div"
        return div;
    }

    public static void Main(string[] args)
    {
        //Declarando as variaveis e o valor das variaveis

        double soma = Soma(5, 5);
        double mult = Mult(5, 5);
        double sub= Sub(5, 5);  
        double div = Div(5, 5);

        //Mostrando os resultados de cada metodo usando os valores declarados
        Console.WriteLine($"A soma é : {soma}".ToString(CultureInfo.InvariantCulture));
        Console.WriteLine($"A subtração é : {sub}".ToString(CultureInfo.InvariantCulture));
        Console.WriteLine($"A multiplicação é : {mult}".ToString(CultureInfo.InvariantCulture));
        Console.WriteLine($"A divisão é : {div}".ToString(CultureInfo.InvariantCulture));


    }
}