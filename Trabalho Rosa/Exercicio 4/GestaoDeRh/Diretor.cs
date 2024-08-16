using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GestaoDeRh
{
    internal class Diretor
    {

        List<Funcionario> funcionarios = [];

        public void cadastrar(Funcionario func) { 
            funcionarios.Add(func);
            func.cadastrar();
        }
        public void consultar(string Nome) {
            foreach (Funcionario funcionario in funcionarios) { 
                funcionario.consultar(Nome);
            }
        }
        public void atualizarSalario(string nome,double Salario)
        {
            foreach (var funcionario in funcionarios)
            {
                if(funcionario.nome == nome)
                {
                    funcionario.atualizarSalario(Salario);
                }
            }
        }
        public void listarDependentes() { 
            foreach (Funcionario func in funcionarios) { 
                Console.WriteLine(func.nome);
            }
        }


    }
}
