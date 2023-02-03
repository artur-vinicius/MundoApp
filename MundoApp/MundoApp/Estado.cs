using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoApp
{
    class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Populacao { get; set; }


        public override string ToString()
        {
            return $"{Id} - {Nome} - {Populacao}";
        }
    }
}
