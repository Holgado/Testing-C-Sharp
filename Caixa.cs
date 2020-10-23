using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Caixa
    {
        private static int valorTot;
        private static int[] cedulasNoCaixa = new int[7];

        public int getValTot()
        {
            return valorTot;
        }
        private void setValTot(int val)
        {
            valorTot += val;
        }
        public int[] getCedulasDisp()
        {
            return cedulasNoCaixa;
        }
        public int CedulasNoCaixa
        {
            set
            {                
                if (value == 2)
                {
                    cedulasNoCaixa[0] = value;
                    setValTot(value);
                }
                else if (value == 5)
                {
                    cedulasNoCaixa[1] = value;
                    setValTot(value);
                }
                else if (value == 10)
                {
                    cedulasNoCaixa[2] = value;
                    setValTot(value);
                }
                else if (value == 20)
                {
                    cedulasNoCaixa[3] = value;
                    setValTot(value);
                }
                else if (value == 50)
                {
                    cedulasNoCaixa[4] = value;
                    setValTot(value);
                }
                else if (value == 100)
                {
                    cedulasNoCaixa[5] = value;
                    setValTot(value);
                }
                else if (value == 200)
                {
                    cedulasNoCaixa[6] = value;
                    setValTot(value);
                }
            }
        }
        public void contaNotas()
        {
            Console.WriteLine("Notas de R$2 = " + cedulasNoCaixa[0] / 2);
            Console.WriteLine("Notas de R$5 = " + cedulasNoCaixa[1] / 5);
            Console.WriteLine("Notas de R$10 = " + cedulasNoCaixa[2] / 10);
            Console.WriteLine("Notas de R$20 = " + cedulasNoCaixa[3] / 20);
            Console.WriteLine("Notas de R$50 = " + cedulasNoCaixa[4] / 50);
            Console.WriteLine("Notas de R$100 = " + cedulasNoCaixa[5] / 100);
            Console.WriteLine("Notas de R$200 = " + cedulasNoCaixa[6] / 200);
        }
    }
}
