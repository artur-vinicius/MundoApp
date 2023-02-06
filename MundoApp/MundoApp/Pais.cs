using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoApp
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Populacao { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} - País: {Nome} - População: {Populacao}";
        }
    }
}
