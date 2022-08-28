using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dotnetinit.models
{
    public class Pessoa
    {
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, eu tenho {Age} anos.");
        }
    }
}