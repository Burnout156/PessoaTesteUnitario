using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste
{
    public class Pessoa
    {
        private int Idade;

        private Pessoa() { }

        public Pessoa(int _Idade)
        {
            Idade = _Idade;
        }

        public int SaberIdade
        {
            get { return Idade; }
        }

        public void VerificarIdade() //método que verifica se a idade é inválida
        {
            if (SaberIdade < 0)
            {
                throw new ArgumentOutOfRangeException("Idade");
            }

            else if (SaberIdade > 110)
            {
                throw new ArgumentOutOfRangeException("Idade");
            }

            else
            {
                Console.WriteLine("Idade Válida: " + SaberIdade);
            }
        }

        public static void Main()
        {
            Pessoa pessoa = new Pessoa(-6);
            pessoa.VerificarIdade();
        }
    }
}
