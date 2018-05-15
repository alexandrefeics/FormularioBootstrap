using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioBootstrap.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public bool Html { get; set; }
        public bool Java { get; set; }
        public bool Css { get; set; }
        public string Resumo { get; set; }
        public string Idioma { get; set; }
        public string EstadoCivil { get; set; }

    }
}