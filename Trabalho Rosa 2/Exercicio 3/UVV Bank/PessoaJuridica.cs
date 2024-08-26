using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.UVV_Bank
{
    internal class PessoaJuridica : Pessoa
    {
        public string razaoSocial, nomeRepresentante;
        public long cnpj;

        public PessoaJuridica(string nome, string endereco, string telefone, string razaoSocial,string nomeRepresentante, long cnpj)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.nomeRepresentante = nomeRepresentante;
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
        }

        public override void exibirDados()
        {
            Console.WriteLine($"Nome: {nome}, endereco: {endereco}, telefone {telefone}, razaoSocial: {razaoSocial},  cnpj: {cnpj}, nomeRepresentante: {nomeRepresentante}");
        }


    }
}
