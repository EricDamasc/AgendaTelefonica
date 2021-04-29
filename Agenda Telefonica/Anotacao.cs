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
    public partial class Anotacao : Form
    {
        public clsAnotacaoBll clsAnotacoesBll = new clsAnotacaoBll();
        public clsAnotacoesDto Anotacoes = new clsAnotacoesDto();

        public Anotacao()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void BTN_SalvarAnotacao_Click(object sender, EventArgs e)
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
                MessageBox.Show("O campo KM é obrigatório");
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
            // VALIDAÇÃO DO CAMPO TIPO DE TELEFONE
            else if (txt_Telefone.Text == "")
            {
                MessageBox.Show("O campo Telefone são obrigatórios");
                txt_Telefone.Focus();
            }
            // VALIDAÇÃO DO CAMPO TIPO DE CELULAR
            else if (txt_Celular.Text == "")
            {
                MessageBox.Show("O campo Celular são obrigatórios");
                txt_Celular.Focus();
            }
            // VALIDAÇÃO DO CAMPO TIPO DE ANOTAÇÕES
            else if (txt_Anotacoes.Text == "")
            {
                MessageBox.Show("O campo ANOTAÇÕES são obrigatórios");
                txt_Anotacoes.Focus();
            }

            else if (MessageBox.Show("Confirma a Anotação?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Anotacoes.IdCodigo = Convert.ToInt32(txt_COD.Text.ToString());
                Anotacoes.Nome = (txt_Nome.Text);
                Anotacoes.Email = (txt_Email.Text);
                Anotacoes.CEP = (txt_CEP.Text);
                Anotacoes.Estados = txt_Estados.Text;
                Anotacoes.Cidades = txt_Cidades.Text;
                Anotacoes.Telefone = txt_Telefone.Text;
                Anotacoes.Celular = txt_Celular.Text;
                Anotacoes.Anotacao = txt_Anotacoes.Text;

                clsAnotacoesBll.Alterar(Anotacoes);

                MessageBox.Show("Anotação inserida com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS CORRETAMENTE!");
            }
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
            FormatarGrid();
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            Grid_Anotacao.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    Grid_Anotacao.DataSource = clsAnotacoesBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        Grid_Anotacao.DataSource = clsAnotacoesBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            Grid_Anotacao.DataSource = clsAnotacoesBll.ObterDados(2, filtro);
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
            Grid_Anotacao.ReadOnly = true;
            Grid_Anotacao.ScrollBars = ScrollBars.Vertical;


            Grid_Anotacao.Columns[0].HeaderText = "CÓDIGO";
            Grid_Anotacao.Columns[1].HeaderText = "NOME";
            Grid_Anotacao.Columns[2].HeaderText = "E-MAIL";
            Grid_Anotacao.Columns[3].HeaderText = "CEP";
            Grid_Anotacao.Columns[4].HeaderText = "ESTADOS";
            Grid_Anotacao.Columns[5].HeaderText = "CIDADE";
            Grid_Anotacao.Columns[6].HeaderText = "CELULAR";
            Grid_Anotacao.Columns[7].HeaderText = "TELEFONE";
            //Grid_Anotacao.Columns[8].HeaderText = "ANOTAÇÕES";

            Grid_Anotacao.Columns[0].Width = 60;
            Grid_Anotacao.Columns[1].Width = 140;
            Grid_Anotacao.Columns[2].Width = 200;
            Grid_Anotacao.Columns[3].Width = 70;
            Grid_Anotacao.Columns[4].Width = 120;
            Grid_Anotacao.Columns[5].Width = 90;
            Grid_Anotacao.Columns[6].Width = 100;
            Grid_Anotacao.Columns[7].Width = 100;
            //Grid_Anotacao.Columns[8].Width = 210;

        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = Grid_Anotacao.CurrentRow.Index;

            txt_COD.Text = Grid_Anotacao[0, linhaSelecionada].Value.ToString();
            txt_Nome.Text = Grid_Anotacao[1, linhaSelecionada].Value.ToString();
            txt_Email.Text = Grid_Anotacao[2, linhaSelecionada].Value.ToString();
            txt_CEP.Text = Grid_Anotacao[3, linhaSelecionada].Value.ToString();
            txt_Estados.Text = Grid_Anotacao[4, linhaSelecionada].Value.ToString();
            txt_Cidades.Text = Grid_Anotacao[5, linhaSelecionada].Value.ToString();
            txt_Celular.Text = Grid_Anotacao[6, linhaSelecionada].Value.ToString();
            txt_Telefone.Text = Grid_Anotacao[7, linhaSelecionada].Value.ToString();
            txt_Anotacoes.Text = Grid_Anotacao[8, linhaSelecionada].Value.ToString();
        }

        private void Grid_Anotacao_Click(object sender, EventArgs e)
        {
            FormatarGrid();
            AtualizarGrid();
        }

        private void BTN_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_Localizar.Text != "")
            {
                Grid_Anotacao.DataSource = clsAnotacoesBll.ObterDados(1, txt_Localizar.Text);
                FormatarGrid();
            }
            else
            {
                MessageBox.Show("NÃO FOI POSSIVEL RELIZAR A BUSCA!", "NÃO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CarregarGrid();
            }
        }
    }
}
