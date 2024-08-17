using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7.Google_Tradutor
{
    internal class Palavra
    {
        public string nome;
        List<Significado> significados = [];

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int i { get; set; }

        public string getNome() { return this.nome; }

        public void adicionarSignificado(Significado significado)
        {
            significados.Add(significado);
        }

        public void printarSignificados(List<Significado> significados)
        {
            foreach(var i in significados)
            {
                Console.WriteLine(i.texto);
            }
        }

        public List<Significado> reculperarSignificados() { 
            return significados; }

        public void removerSignificado(Significado significado) {
            bool ret = false;
            for (int i = 0; i < significados.Count; i++) {
                if (significado == significados[i]) { 
                    significados.Remove(significados[i]);
                    Console.WriteLine("Removido");
                    ret = true;
                }
            }
            if (!ret){
                Console.WriteLine("Não encontrado");
            }
        }

        public bool pesquisarSignificado(Significado significado) {
            foreach (var i in significados) {
                if (i.texto == significado.texto) {
                    return true;
                }
            }
            return false;
        }
    }
}
