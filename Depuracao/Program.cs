using System;
using System.Collections.Generic;
using System.Text;

namespace Depuracao
{
    class Program
    {
        static int Mudar(int n)
        {
            n = n + 1;
            return n;
        }

        static float Dividir(int n, int d)
        {
            return n / d;
        }

        static void Main(string[] args)
        {
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O número escolhido é: {0}", numero);
            numero = Mudar(numero);
            Console.WriteLine("O número modificado é: {0}", numero);
            
            int denominador = 0;
            denominador = int.Parse(Console.ReadLine());
            if (denominador == 0)
                Console.WriteLine("Não é possivel dividir {0} por zero", denominador);
            else
                Console.WriteLine("O quociente entre {0} e {1} é {2}", numero, denominador, Dividir(numero, denominador));

            int[] vetor = new int[3];
            vetor[0]= int.Parse(Console.ReadLine());
            vetor[1]= int.Parse(Console.ReadLine());
            vetor[2]= int.Parse(Console.ReadLine());
            for (int c = 0; c < vetor.Length; c++)
                Console.Write("{0} ", vetor[c]);

            // exeção muito comun que é variave com valor null
            //string[] v = null;
            //string N2 = "Nada" + v[0]; 
            //Console.WriteLine(v[0]);

            Console.Read();
        }
    }
}
