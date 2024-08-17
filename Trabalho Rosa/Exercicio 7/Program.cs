using Exercicio_7.Google_Tradutor;
using System.Collections.Generic;
namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0, i = 0;
            string palavra, texto;
            Dictionary<int, Palavra> Dicionario = [];

            while (true)
            {
                Console.WriteLine("O que vc quer fazer?" +
                    "\n 0-Adicionar uma palavra e significado ao dicionario" +
                    "\n 1-Recuperar uma palavra" +
                    "\n 2-Remover do dicionario" +
                    "\n 3-Pesquisar se o significado está contido na palavra" +
                    "\n 4-Sair");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 0)
                {
                    Palavra palavr = new Palavra();
                    Console.WriteLine("Qual A palavra?");
                    palavra = Console.ReadLine();
                    palavr.setNome(palavra);
                    palavr.i = i;
                    Console.WriteLine("Qual o Texto do seu significado?");
                    texto = Console.ReadLine();
                    Significado s = new Significado();
                    s.texto = texto;
                    s.palavra = palavr;
                    palavr.adicionarSignificado(s);
                    Dicionario.Add(i, palavr);
                    i++;
                    Console.WriteLine("Palavra Adicionada");
                    while (true)
                    {
                    Console.WriteLine("Deseja Adicionar mais significado?\n" +
                        "1- Sim\n" +
                        "2- Nao");
                    resposta = int.Parse(Console.ReadLine());
                        if(resposta == 1)
                        {
                            Console.WriteLine("Qual o Texto do seu significado?");
                            texto = Console.ReadLine();
                            s = new Significado();
                            s.texto = texto;
                            s.palavra = palavr;
                            Dicionario[i-1].adicionarSignificado(s);
                        } else if(resposta == 2)
                        {
                            break;
                        }else
                        {
                           Console.WriteLine("Escreve Certo!!");
                        }
                    }
                }
                else if (resposta == 1)
                {
                    Console.WriteLine("Qual A palavra?");
                    palavra = Console.ReadLine();

                    foreach (var a in Dicionario)
                    {
                        if (palavra == a.Value.getNome())
                        {
                            Console.WriteLine("Palavra encontrada:\n" +
                                $"Palavra: {a.Value.getNome()}\n" +
                                $"Significados: ");
                            a.Value.printarSignificados(a.Value.reculperarSignificados());
                        }
                    }
                }
                else if (resposta == 2)
                {
                    Console.WriteLine("Qual A palavra?");
                    palavra = Console.ReadLine();

                    for (int x = 0; x < Dicionario.Count; x++)
                    {
                        if (palavra == Dicionario[x].getNome())
                        {
                            Dicionario.Remove(Dicionario[x].i);
                            Console.WriteLine("Retirado");
                        }
                    }
                }
                else if (resposta == 3)
                {
                    Console.WriteLine("Qual a palavra do seu significado?");
                    palavra = Console.ReadLine();

                    foreach (var x in Dicionario)
                    {
                        if (palavra == x.Value.getNome())
                        {
                            Console.WriteLine("Qual o significado que vc esta procurando?");
                            texto = Console.ReadLine();
                            Significado s = new Significado();
                            s.texto = texto;
                            s.palavra = x.Value;
                            if (x.Value.pesquisarSignificado(s))
                            {
                                Console.WriteLine($"Encontrado: o significado {s.texto} está na palavra.");
                            }
                        }
                    }
                }
                else if (resposta == 4)
                {
                    break;
                }
            }
        }
    }
}
