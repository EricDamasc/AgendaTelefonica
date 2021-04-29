
namespace Agenda_Telefonica
{
    partial class Contatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contatos));
            this.GridContato = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Contatos_cat = new System.Windows.Forms.ToolStripMenuItem();
            this.Anotacoes_Menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.compromissosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Localizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NovoContato = new System.Windows.Forms.Button();
            this.btn_ExcluirContato = new System.Windows.Forms.Button();
            this.btn_AlterarContato = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.txt_COD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Email = new System.Windows.Forms.PictureBox();
            this.btn_WhatsApp = new System.Windows.Forms.PictureBox();
            this.btn_Pesquisar = new System.Windows.Forms.PictureBox();
            this.btn_ligar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridContato)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_WhatsApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ligar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridContato
            // 
            this.GridContato.AllowUserToAddRows = false;
            this.GridContato.AllowUserToDeleteRows = false;
            this.GridContato.BackgroundColor = System.Drawing.Color.Azure;
            this.GridContato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridContato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridContato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.GridContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContato.GridColor = System.Drawing.Color.Cornsilk;
            this.GridContato.Location = new System.Drawing.Point(11, 222);
            this.GridContato.MultiSelect = false;
            this.GridContato.Name = "GridContato";
            this.GridContato.ReadOnly = true;
            this.GridContato.RowHeadersVisible = false;
            this.GridContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridContato.Size = new System.Drawing.Size(1012, 356);
            this.GridContato.TabIndex = 0;
            this.GridContato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridContato_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.Contatos_cat,
            this.Anotacoes_Menu2,
            this.compromissosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Exit});
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(95, 22);
            this.btn_Exit.Text = "Sair";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Contatos_cat
            // 
            this.Contatos_cat.Image = ((System.Drawing.Image)(resources.GetObject("Contatos_cat.Image")));
            this.Contatos_cat.Name = "Contatos_cat";
            this.Contatos_cat.Size = new System.Drawing.Size(84, 20);
            this.Contatos_cat.Text = "Contatos";
            this.Contatos_cat.Click += new System.EventHandler(this.Contatos_cat_Click);
            // 
            // Anotacoes_Menu2
            // 
            this.Anotacoes_Menu2.Image = ((System.Drawing.Image)(resources.GetObject("Anotacoes_Menu2.Image")));
            this.Anotacoes_Menu2.Name = "Anotacoes_Menu2";
            this.Anotacoes_Menu2.Size = new System.Drawing.Size(93, 20);
            this.Anotacoes_Menu2.Text = "Anotações";
            this.Anotacoes_Menu2.Click += new System.EventHandler(this.Anotacoes_Menu2_Click);
            // 
            // compromissosToolStripMenuItem
            // 
            this.compromissosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("compromissosToolStripMenuItem.Image")));
            this.compromissosToolStripMenuItem.Name = "compromissosToolStripMenuItem";
            this.compromissosToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.compromissosToolStripMenuItem.Text = "Compromissos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem.Image")));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // txt_Localizar
            // 
            this.txt_Localizar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Localizar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txt_Localizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Localizar.Location = new System.Drawing.Point(117, 190);
            this.txt_Localizar.Multiline = true;
            this.txt_Localizar.Name = "txt_Localizar";
            this.txt_Localizar.Size = new System.Drawing.Size(539, 26);
            this.txt_Localizar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Localizar";
            // 
            // btn_NovoContato
            // 
            this.btn_NovoContato.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_NovoContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_NovoContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoContato.Image = ((System.Drawing.Image)(resources.GetObject("btn_NovoContato.Image")));
            this.btn_NovoContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NovoContato.Location = new System.Drawing.Point(27, 39);
            this.btn_NovoContato.Name = "btn_NovoContato";
            this.btn_NovoContato.Size = new System.Drawing.Size(99, 52);
            this.btn_NovoContato.TabIndex = 4;
            this.btn_NovoContato.Text = "Novo";
            this.btn_NovoContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NovoContato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NovoContato.UseVisualStyleBackColor = false;
            this.btn_NovoContato.Click += new System.EventHandler(this.btn_NovoContato_Click);
            // 
            // btn_ExcluirContato
            // 
            this.btn_ExcluirContato.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ExcluirContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExcluirContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirContato.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExcluirContato.Image")));
            this.btn_ExcluirContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExcluirContato.Location = new System.Drawing.Point(156, 39);
            this.btn_ExcluirContato.Name = "btn_ExcluirContato";
            this.btn_ExcluirContato.Size = new System.Drawing.Size(104, 52);
            this.btn_ExcluirContato.TabIndex = 5;
            this.btn_ExcluirContato.Text = "Excluir";
            this.btn_ExcluirContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ExcluirContato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ExcluirContato.UseVisualStyleBackColor = false;
            this.btn_ExcluirContato.Click += new System.EventHandler(this.btn_ExcluirContato_Click);
            // 
            // btn_AlterarContato
            // 
            this.btn_AlterarContato.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AlterarContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AlterarContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarContato.Image = ((System.Drawing.Image)(resources.GetObject("btn_AlterarContato.Image")));
            this.btn_AlterarContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AlterarContato.Location = new System.Drawing.Point(294, 39);
            this.btn_AlterarContato.Name = "btn_AlterarContato";
            this.btn_AlterarContato.Size = new System.Drawing.Size(106, 52);
            this.btn_AlterarContato.TabIndex = 6;
            this.btn_AlterarContato.Text = "Alterar";
            this.btn_AlterarContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AlterarContato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AlterarContato.UseVisualStyleBackColor = false;
            this.btn_AlterarContato.Click += new System.EventHandler(this.btn_AlterarContato_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voltar.Image")));
            this.btn_Voltar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Voltar.Location = new System.Drawing.Point(830, 584);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(134, 56);
            this.btn_Voltar.TabIndex = 7;
            this.btn_Voltar.Text = "VOLTAR";
            this.btn_Voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Voltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // txt_COD
            // 
            this.txt_COD.Enabled = false;
            this.txt_COD.Location = new System.Drawing.Point(11, 153);
            this.txt_COD.Name = "txt_COD";
            this.txt_COD.ReadOnly = true;
            this.txt_COD.Size = new System.Drawing.Size(66, 20);
            this.txt_COD.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "CODIGO";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(112, 153);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(291, 20);
            this.txt_Email.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "E-MAIL";
            // 
            // txt_Celular
            // 
            this.txt_Celular.BeepOnError = true;
            this.txt_Celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Celular.Location = new System.Drawing.Point(475, 153);
            this.txt_Celular.Mask = "(99) 00000-0000";
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.ReadOnly = true;
            this.txt_Celular.Size = new System.Drawing.Size(145, 26);
            this.txt_Celular.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "CELULAR";
            // 
            // btn_Email
            // 
            this.btn_Email.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Email.BackgroundImage")));
            this.btn_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Email.Location = new System.Drawing.Point(409, 146);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(50, 33);
            this.btn_Email.TabIndex = 22;
            this.btn_Email.TabStop = false;
            this.btn_Email.Click += new System.EventHandler(this.btn_Email_Click);
            // 
            // btn_WhatsApp
            // 
            this.btn_WhatsApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_WhatsApp.BackgroundImage")));
            this.btn_WhatsApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_WhatsApp.Location = new System.Drawing.Point(626, 151);
            this.btn_WhatsApp.Name = "btn_WhatsApp";
            this.btn_WhatsApp.Size = new System.Drawing.Size(50, 33);
            this.btn_WhatsApp.TabIndex = 23;
            this.btn_WhatsApp.TabStop = false;
            this.btn_WhatsApp.Click += new System.EventHandler(this.btn_WhatsApp_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.BackgroundImage")));
            this.btn_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pesquisar.Location = new System.Drawing.Point(658, 190);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(42, 26);
            this.btn_Pesquisar.TabIndex = 24;
            this.btn_Pesquisar.TabStop = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_ligar
            // 
            this.btn_ligar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ligar.BackgroundImage")));
            this.btn_ligar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ligar.Location = new System.Drawing.Point(682, 151);
            this.btn_ligar.Name = "btn_ligar";
            this.btn_ligar.Size = new System.Drawing.Size(52, 33);
            this.btn_ligar.TabIndex = 0;
            this.btn_ligar.TabStop = false;
            this.btn_ligar.Click += new System.EventHandler(this.btn_ligar_Click_1);
            // 
            // Contatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1035, 652);
            this.Controls.Add(this.btn_ligar);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_WhatsApp);
            this.Controls.Add(this.btn_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_COD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_AlterarContato);
            this.Controls.Add(this.btn_ExcluirContato);
            this.Controls.Add(this.btn_NovoContato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Localizar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GridContato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Contatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            ((System.ComponentModel.ISupportInitialize)(this.GridContato)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_WhatsApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Pesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ligar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridContato;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Exit;
        private System.Windows.Forms.ToolStripMenuItem Contatos_cat;
        private System.Windows.Forms.ToolStripMenuItem Anotacoes_Menu2;
        private System.Windows.Forms.ToolStripMenuItem compromissosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Localizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NovoContato;
        private System.Windows.Forms.Button btn_ExcluirContato;
        private System.Windows.Forms.Button btn_AlterarContato;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.TextBox txt_COD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_Celular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_Email;
        private System.Windows.Forms.PictureBox btn_WhatsApp;
        private System.Windows.Forms.PictureBox btn_Pesquisar;
        private System.Windows.Forms.PictureBox btn_ligar;
    }
}