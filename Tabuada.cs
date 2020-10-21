using System;

namespace Exerciocio_.net
{
    class Program
    {
        static void Main(string[] args)
        {
        int num;
        Console.Write("Digite um valor inteiro :");
        
        num = Convert.ToInt16(Console.ReadLine());
        //enquanto o valor de ir for menor que 10 fazemos o numero digitado VEZES o valor de i "já iniciado com 1"
       // ou seja entramos com o valor 10. na primeira volta do FOR fica 10 * 1 = 10 ...
        for (int i = 1; i <= 10; i++)
        {
        //escrevemos os valores na tela.
            Console.WriteLine(num + " x " + i + " = " + num * i);
 
        }
        //espera uma tecla ser pressionada
        Console.ReadKey();
    }
}
}