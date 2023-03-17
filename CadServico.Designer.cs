namespace barbeariaSrJack
{
    partial class frmCadServico
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
            this.pnlCadServico = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Label();
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblExc = new System.Windows.Forms.Label();
            this.cmbExc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctVoltar = new System.Windows.Forms.PictureBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.mkdDataDeCadastro = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblNomeServico = new System.Windows.Forms.Label();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCadastrarServico = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.pnlCadServico.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadServico
            // 
            this.pnlCadServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(127)))), ((int)(((byte)(114)))));
            this.pnlCadServico.Controls.Add(this.btnSalvar);
            this.pnlCadServico.Controls.Add(this.btnLimpar);
            this.pnlCadServico.Controls.Add(this.pnlReserva);
            this.pnlCadServico.Controls.Add(this.pctLogo);
            this.pnlCadServico.Location = new System.Drawing.Point(162, 98);
            this.pnlCadServico.Name = "pnlCadServico";
            this.pnlCadServico.Size = new System.Drawing.Size(1240, 655);
            this.pnlCadServico.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Black;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(5, 547);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(249, 72);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(5, 465);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(249, 72);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlReserva
            // 
            this.pnlReserva.BackColor = System.Drawing.Color.Black;
            this.pnlReserva.Controls.Add(this.txtValorServico);
            this.pnlReserva.Controls.Add(this.cmbEmpresa);
            this.pnlReserva.Controls.Add(this.lblEmpresa);
            this.pnlReserva.Controls.Add(this.lblExc);
            this.pnlReserva.Controls.Add(this.cmbExc);
            this.pnlReserva.Controls.Add(this.label1);
            this.pnlReserva.Controls.Add(this.pctVoltar);
            this.pnlReserva.Controls.Add(this.lblCadastro);
            this.pnlReserva.Controls.Add(this.mkdDataDeCadastro);
            this.pnlReserva.Controls.Add(this.label3);
            this.pnlReserva.Controls.Add(this.cmbStatus);
            this.pnlReserva.Controls.Add(this.lblDescricao);
            this.pnlReserva.Controls.Add(this.txtDescricao);
            this.pnlReserva.Controls.Add(this.lblNomeServico);
            this.pnlReserva.Controls.Add(this.txtNomeServico);
            this.pnlReserva.Controls.Add(this.txtCodigo);
            this.pnlReserva.Controls.Add(this.lblCadastrarServico);
            this.pnlReserva.Controls.Add(this.lblCodigo);
            this.pnlReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.pnlReserva.Location = new System.Drawing.Point(258, 0);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(982, 655);
            this.pnlReserva.TabIndex = 1;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.Enabled = false;
            this.cmbEmpresa.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Items.AddRange(new object[] {
            "BARBEARIA SR. JACK",
            "BARBEARIA SR. JACK FILIAL 1",
            "BARBEARIA SR. JACK FILIAL 2",
            "BARBEARIA SR. JACK FILIAL 3"});
            this.cmbEmpresa.Location = new System.Drawing.Point(18, 326);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(948, 30);
            this.cmbEmpresa.TabIndex = 45;
            this.cmbEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEmpresa_KeyPress);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(25, 297);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(88, 26);
            this.lblEmpresa.TabIndex = 44;
            this.lblEmpresa.Text = "EMPRESA";
            // 
            // lblExc
            // 
            this.lblExc.AutoSize = true;
            this.lblExc.BackColor = System.Drawing.Color.Transparent;
            this.lblExc.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExc.ForeColor = System.Drawing.Color.White;
            this.lblExc.Location = new System.Drawing.Point(22, 223);
            this.lblExc.Name = "lblExc";
            this.lblExc.Size = new System.Drawing.Size(156, 26);
            this.lblExc.TabIndex = 42;
            this.lblExc.Text = "TEMPO EXECUÇÃO";
            // 
            // cmbExc
            // 
            this.cmbExc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExc.Enabled = false;
            this.cmbExc.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbExc.FormattingEnabled = true;
            this.cmbExc.Items.AddRange(new object[] {
            "01:00:00",
            "00:45:00",
            "00:50:00",
            "00:30:00"});
            this.cmbExc.Location = new System.Drawing.Point(18, 252);
            this.cmbExc.Name = "cmbExc";
            this.cmbExc.Size = new System.Drawing.Size(148, 30);
            this.cmbExc.TabIndex = 41;
            this.cmbExc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbExc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "VALOR SERVIÇO";
            // 
            // pctVoltar
            // 
            this.pctVoltar.BackColor = System.Drawing.Color.White;
            this.pctVoltar.Image = global::barbeariaSrJack.Properties.Resources.seta;
            this.pctVoltar.Location = new System.Drawing.Point(933, 0);
            this.pctVoltar.Name = "pctVoltar";
            this.pctVoltar.Size = new System.Drawing.Size(49, 48);
            this.pctVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVoltar.TabIndex = 28;
            this.pctVoltar.TabStop = false;
            this.pctVoltar.Click += new System.EventHandler(this.pctVoltar_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.Color.White;
            this.lblCadastro.Location = new System.Drawing.Point(780, 139);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(172, 26);
            this.lblCadastro.TabIndex = 26;
            this.lblCadastro.Text = "DATA DE  CADASTRO";
            // 
            // mkdDataDeCadastro
            // 
            this.mkdDataDeCadastro.Enabled = false;
            this.mkdDataDeCadastro.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdDataDeCadastro.Location = new System.Drawing.Point(776, 168);
            this.mkdDataDeCadastro.Mask = "00/00/0000";
            this.mkdDataDeCadastro.Name = "mkdDataDeCadastro";
            this.mkdDataDeCadastro.Size = new System.Drawing.Size(190, 31);
            this.mkdDataDeCadastro.TabIndex = 24;
            this.mkdDataDeCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(188, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "STATUS";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(177, 168);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(593, 30);
            this.cmbStatus.TabIndex = 20;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(188, 223);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(106, 26);
            this.lblDescricao.TabIndex = 18;
            this.lblDescricao.Text = "DESCRICÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(177, 252);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(789, 31);
            this.txtDescricao.TabIndex = 14;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // lblNomeServico
            // 
            this.lblNomeServico.AutoSize = true;
            this.lblNomeServico.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeServico.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeServico.ForeColor = System.Drawing.Color.White;
            this.lblNomeServico.Location = new System.Drawing.Point(179, 58);
            this.lblNomeServico.Name = "lblNomeServico";
            this.lblNomeServico.Size = new System.Drawing.Size(132, 26);
            this.lblNomeServico.TabIndex = 7;
            this.lblNomeServico.Text = "NOME SERVIÇO";
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeServico.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeServico.Location = new System.Drawing.Point(177, 87);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(795, 31);
            this.txtNomeServico.TabIndex = 6;
            this.txtNomeServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeServico_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(20, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 31);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblCadastrarServico
            // 
            this.lblCadastrarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblCadastrarServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCadastrarServico.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarServico.ForeColor = System.Drawing.Color.White;
            this.lblCadastrarServico.Location = new System.Drawing.Point(0, 0);
            this.lblCadastrarServico.Name = "lblCadastrarServico";
            this.lblCadastrarServico.Size = new System.Drawing.Size(982, 48);
            this.lblCadastrarServico.TabIndex = 3;
            this.lblCadastrarServico.Text = "Cadastrar Serviço";
            this.lblCadastrarServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(22, 58);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 26);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "CÓDIGO";
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::barbeariaSrJack.Properties.Resources.logoB;
            this.pctLogo.Location = new System.Drawing.Point(37, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(191, 165);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // txtValorServico
            // 
            this.txtValorServico.Enabled = false;
            this.txtValorServico.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorServico.Location = new System.Drawing.Point(20, 168);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(146, 31);
            this.txtValorServico.TabIndex = 46;
            this.txtValorServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorServico_KeyPress);
            // 
            // frmCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::barbeariaSrJack.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1565, 850);
            this.Controls.Add(this.pnlCadServico);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadServico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadServico_Load);
            this.pnlCadServico.ResumeLayout(false);
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadServico;
        private System.Windows.Forms.Label btnSalvar;
        private System.Windows.Forms.Label btnLimpar;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.PictureBox pctVoltar;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.MaskedTextBox mkdDataDeCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblNomeServico;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCadastrarServico;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExc;
        private System.Windows.Forms.ComboBox cmbExc;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.TextBox txtValorServico;
    }
}