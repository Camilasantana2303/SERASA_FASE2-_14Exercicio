using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERASA_Fase2__14Exercicio
{
    internal class Cliente
    {
        string nome;
        string email;
         string senha;
        public ContaBancaria contaBancaria;


        public Cliente(string nome, string email, string senha,double saldo,bool cartaoCredito,bool cartaoDebito)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.contaBancaria= new ContaBancaria (saldo,cartaoCredito,cartaoDebito);
        }

        public void mostra()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Senha: {senha}");
           
        }

        
    }
}
