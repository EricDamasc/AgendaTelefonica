
namespace Agenda_Telefonica
{
    partial class Novo_Contato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novo_Contato));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.txt_CEP = new System.Windows.Forms.MaskedTextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Estados = new System.Windows.Forms.ComboBox();
            this.txt_Cidades = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_COD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Voltar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.txt_Anotacoes = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(160, 176);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(263, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(23, 219);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(44, 20);
            this.txt.TabIndex = 2;
            this.txt.Text = "CEP";
            // 
            // txt_CEP
            // 
            this.txt_CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CEP.Location = new System.Drawing.Point(23, 242);
            this.txt_CEP.Mask = "00000-999";
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(99, 26);
            this.txt_CEP.TabIndex = 4;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(441, 176);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(291, 20);
            this.txt_Email.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-MAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ESTADOS";
            // 
            // txt_Estados
            // 
            this.txt_Estados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Estados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_Estados.FormattingEnabled = true;
            this.txt_Estados.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.txt_Estados.Location = new System.Drawing.Point(160, 247);
            this.txt_Estados.Name = "txt_Estados";
            this.txt_Estados.Size = new System.Drawing.Size(117, 21);
            this.txt_Estados.TabIndex = 10;
            // 
            // txt_Cidades
            // 
            this.txt_Cidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Cidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txt_Cidades.FormattingEnabled = true;
            this.txt_Cidades.Location = new System.Drawing.Point(293, 247);
            this.txt_Cidades.Name = "txt_Cidades";
            this.txt_Cidades.Size = new System.Drawing.Size(117, 21);
            this.txt_Cidades.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "CIDADE";
            // 
            // txt_COD
            // 
            this.txt_COD.Enabled = false;
            this.txt_COD.Location = new System.Drawing.Point(19, 176);
            this.txt_COD.Name = "txt_COD";
            this.txt_COD.ReadOnly = true;
            this.txt_COD.Size = new System.Drawing.Size(66, 20);
            this.txt_COD.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "CODIGO";
            // 
            // txt_Celular
            // 
            this.txt_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Celular.Location = new System.Drawing.Point(434, 242);
            this.txt_Celular.Mask = "(99) 00000-0000";
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(145, 26);
            this.txt_Celular.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "CELULAR";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.Location = new System.Drawing.Point(609, 242);
            this.txt_Telefone.Mask = "(99) 0000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(132, 26);
            this.txt_Telefone.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(609, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "TELEFONE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(293, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 88);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Voltar
            // 
            this.BTN_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Voltar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Voltar.Image")));
            this.BTN_Voltar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTN_Voltar.Location = new System.Drawing.Point(445, 429);
            this.BTN_Voltar.Name = "BTN_Voltar";
            this.BTN_Voltar.Size = new System.Drawing.Size(134, 56);
            this.BTN_Voltar.TabIndex = 20;
            this.BTN_Voltar.Text = "VOLTAR";
            this.BTN_Voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Voltar.UseVisualStyleBackColor = true;
            this.BTN_Voltar.Click += new System.EventHandler(this.BTN_Voltar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Salvar.Image")));
            this.BTN_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Salvar.Location = new System.Drawing.Point(205, 429);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(123, 56);
            this.BTN_Salvar.TabIndex = 21;
            this.BTN_Salvar.Text = "SALVAR";
            this.BTN_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // txt_Anotacoes
            // 
            this.txt_Anotacoes.Location = new System.Drawing.Point(23, 323);
            this.txt_Anotacoes.Name = "txt_Anotacoes";
            this.txt_Anotacoes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_Anotacoes.ShowSelectionMargin = true;
            this.txt_Anotacoes.Size = new System.Drawing.Size(274, 88);
            this.txt_Anotacoes.TabIndex = 22;
            this.txt_Anotacoes.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "ANOTAÇÕES";
            // 
            // Novo_Contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Anotacoes);
            this.Controls.Add(this.BTN_Salvar);
            this.Controls.Add(this.BTN_Voltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_COD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Cidades);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Estados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Novo_Contato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Contato";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.MaskedTextBox txt_CEP;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_Estados;
        private System.Windows.Forms.ComboBox txt_Cidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_COD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_Celular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Voltar;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.RichTextBox txt_Anotacoes;
        private System.Windows.Forms.Label label2;
    }
}