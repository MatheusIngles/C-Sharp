using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_3___Exercicio.Att;

namespace Aula_3___Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string resposta, nome, numero;
            AgendaTelefonica agendaTelefonica = new AgendaTelefonica();

            while (true)
            {
                Console.WriteLine("O que quer fazer?\n1-Inserir\n2-Procurar Numero\n3-Remover Numero\n4-Tamanho da colecão.\n5-Sair");
                resposta = Console.ReadLine();

                if(Int32.Parse(resposta) == 1)
                {
                    Console.WriteLine("\n Qual o nome?");
                    nome = Console.ReadLine();
                    Console.WriteLine("\n Qual o numero?");
                    numero = Console.ReadLine();
                    agendaTelefonica.inserir(nome, numero);
                    Console.WriteLine("\n O numero foi adicionado a coleção");
                } else if (Int32.Parse(resposta) == 2)
                {
                    Console.WriteLine("\n Qual o nome?");
                    nome = Console.ReadLine();
                    Console.WriteLine("\n" + agendaTelefonica.buscar(nome));
                } else if (Int32.Parse(resposta) == 3)
                {
                    Console.WriteLine("\n Qual o nome?");
                    nome = Console.ReadLine();
                    agendaTelefonica.remover(nome);
                } else if (Int32.Parse(resposta) == 4)
                {
                    Console.WriteLine("\n" + agendaTelefonica.tamanho());
                } else if (Int32.Parse(resposta) == 5)
                {
                    break;
                }
            }


        }
    }
}
