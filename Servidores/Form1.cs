using Servidores.Auxiliares;
using Servidores.Model;
using System;
using System.Windows.Forms;

namespace Servidores
{
    public partial class BrServidor : Form
    {
        private readonly GerenciadorFila _gerenciarFila;
        private int _quantidade = 0;

        public BrServidor()
        {
            InitializeComponent();

            _gerenciarFila = new GerenciadorFila(listServidores, listClientes, listAtendentes);

            Configurar();
        }

        private void Configurar()
        {
            foreach (var item in Enum.GetValues(typeof(ETipoServidor)))
                cbTipoServidor.Items.Add(item);

            cbTipoServidor.SelectedIndex = 0;
        }

        private void btnAdicionarServidor_Click(object sender, EventArgs e)
        {
            var servidor = new Servidor();
            servidor.Nome = $"Servidor {++_quantidade}";
            servidor.Id = Guid.NewGuid().ToString();

            var listViewItem = new ListViewItem();
            listViewItem.Text = servidor.Nome;
            listViewItem.SubItems.Add("0");                        

            listServidores.Items.Add(listViewItem);

            servidor.Index = listViewItem.Index;
            _gerenciarFila.AdicionarServidor(servidor);
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            var atendente = new Atendente();
            atendente.Nome = Nomes.Nome;

            if (!TimeSpan.TryParse(tbTempoAtendimento.Text, out TimeSpan tempoAtendimento))
            {
                MessageBox.Show("Informe o tempo de atendimento do atendente");

                return;
            }

            atendente.TempoAtendimento = tempoAtendimento;

            _gerenciarFila.AdicionarAtendente(atendente);

            atendente.IniciarAtendimento();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
