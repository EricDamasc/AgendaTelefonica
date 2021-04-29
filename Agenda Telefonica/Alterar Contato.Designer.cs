
namespace Agenda_Telefonica
{
    partial class Alterar_Contato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar_Contato));
            this.btn_Pesquisar = new System.Windows.Forms.PictureBox();
            this.txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.txt_COD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Localizar = new System.Windows.Forms.TextBox();
            this.Grid_Alterar = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cidades = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Estados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CEP = new System.Windows.Forms.MaskedTextBox();
            this.txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Alterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.BackgroundImage")));
            this.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pesquisar.Location = new System.Drawing.Point(671, 151);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(42, 26);
            this.btn_Pesquisar.TabIndex = 41;
            this.btn_Pesquisar.TabStop = false;
            // 
            // txt_Celular
            // 
            this.txt_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Celular.Location = new System.Drawing.Point(379, 112);
            this.txt_Celular.Mask = "(99) 00000-0000";
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(132, 22);
            this.txt_Celular.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "CELULAR";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(110, 114);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(263, 20);
            this.txt_Nome.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "NOME";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Image")));
            this.btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Alterar.Location = new System.Drawing.Point(204, 545);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(146, 56);
            this.btn_Alterar.TabIndex = 36;
            this.btn_Alterar.Text = "ALTERAR";
            this.btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // txt_COD
            // 
            this.txt_COD.Enabled = false;
            this.txt_COD.Location = new System.Drawing.Point(21, 114);
            this.txt_COD.Name = "txt_COD";
            this.txt_COD.ReadOnly = true;
            this.txt_COD.Size = new System.Drawing.Size(66, 20);
            this.txt_COD.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "CODIGO";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voltar.Image")));
            this.btn_Voltar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Voltar.Location = new System.Drawing.Point(568, 545);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(134, 56);
            this.btn_Voltar.TabIndex = 33;
            this.btn_Voltar.Text = "VOLTAR";
            this.btn_Voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Localizar";
            // 
            // txt_Localizar
            // 
            this.txt_Localizar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Localizar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txt_Localizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Localizar.Location = new System.Drawing.Point(126, 151);
            this.txt_Localizar.Multiline = true;
            this.txt_Localizar.Name = "txt_Localizar";
            this.txt_Localizar.Size = new System.Drawing.Size(539, 26);
            this.txt_Localizar.TabIndex = 31;
            // 
            // Grid_Alterar
            // 
            this.Grid_Alterar.AllowUserToDeleteRows = false;
            this.Grid_Alterar.AllowUserToOrderColumns = true;
            this.Grid_Alterar.BackgroundColor = System.Drawing.Color.Azure;
            this.Grid_Alterar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Alterar.Location = new System.Drawing.Point(12, 183);
            this.Grid_Alterar.Name = "Grid_Alterar";
            this.Grid_Alterar.ReadOnly = true;
            this.Grid_Alterar.RowHeadersVisible = false;
            this.Grid_Alterar.Size = new System.Drawing.Size(1004, 356);
            this.Grid_Alterar.TabIndex = 30;
            this.Grid_Alterar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Alterar_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(295, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 74);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(517, 114);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(201, 20);
            this.txt_Email.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "E-MAIL";
            // 
            // txt_Cidades
            // 
            this.txt_Cidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Cidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_Cidades.FormattingEnabled = true;
            this.txt_Cidades.Location = new System.Drawing.Point(937, 116);
            this.txt_Cidades.Name = "txt_Cidades";
            this.txt_Cidades.Size = new System.Drawing.Size(117, 21);
            this.txt_Cidades.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(937, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "CIDADE";
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
            this.txt_Estados.Location = new System.Drawing.Point(814, 116);
            this.txt_Estados.Name = "txt_Estados";
            this.txt_Estados.Size = new System.Drawing.Size(117, 21);
            this.txt_Estados.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(814, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "ESTADOS";
            // 
            // txt_CEP
            // 
            this.txt_CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CEP.Location = new System.Drawing.Point(724, 114);
            this.txt_CEP.Mask = "00000-999";
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(87, 22);
            this.txt_CEP.TabIndex = 46;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.White;
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(726, 88);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(46, 22);
            this.txt.TabIndex = 45;
            this.txt.Text = "CEP";
            // 
            // Alterar_Contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1116, 608);
            this.Controls.Add(this.txt_Cidades);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Estados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.txt_COD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Localizar);
            this.Controls.Add(this.Grid_Alterar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alterar_Contato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Contato";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Alterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_Pesquisar;
        private System.Windows.Forms.MaskedTextBox txt_Celular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.TextBox txt_COD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Localizar;
        private System.Windows.Forms.DataGridView Grid_Alterar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_Cidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_Estados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_CEP;
        private System.Windows.Forms.Label txt;
    }
}