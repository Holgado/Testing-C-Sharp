using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array[7] 
            // 50    em notas 2 
            // 125   em notas 5
            // 80    em notas 10
            // 20    em notas 20
            // 50    em notas 50
            // 100   em notas 100
            // 200   em notas 200

            Caixa caixa1 = new Caixa();
            int opcao = 0;
            while (opcao != 4) {
                Console.WriteLine("CAIXA REGISTRADORA");
                Console.WriteLine(" 1) Receber pagamento");
                Console.WriteLine(" 2) Consultar valor no caixa");
                Console.WriteLine(" 3) Mostrar qauntidade de cédulas");
                Console.WriteLine(" 4) Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------\n");
                if (opcao == 1)
                {
                    Console.Write("Digite o valor recebido: ");
                    caixa1.CedulasNoCaixa = Convert.ToInt32(Console.ReadLine());
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Valor total no caixa R$" + caixa1.getValTot());
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Quantidade de cada tipo de cédula: ");
                    caixa1.contaNotas();
                }
            }
            Console.WriteLine("Finalizando ...");
            Console.ReadLine();
        }
    }
}
