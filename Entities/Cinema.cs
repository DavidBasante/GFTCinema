using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFTCinema.Entities
{
    internal class Cinema
    {
        public Cinema(string Nome, string Endereco, List<Filme> filmeEmCartaz)
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.filmeEmCartaz = filmeEmCartaz;
        }

        public Cinema()
        {
        }

        public string Nome;

        public string Endereco;

        public List<Filme> filmeEmCartaz;

    }
}
