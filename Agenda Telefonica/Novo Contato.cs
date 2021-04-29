using Bll;
using Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Agenda_Telefonica
{
    public partial class Novo_Contato : Form
    {
        public clsContatoBll clsContatoBll = new clsContatoBll();
        public clsContatoDto Contato = new clsContatoDto();

        public Novo_Contato()
        {
            InitializeComponent();
        }

        private void BTN_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
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

            else if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Contato.IdCodigo = Convert.ToInt32(txt_COD.Text.ToString());
                Contato.Nome = (txt_Nome.Text);
                Contato.Email = (txt_Email.Text);
                Contato.CEP = (txt_CEP.Text);
                Contato.Estados = txt_Estados.Text;
                Contato.Cidades = txt_Cidades.Text;
                Contato.Telefone = txt_Telefone.Text;
                Contato.Celular = txt_Celular.Text;
                Contato.Anotacao = txt_Anotacoes.Text;



                clsContatoBll.Inserir(Contato);

                MessageBox.Show("Contato inserido com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS CORRETAMENTE!");
            }
        }
    }
}
