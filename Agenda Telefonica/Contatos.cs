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
    public partial class Contatos : Form
    {
        public clsContatoBll clsContatoBll = new clsContatoBll();
        public clsContatoDto Contato = new clsContatoDto();

        public Contatos()
        {
            InitializeComponent();
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
            FormatarGrid();
        }

        private void CarregarGrid(int tipo, String nome)
        {
            GridContato.AutoGenerateColumns = true;

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
            try
            {
                if (tipo == 0)
                {
                    GridContato.DataSource = clsContatoBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GridContato.DataSource = clsContatoBll.ObterDados(1, nome);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GridContato.DataSource = clsContatoBll.ObterDados(2, nome);
                        }
                    }
                    FormatarGrid();
                }
            }

            catch
            {
                MessageBox.Show("TENTE NOVAMENTE", "ATENÇÃO", MessageBoxButtons.AbortRetryIgnore);
            }
        }

        private void FormatarGrid()
        {
            GridContato.ReadOnly = true;
            GridContato.ScrollBars = ScrollBars.Vertical;


            GridContato.Columns[0].HeaderText = "CÓDIGO";
            GridContato.Columns[1].HeaderText = "NOME";
            GridContato.Columns[2].HeaderText = "E-MAIL";
            GridContato.Columns[3].HeaderText = "CEP";
            GridContato.Columns[4].HeaderText = "ESTADOS";
            GridContato.Columns[5].HeaderText = "CIDADE";
            GridContato.Columns[6].HeaderText = "CELULAR";
            GridContato.Columns[7].HeaderText = "TELEFONE";
            GridContato.Columns[8].HeaderText = "ANOTAÇÕES";

            GridContato.Columns[0].Width = 60;
            GridContato.Columns[1].Width = 140;
            GridContato.Columns[2].Width = 200;
            GridContato.Columns[3].Width = 70;
            GridContato.Columns[4].Width = 120;
            GridContato.Columns[5].Width = 90;
            GridContato.Columns[6].Width = 100;
            GridContato.Columns[7].Width = 100;
            GridContato.Columns[8].Width = 210;

        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = GridContato.CurrentRow.Index;

            txt_COD.Text = GridContato[0, linhaSelecionada].Value.ToString();
            txt_Email.Text = GridContato[2, linhaSelecionada].Value.ToString();
            txt_Celular.Text = GridContato[6, linhaSelecionada].Value.ToString();
        }

        private void Contatos_cat_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();
            contatos.ShowDialog();
        }

        private void btn_NovoContato_Click(object sender, EventArgs e)
        {
            Novo_Contato novo_Contato = new Novo_Contato();
            novo_Contato.ShowDialog();
        }

        private void btn_ExcluirContato_Click(object sender, EventArgs e)
        {
            Excluir_Contato excluir = new Excluir_Contato();
            excluir.ShowDialog();
        }

        private void Contatos_Load(object sender, EventArgs e)
        {
            FormatarGrid();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridContato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormatarGrid();
            AtualizarGrid();
        }

        private void btn_WhatsApp_Click(object sender, EventArgs e)
        {
            if (txt_Celular.Text == "")
            {
                MessageBox.Show("INSIRA UM NÚMERO VÁLIDO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string url = "https://api.whatsapp.com/send?phone=55" + txt_Celular.Text + "&text=Desejar%20%C3%A9%20o%20primeiro%20passo%20para%20a%20conquista%20de%20nossos%20sonhos.%20Prazer%2C%20Eric!!";
                try
                {
                    Console.Beep();
                    MessageBox.Show("VOCÊ VAI SER DIRECIONADO PARA O SITE WHATSAPP!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(url);
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
            }
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                MessageBox.Show("INSIRA UM ENDEREO DE E-MAIL!","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string url = "mailto:" + txt_Email.Text + "?subject=Email%20teste%20para%20Você%20Parabéns%20!";
                try
                {
                    Console.Beep();
                    MessageBox.Show("VOCÊ VAI SER DIRECIONADO PARA O EMAIL!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(url);
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
            }            
        }

        private void btn_AlterarContato_Click(object sender, EventArgs e)
        {
            Alterar_Contato alterar_Contato = new Alterar_Contato();
            alterar_Contato.ShowDialog();
        }

        private void btn_ligar_Click_1(object sender, EventArgs e)
        {
            if (txt_Celular.Text == "")
            {
                MessageBox.Show("INSIRA UM NÚMERO VÁLIDO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string url = "https://telegram.me/share/url?url=" + txt_Celular + "&text=Olá, Tudo bem?";
                try
                {
                    Console.Beep();
                    MessageBox.Show("VOCÊ VAI SER DIRECIONADO PARA O SITE WHATSAPP!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(url);
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
            }
        }

        private void Anotacoes_Menu2_Click(object sender, EventArgs e)
        {
            Anotacao anotacao = new Anotacao();
            MessageBox.Show("INSIRA APENAS A ANOTAÇÃO, SELECIONE O CONTATO NO GRID", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            anotacao.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if(txt_Localizar.Text != "")
            {
                GridContato.DataSource = clsContatoBll.ObterDados(1, txt_Localizar.Text);
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
