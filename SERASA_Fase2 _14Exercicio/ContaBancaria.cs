using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERASA_Fase2__14Exercicio
{
    internal class ContaBancaria
    {
        double saldo;
        bool cartaoCredito;
        bool cartaodebito;


        public ContaBancaria(double saldo, bool cartaoCredito, bool cartaoDebito)
        {
            this.saldo = saldo;
            this.cartaoCredito = cartaoCredito;
            this.cartaodebito = cartaoDebito;
        }


        public void mostra()
        {
            Console.WriteLine($"Saldo: {saldo} ");
            Console.WriteLine($"Cartão de credito: {cartaoCredito}");
            Console.WriteLine($"Cartão debito: {cartaodebito}");
            

        }

    }
}
