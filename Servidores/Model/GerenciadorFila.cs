using Servidores.Auxiliares;
using Servidores.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace Servidores.Model
{
    public class GerenciadorFila
    {
        private readonly List<Servidor> _servidores;        
        private List<Horario> _horarios;
        private List<Atendente> _atendentes;

        private ListView _listViewServidores;
        private ListView _listViewClientes;
        private ListView _listViewAtendentes;

        private System.Timers.Timer _timer;

        public GerenciadorFila(ListView listViewServidores, ListView listViewClientes, ListView listViewAtendentes)
        {
            _servidores = new List<Servidor>();
            _horarios = new List<Horario>();
            _atendentes = new List<Atendente>();

            _listViewServidores = listViewServidores;
            _listViewClientes = listViewClientes;
            _listViewAtendentes = listViewAtendentes;

            ConfigurarTimer();
        }

        private void ConfigurarTimer()
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = ObterIntervaloTimer();
            _timer.Elapsed += _timer_Elapsed;
            _timer.Enabled = true;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_servidores.Count == 0)
                return;

            AdicionarCliente();

            _timer.Interval = ObterIntervaloTimer();
        }

        private double ObterIntervaloTimer()
        {
            return new Random().Next((int)TimeSpan.FromSeconds(10).TotalMilliseconds, (int)TimeSpan.FromMinutes(1).TotalMilliseconds);
        }        

        public void AdicionarServidor(Servidor servidor)
        {
            _servidores.Add(servidor);
        }

        public void AdicionarCliente()
        {
            var servidor = ObterServidorComMenosClientes();

            var cliente = new Cliente();
            cliente.Id = Guid.NewGuid().ToString();
            cliente.Nome = Nomes.Nome;

            servidor.Clientes.Enqueue(cliente);

            var horario = new Horario(cliente, servidor, DateTime.Now.TimeOfDay);
            _horarios.Add(horario);

            GerenciarListViews(servidor, cliente, horario);
        }

        public void AdicionarAtendente(Atendente atendente)
        {
            _atendentes.Add(atendente);

            var listViewItens = new ListViewItem();
            listViewItens.Text = atendente.Nome;
            listViewItens.SubItems.Add(atendente.TempoAtendimento.ToString());

            _listViewClientes.Invoke((MethodInvoker)delegate { _listViewAtendentes.Items.Add(listViewItens); });

            atendente.Atender += Atendente_Atender;
        }

        private void Atendente_Atender(object sender, EventArgs e)
        {
            var servidor = ObterServidorComMaisClientes();

            if (servidor.Clientes.Count == 0)
                return;

            var cliente = servidor.Clientes.Dequeue();

            _listViewClientes.Invoke((MethodInvoker)delegate 
            {
                _listViewClientes.Items[cliente.Index].SubItems[2].Text = DateTime.Now.TimeOfDay.ToString(); 
            });

            _listViewServidores.Invoke((MethodInvoker)delegate { _listViewServidores.Items[servidor.Index].SubItems[1].Text = servidor.Clientes.Count.ToString(); });
        }

        private void GerenciarListViews(Servidor servidor, Cliente cliente, Horario horario)
        {
            _listViewServidores.Invoke((MethodInvoker)delegate { _listViewServidores.Items[servidor.Index].SubItems[1].Text = servidor.Clientes.Count.ToString(); });

            var listViewItens = new ListViewItem();
            listViewItens.Text = cliente.Nome;
            listViewItens.SubItems.Add(horario.Entrada.ToString());
            listViewItens.SubItems.Add("Em Andamento");
            listViewItens.SubItems.Add(servidor.Nome);

            _listViewClientes.Invoke((MethodInvoker)delegate 
            { 
                _listViewClientes.Items.Add(listViewItens); 
                cliente.Index = listViewItens.Index; 
            });
        }

        private Servidor ObterServidorComMenosClientes()
        {
            Servidor servidorMenor = _servidores.FirstOrDefault();
            var quantidade = servidorMenor.Clientes.Count;

            foreach (var servidor in _servidores)
            {
                if (servidor.Clientes.Count < quantidade)
                    servidorMenor = servidor;

                quantidade = servidor.Clientes.Count;
            }

            return servidorMenor;
        }

        private Servidor ObterServidorComMaisClientes()
        {
            Servidor servidorMaior = _servidores.FirstOrDefault();
            var quantidade = servidorMaior.Clientes.Count;

            foreach (var servidor in _servidores)
            {
                if (servidor.Clientes.Count > quantidade)
                    servidorMaior = servidor;

                quantidade = servidor.Clientes.Count;
            }

            return servidorMaior;
        }
    }
}
