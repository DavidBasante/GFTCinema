using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFTCinema.Entities
{
    internal class Filme
    {
        public Filme(string titulo, string Genero, int DuracaoEmMinutos, string horarioSessao)
        {
            this.titulo = titulo;
            this.Genero = Genero;
            this.DuracaoEmMinutos = DuracaoEmMinutos;
            this.horarioSessao = horarioSessao;
        }
        public Filme()
        {

        }


        public string titulo;

        public string Genero;

        public int DuracaoEmMinutos;

        public string horarioSessao;
    }
}
