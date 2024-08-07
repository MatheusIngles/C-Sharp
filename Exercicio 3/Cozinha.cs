using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    internal class Cozinha
    {
        PopulacaBaratas PopulacaBaratas = new PopulacaBaratas();
        Random Random = new Random();
        string prato;

        public Cozinha() { }

        public void fazerPrato()
        {

            int estrelas, sorte = Random.Next(1, 10);
            string resposta;

            Console.WriteLine("\n Qual o prato que vc pensa em fazer?");
            prato = Console.ReadLine();
            estrelas = verificarQualidade(prato);

            if(sorte % 2 == 0)
            {
                PopulacaBaratas.aumentarBaratas();
                Console.WriteLine($"\n Que Merda Chef! parece que a populacao de baratas aumentou devido ao prato. Elas estão com {PopulacaBaratas.populacao} agora.");
            }

            Console.WriteLine("\n Deseja Perguntar aos criticos a nota do seu prato?");
            resposta = Console.ReadLine();

            if (estrelas > 2 && resposta == "Sim")
            {
                Console.WriteLine("\n Seu Prato será Avaliado!");
                avaliacao(estrelas);
            }
            else if (resposta == "Não")
            {
                Console.WriteLine("\n OK! Deixa para a Proxima então.");
            }
            else if (estrelas < 2)
            {
                Console.WriteLine("\n Melhor Nem avaliar isso ai");
            }
        }

        public int verificarQualidade(string prato)
        {

            int qualidade = prato.Length - (PopulacaBaratas.populacao * (12 / 100));

            if (qualidade < 0)
            {
                qualidade = 0;
            }
            else if (qualidade > 5)
            {
                qualidade = 5;
            }
            return qualidade;
        }

        public void avaliacao(int estrelas)
        {

            switch (estrelas)
            {
                case 3:
                    Console.WriteLine($"\nA nota do prato é {estrelas}. Este prato apresenta uma combinação interessante de sabores que consegue agradar ao paladar. A textura é agradável e os ingredientes são frescos, proporcionando uma boa experiência culinária. No entanto, falta um pouco de ousadia na apresentação e na complexidade dos sabores. Com um pouco mais de refinamento e criatividade, este prato pode evoluir para algo verdadeiramente memorável. Uma opção sólida e satisfatória, que vale a pena experimentar.");
                    break;
                case 4:
                    Console.WriteLine($"\nA nota do prato é {estrelas}. Uma experiência gastronômica quase impecável! Este prato se destaca pela harmonia de sabores e pela cuidadosa seleção de ingredientes. A execução é tecnicamente precisa, com cada componente preparado com atenção aos detalhes. A apresentação é elegante, mostrando um senso de estética que complementa o sabor. Apenas alguns pequenos ajustes são necessários para alcançar a perfeição, mas, no geral, é uma refeição deliciosa e bem concebida que deixará uma impressão duradoura.");
                    break;
                case 5:
                    Console.WriteLine($"\nA nota do prato é {estrelas}. Perfeição culinária em cada mordida! Este prato é uma obra-prima que exemplifica o auge da gastronomia. Os sabores são incrivelmente bem equilibrados e complexos, cada ingrediente brilha em harmonia. A apresentação é deslumbrante, transformando a refeição em uma verdadeira experiência visual e sensorial. A técnica empregada é impecável, demonstrando um domínio absoluto da arte culinária. Um prato que transcende expectativas e deixa uma marca indelével no paladar. Simplesmente extraordinário!");
                    break;
            }
        }

        public void usarSpray()
        {
            PopulacaBaratas.spray();
        }
    }
}
