﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoApp
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Populacao { get; set; }
        public int IdPais { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} - Estado: {Nome} - População: {Populacao} - País: {IdPais}";
        }
    }
}
