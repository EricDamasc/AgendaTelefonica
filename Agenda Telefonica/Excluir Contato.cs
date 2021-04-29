using Bll;
using Dto;
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
    public partial class Excluir_Contato : Form
    {
        public clsContatoBll clscontatoBll = new clsContatoBll();
        public clsContatoDto Contato = new clsContatoDto();

        public Excluir_Contato()
        {
            InitializeComponent();
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
            FormatarGrid();
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            Grid_Excluir.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    Grid_Excluir.DataSource = clscontatoBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        Grid_Excluir.DataSource = clscontatoBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            Grid_Excluir.DataSource = clscontatoBll.ObterDados(2, filtro);
                        }
                    }
                    FormatarGrid();
                }
            }

            catch
            {
                throw;
            }
        }

        private void FormatarGrid()
        {
            Grid_Excluir.ReadOnly = true;
            Grid_Excluir.ScrollBars = ScrollBars.Vertical;


            Grid_Excluir.Columns[0].HeaderText = "CÓDIGO";
            Grid_Excluir.Columns[1].HeaderText = "NOME";
            Grid_Excluir.Columns[2].HeaderText = "E-MAIL";
            Grid_Excluir.Columns[3].HeaderText = "CEP";
            Grid_Excluir.Columns[4].HeaderText = "ESTADOS";
            Grid_Excluir.Columns[5].HeaderText = "CIDADE";
            Grid_Excluir.Columns[6].HeaderText = "CELULAR";
            Grid_Excluir.Columns[7].HeaderText = "TELEFONE";
            Grid_Excluir.Columns[8].HeaderText = "ANOTAÇÕES";

            Grid_Excluir.Columns[0].Width = 60;
            Grid_Excluir.Columns[1].Width = 140;
            Grid_Excluir.Columns[2].Width = 200;
            Grid_Excluir.Columns[3].Width = 70;
            Grid_Excluir.Columns[4].Width = 120;
            Grid_Excluir.Columns[5].Width = 90;
            Grid_Excluir.Columns[6].Width = 100;
            Grid_Excluir.Columns[7].Width = 100;
            Grid_Excluir.Columns[8].Width = 210;

        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = Grid_Excluir.CurrentRow.Index;

            txt_COD.Text = Grid_Excluir[0, linhaSelecionada].Value.ToString();
            txt_Nome.Text = Grid_Excluir[1, linhaSelecionada].Value.ToString();
            txt_Celular.Text = Grid_Excluir[6, linhaSelecionada].Value.ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txt_COD.Text == "")
            {
                MessageBox.Show("O COD é obrigatória");
                LimparCampos();
            }
            else
            {
                clscontatoBll.Excluir(Convert.ToInt32(txt_COD.Text));

                MessageBox.Show(
               "Contato Excluido com sucesso!", "Excluido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CarregarGrid();
        }


        private void LimparCampos()
        {
            txt_COD.Text = "";
        }

        private void Grid_Excluir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormatarGrid();
            AtualizarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
