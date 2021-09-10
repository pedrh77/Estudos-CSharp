using System;


namespace Estudos_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Opcoes();
        }

        public static void Opcoes()
        {
            int opc;

            Console.WriteLine("-- Bem Vindo a Home --");
            Console.WriteLine("    O que deseja?    ");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Tabuada");
            Console.WriteLine("3 - IMC");
            Console.WriteLine("4 - Sair");
            opc = int.Parse(Console.ReadLine());
            Console.Clear();
            if (opc == 1) Calc();
            if (opc == 2) Tabuada();
            if (opc == 3) IMC();
            if (opc == 4) Environment.Exit(1);
        }
        //Metodo Calculadora
        //Para fazer operaçoes simples
        static void Calc()
        {
            int N1, N2, Result, opc;

            
            Console.WriteLine("-- Bem Vindo a Calculadora --");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtraçao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Mutiplicaçao");
            opc = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite os Numeros para Prosseguirmos!!");

            Console.WriteLine("Digite o Primeiro Numero");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite O segundo Numero");
            N2 = int.Parse(Console.ReadLine());
            if (opc == 1)
            {
                Result = N1 + N2;
                Console.WriteLine("A soma dos Numeros " + N1 + " e " + N2 + " é igual a " + Result);

                Console.WriteLine("Pressione Qualquer tecla para fechar");
                Console.ReadKey();

                Console.Clear();
            }
            if (opc == 2)
            {
                Result = N1 - N2;

                Console.WriteLine("A Subtraçao dos Numeros " + N1 + " e " + N2 + " é igual a " + Result);

                Console.WriteLine("Pressione Qualquer tecla para fechar");
                Console.ReadKey();
                Console.Clear();
            }
            if (opc == 3)
            {
                Result = N1 / N2;
                Console.WriteLine("A Divisao dos Numeros " + N1 + " e " + N2 + " é igual a " + Result);

                Console.WriteLine("Pressione Qualquer tecla para fechar");
                Console.ReadKey();
                Console.Clear();
            }
            if (opc == 4)
            {
                Result = N1 * N2;
                Console.WriteLine("A Multiplicaçao dos Numeros " + N1 + " e " + N2 + " é igual a " + Result);

                Console.WriteLine("Pressione Qualquer tecla para fechar");
                Console.ReadKey();
                Console.Clear();
            }
            Sair();

        }

        //Metodo da tabuada
        static void Tabuada()
        {
            int x, y;
            Console.WriteLine("-- Bem Vindo a Tabuada --");
            Console.WriteLine("-- Qual tabuada você deseja?? --");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("-- Quantas Vezes?? --");
            y = int.Parse(Console.ReadLine());

            for (int a = 1; a <= y; a++) Console.WriteLine(x + "*" + a + "=" + (x * a));

            Console.WriteLine("Pressione Qualquer tecla para fechar");
            Console.ReadKey();

            Sair();
        }

        static void IMC()
        {
            float altura, peso, result;
            Console.WriteLine("-- Bem Vindo(a) ao IMC--");
            Console.WriteLine("-- Qual sua Altura --");
            Console.WriteLine("-- Use Virgula! (1,80) --");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("-- Qual seu Peso --");
            peso = float.Parse(Console.ReadLine());

            result = (peso / (altura * altura));

            Console.WriteLine(result);

            if (result <= 18.5) Console.WriteLine("ABAIXO DO PESO!");

            if (result >= 18.6 && result < 24.9) Console.WriteLine("PESO NORMAL!");

            if (result >= 25 && result < 29.9) Console.WriteLine("SOBREPESO!");

            if (result >= 30 && result < 34.9) Console.WriteLine("oBESIDADE I !");

            if (result >= 35 && result < 39.9) Console.WriteLine("OBESIDADE III!");

            if (result >= 40) Console.WriteLine("OBESIDADE MORBIDA!");


            Console.WriteLine("Pressione Qualquer tecla para fechar");
            Console.ReadKey();

            Console.Clear();
            Sair();
        }
        //Metodo que fecha o Programa ou Reinicia
        static void Sair()
        {
            string end;
            Console.Clear();

            Console.WriteLine("Deseja Sair? y/n");
            end = Console.ReadLine();
            if (end == "y")
            {
                Environment.Exit(1); //Fecha o Programa
            }
            if (end == "n")
            {
                Console.Clear();
                Opcoes();
            }

        }
    }
}