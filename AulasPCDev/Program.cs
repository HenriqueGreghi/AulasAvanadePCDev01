using System;

namespace AulasPCDev01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime data = DateTime.Now;
            Console.WriteLine(data);
            DateTime data2 = data.AddYears(5);
            Console.WriteLine(data2);
            Console.WriteLine(data.ToString("dd/MM/yyyy"));


            int idadePessoa = 20;
            float altura = 1.8f;
            bool maiorIdade = idadePessoa >= 18;
            bool menorIdade = idadePessoa < 18;
            bool alturaPermitida = altura >= 1.2f;


            if (maiorIdade && alturaPermitida)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

        }
    }
}
