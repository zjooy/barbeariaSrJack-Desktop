namespace barbeariaSrJack
{
    partial class frmReserva
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
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Label();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.pnlInfoReserva = new System.Windows.Forms.Panel();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.pctVoltar = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblReserva = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.calReserva = new barbeariaSrJack.MeuCalendario();
            this.pnlReserva.SuspendLayout();
            this.pnlFundo.SuspendLayout();
            this.pnlInfoReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReserva
            // 
            this.pnlReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(127)))), ((int)(((byte)(114)))));
            this.pnlReserva.Controls.Add(this.pnlFundo);
            this.pnlReserva.Controls.Add(this.pctLogo);
            this.pnlReserva.Location = new System.Drawing.Point(142, 92);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(1240, 655);
            this.pnlReserva.TabIndex = 3;
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.Black;
            this.pnlFundo.Controls.Add(this.btnSalvar);
            this.pnlFundo.Controls.Add(this.calReserva);
            this.pnlFundo.Controls.Add(this.cmbStatus);
            this.pnlFundo.Controls.Add(this.btnLimpar);
            this.pnlFundo.Controls.Add(this.lblDataReserva);
            this.pnlFundo.Controls.Add(this.lblHorario);
            this.pnlFundo.Controls.Add(this.cmbHorario);
            this.pnlFundo.Controls.Add(this.pnlInfoReserva);
            this.pnlFundo.Controls.Add(this.pctVoltar);
            this.pnlFundo.Controls.Add(this.lblStatus);
            this.pnlFundo.Controls.Add(this.lblObs);
            this.pnlFundo.Controls.Add(this.txtObservacao);
            this.pnlFundo.Controls.Add(this.txtCodigo);
            this.pnlFundo.Controls.Add(this.lblReserva);
            this.pnlFundo.Controls.Add(this.lblCodigo);
            this.pnlFundo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFundo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.pnlFundo.Location = new System.Drawing.Point(258, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(982, 655);
            this.pnlFundo.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::barbeariaSrJack.Properties.Resources.salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(766, 585);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(181, 50);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "AGUARDANDO",
            "APROVADA",
            "CANCELADA",
            "FINALIZADA"});
            this.cmbStatus.Location = new System.Drawing.Point(27, 493);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(424, 30);
            this.cmbStatus.TabIndex = 35;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(722, 494);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(249, 72);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblDataReserva.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataReserva.ForeColor = System.Drawing.Color.White;
            this.lblDataReserva.Location = new System.Drawing.Point(492, 154);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(153, 26);
            this.lblDataReserva.TabIndex = 32;
            this.lblDataReserva.Text = "DATA DA RESERVA";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(813, 154);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(84, 26);
            this.lblHorario.TabIndex = 31;
            this.lblHorario.Text = "HORÁRIO";
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.Enabled = false;
            this.cmbHorario.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "10:15",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30"});
            this.cmbHorario.Location = new System.Drawing.Point(804, 184);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(167, 30);
            this.cmbHorario.TabIndex = 30;
            this.cmbHorario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHorario_KeyPress);
            // 
            // pnlInfoReserva
            // 
            this.pnlInfoReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoReserva.Controls.Add(this.cmbServico);
            this.pnlInfoReserva.Controls.Add(this.lblCliente);
            this.pnlInfoReserva.Controls.Add(this.cmbCliente);
            this.pnlInfoReserva.Controls.Add(this.lblServico);
            this.pnlInfoReserva.Controls.Add(this.lblFuncionario);
            this.pnlInfoReserva.Controls.Add(this.cmbFuncionario);
            this.pnlInfoReserva.Location = new System.Drawing.Point(20, 154);
            this.pnlInfoReserva.Name = "pnlInfoReserva";
            this.pnlInfoReserva.Size = new System.Drawing.Size(447, 287);
            this.pnlInfoReserva.TabIndex = 29;
            // 
            // cmbServico
            // 
            this.cmbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServico.Enabled = false;
            this.cmbServico.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(17, 228);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(407, 30);
            this.cmbServico.TabIndex = 33;
            this.cmbServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbServico_KeyPress);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(12, 113);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(77, 26);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "CLIENTE";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Enabled = false;
            this.cmbCliente.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(10, 142);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(424, 30);
            this.cmbCliente.TabIndex = 25;
            this.cmbCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCliente_KeyPress);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.BackColor = System.Drawing.Color.Transparent;
            this.lblServico.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.White;
            this.lblServico.Location = new System.Drawing.Point(12, 194);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(82, 26);
            this.lblServico.TabIndex = 28;
            this.lblServico.Text = "SERVIÇO";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionario.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblFuncionario.Location = new System.Drawing.Point(11, 16);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(120, 26);
            this.lblFuncionario.TabIndex = 24;
            this.lblFuncionario.Text = "FUNCIONÁRIO";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.Enabled = false;
            this.cmbFuncionario.Font = new System.Drawing.Font("Britannic Bold", 15.25F);
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(9, 45);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(424, 30);
            this.cmbFuncionario.TabIndex = 23;
            this.cmbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFuncionario_KeyPress);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(33, 465);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 26);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "STATUS";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.BackColor = System.Drawing.Color.Transparent;
            this.lblObs.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.White;
            this.lblObs.Location = new System.Drawing.Point(179, 58);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(119, 26);
            this.lblObs.TabIndex = 7;
            this.lblObs.Text = "OBSERVAÇÃO";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(177, 87);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(795, 31);
            this.txtObservacao.TabIndex = 6;
            this.txtObservacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacao_KeyPress);
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
            // lblReserva
            // 
            this.lblReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReserva.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.ForeColor = System.Drawing.Color.White;
            this.lblReserva.Location = new System.Drawing.Point(0, 0);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(982, 48);
            this.lblReserva.TabIndex = 3;
            this.lblReserva.Text = "RESERVA";
            this.lblReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // calReserva
            // 
            this.calReserva.Location = new System.Drawing.Point(497, 189);
            this.calReserva.Name = "calReserva";
            this.calReserva.TabIndex = 36;
            this.calReserva.TitleBackColor = System.Drawing.Color.Black;
            this.calReserva.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.calReserva.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calReserva_DateSelected);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::barbeariaSrJack.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1522, 814);
            this.Controls.Add(this.pnlReserva);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.pnlReserva.ResumeLayout(false);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.pnlInfoReserva.ResumeLayout(false);
            this.pnlInfoReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.PictureBox pctVoltar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblDataReserva;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Panel pnlInfoReserva;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label btnLimpar;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.ComboBox cmbStatus;
        private MeuCalendario calReserva;
        private System.Windows.Forms.Button btnSalvar;
    }
}