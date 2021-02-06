using System;

namespace cs_1._15_ValidaErrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double num, raiz;

            //{entrada de dados}
            Console.Write("Digite um número positivo: ");
            num = double.Parse(Console.ReadLine());
            
            // Validação dos dados (FORMA ERRADA)
            if (num < 0) //ISTO NÃO ADIANTA. O FLUXO DO PROGRAMA CONTINUARÁ!! 
            {
                Console.Write("Valor Inválido");
            }
            
            Console.WriteLine(); // Pular linha
            Console.WriteLine(); // Pular linha

            //{Processamento: Tenta extrair a raiz quadrada do número lido}
            raiz = Math.Sqrt(num); //AQUI SERÁ GERADO UM ERRO SE "Num" FOR NEGATIVO !!!

            Console.WriteLine($"Raiz quadrada de {num}: {raiz}");
        }
    }
}
