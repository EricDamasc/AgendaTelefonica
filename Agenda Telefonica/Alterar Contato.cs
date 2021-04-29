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
    public partial class Alterar_Contato : Form
    {
        public clsContatoBll clsContatoBll = new clsContatoBll();
        public clsContatoDto Contato = new clsContatoDto();

        public Alterar_Contato()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO DO CAMPO NOME
            if (txt_Nome.Text == "")
            {
                MessageBox.Show("O Nome é obrigatório");
                txt_Nome.Focus();
            }
            // VALIDAÇÃO DO CAMPO EMAIL
            if (txt_Email.Text == "")
            {
                MessageBox.Show("O campo E-MAIL é obrigatório");
                txt_Email.Focus();
            }
            // VALIDAÇÃO DO CAMPO CEP
            else if (txt_CEP.Text == "")
            {
                MessageBox.Show("O campo CEP é obrigatório");
                txt_CEP.Focus();
            }
            // VALIDAÇÃO DO CAMPO COMBUSTIVEL
            if (txt_Estados.Text == "")
            {
                MessageBox.Show("O campo Estados é obrigatório");
                txt_Estados.Focus();
            }
            // VALIDAÇÃO DO CAMPO TIPO DE CIDADES
            else if (txt_Cidades.Text == "")
            {
                MessageBox.Show("O campo Cidade são obrigatórios");
                txt_Cidades.Focus();
            }
            // VALIDAÇÃO DO CAMPO TIPO DE CELULAR
            else if (txt_Celular.Text == "")
            {
                MessageBox.Show("O campo Celular são obrigatórios");
                txt_Celular.Focus();
            }

            else if (MessageBox.Show("Confirma a Alteração?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Contato.IdCodigo = Convert.ToInt32(txt_COD.Text.ToString());
                Contato.Nome = (txt_Nome.Text);
                Contato.Email = (txt_Email.Text);
                Contato.CEP = (txt_CEP.Text);
                Contato.Estados = txt_Estados.Text;
                Contato.Cidades = txt_Cidades.Text;
                //Contato.Telefone = txt_Telefone.Text;
                Contato.Celular = txt_Celular.Text;
                //Contato.Anotacao = txt_Anotacoes.Text;

                clsContatoBll.Alterar(Contato);

                MessageBox.Show("Contato Alterado com sucesso!", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

         protected void CarregarGrid()
        {
            CarregarGrid(0, "");
            FormatarGrid();
        }

        private void CarregarGrid(int tipo, String filtro)

        {
            Grid_Alterar.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    Grid_Alterar.DataSource = clsContatoBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        Grid_Alterar.DataSource = clsContatoBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            Grid_Alterar.DataSource = clsContatoBll.ObterDados(2, filtro);
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
            Grid_Alterar.ReadOnly = true;
            Grid_Alterar.ScrollBars = ScrollBars.Vertical;


            Grid_Alterar.Columns[0].HeaderText = "CÓDIGO";
            Grid_Alterar.Columns[1].HeaderText = "NOME";
            Grid_Alterar.Columns[2].HeaderText = "E-MAIL";
            Grid_Alterar.Columns[3].HeaderText = "CEP";
            Grid_Alterar.Columns[4].HeaderText = "ESTADOS";
            Grid_Alterar.Columns[5].HeaderText = "CIDADE";
            Grid_Alterar.Columns[6].HeaderText = "CELULAR";
            Grid_Alterar.Columns[7].HeaderText = "TELEFONE";
            Grid_Alterar.Columns[8].HeaderText = "ANOTAÇÕES";

            Grid_Alterar.Columns[0].Width = 60;
            Grid_Alterar.Columns[1].Width = 140;
            Grid_Alterar.Columns[2].Width = 200;
            Grid_Alterar.Columns[3].Width = 70;
            Grid_Alterar.Columns[4].Width = 120;
            Grid_Alterar.Columns[5].Width = 90;
            Grid_Alterar.Columns[6].Width = 100;
            Grid_Alterar.Columns[7].Width = 100;
            Grid_Alterar.Columns[8].Width = 210;

        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = Grid_Alterar.CurrentRow.Index;

            txt_COD.Text = Grid_Alterar[0, linhaSelecionada].Value.ToString();
            txt_Nome.Text = Grid_Alterar[1, linhaSelecionada].Value.ToString();
            txt_Email.Text = Grid_Alterar[2, linhaSelecionada].Value.ToString();
            txt_CEP.Text = Grid_Alterar[3, linhaSelecionada].Value.ToString();
            txt_Estados.Text = Grid_Alterar[4, linhaSelecionada].Value.ToString();
            txt_Cidades.Text = Grid_Alterar[5, linhaSelecionada].Value.ToString();
            txt_Celular.Text = Grid_Alterar[6, linhaSelecionada].Value.ToString();
        }

        private void Grid_Alterar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormatarGrid();
            AtualizarGrid();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
