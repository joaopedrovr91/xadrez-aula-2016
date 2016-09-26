using System;
using Tabuleiro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(1, 2);

            Console.WriteLine("Posição = " + p);

            Console.ReadLine();
        }
    }
}
