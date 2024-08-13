using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3___Exercicio.Att
{
    public class AgendaTelefonica
    {
        Dictionary<string, string> colecao = new Dictionary<string, string>();

        public void inserir(string nome,string numero)
        {
            colecao.Add(nome, numero);
            Console.WriteLine($"O {numero} foi adicionado a coleção.");
        }

        public string buscar(string nome) {

            if (colecao.ContainsKey(nome))
            {
                return "Realmente Ela está na coleção";
            }
            else
            {
                return "Não está na lista";
            }

        }

        public void remover(string nome)
        {
            if (colecao.ContainsKey(nome))
            {
                colecao.Remove(nome);
                Console.WriteLine($"O nome '{nome}' foi retirado da coleção.");
            }
            else
            {
                Console.WriteLine($"O nome '{nome}' nem está na lista, para ser retirado");
            }
        }

        public int tamanho()
        {
            return colecao.Count;
        }
    }
}
