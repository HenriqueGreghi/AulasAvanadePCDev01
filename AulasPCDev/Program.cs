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

            Console.WriteLine("Qual sua idade?");
            int idadePessoa = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura?");
            double altura = double.Parse(Console.ReadLine());
            bool maiorIdade = idadePessoa >= 18;
            bool alturaPermitida = altura >= 1.8;


            if (maiorIdade && alturaPermitida) 
                {
                    Console.WriteLine("Pode entrar");
                    Console.WriteLine("Seja bem vindo");
                }
                else
                {
                    {
                    Console.WriteLine("Não pode entrar");
                    }
                }
            

        }
    }
}
