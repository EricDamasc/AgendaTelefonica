using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Contatos_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();
            contatos.ShowDialog();
        }

        private void CAT_Anotacoes_Click(object sender, EventArgs e)
        {
            Anotacao anotacao = new Anotacao();
            MessageBox.Show("INSIRA APENAS A ANOTAÇÃO, SELECIONE O CONTATO NO GRID", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            anotacao.ShowDialog();
        }
    }
}
