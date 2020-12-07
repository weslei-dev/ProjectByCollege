using System.Collections.Generic;

namespace Servidores.Model
{
    public class Servidor
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public ETipoServidor TipoServidor { get; set; }
        public Queue<Cliente> Clientes { get; set; }
        public int Index { get; set; }

        public Servidor()
        {
            Clientes = new Queue<Cliente>();
        }
    }
}
