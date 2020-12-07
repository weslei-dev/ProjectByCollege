using System;

namespace Servidores.Model
{
    public class Horario
    {
        public Horario(Cliente cliente, Servidor servidor, TimeSpan entrada)
        {
            Cliente = cliente;
            Servidor = servidor;
            Entrada = entrada;
        }

        public Horario()
        {

        }

        public Cliente Cliente { get; set; }
        public Servidor Servidor { get; set; }
        public TimeSpan Entrada { get; set; }
        public TimeSpan Saida { get; set; }

        public TimeSpan ObterTempoClienteFila()
            => Saida - Entrada;
    }
}
