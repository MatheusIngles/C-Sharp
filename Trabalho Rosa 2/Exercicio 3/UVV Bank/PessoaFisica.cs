using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3.UVV_Bank
{
    internal class PessoaFisica : Pessoa
    {
        public string cpf;
        public int estadocivil;

        public PessoaFisica(string nome, string endereco, string telefone, string cpf, int estadocivil) { 
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.cpf = cpf;
            this.estadocivil = estadocivil;
        }

        public override void exibirDados()
        {
            Console.WriteLine($"Nome: {nome}, endereco: {endereco}, telefone {telefone}, cpf: {cpf},  estado civil: {estadocivil}");
        }
    }
}
