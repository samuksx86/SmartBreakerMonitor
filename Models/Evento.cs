using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBreaker.Models
{
    public class Evento
    {
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string Circuito { get; set; } = string.Empty;
        public string Mensagem { get; set; } = string.Empty;
    }

    public class Falha : Evento
    {
        public string Tipo { get; set; } = string.Empty;
    }

    public class Alerta : Evento
    {
        public string Nivel { get; set; } = string.Empty;
    }
}
