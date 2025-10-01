using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PouPixFront.Components.Classes
{
    public class NovaCompra
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "Sem Nome";
        public int IdCategoria { get; set; }
        public decimal Valor { get; set; }
        public string Comentario { get; set; } = string.Empty;
        public DateTime Data { get; set; }
    }
}