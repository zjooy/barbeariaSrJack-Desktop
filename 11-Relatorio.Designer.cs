namespace barbeariaSrJack
{
    partial class frmRelatorio
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
            this.pnlRelatorio = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.radTelefone = new System.Windows.Forms.RadioButton();
            this.radInativo = new System.Windows.Forms.RadioButton();
            this.radAtivo = new System.Windows.Forms.RadioButton();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.radFuncionario = new System.Windows.Forms.RadioButton();
            this.radEmpresa = new System.Windows.Forms.RadioButton();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.lblTabela = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.pnlRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            this.pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRelatorio
            // 
            this.pnlRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(127)))), ((int)(((byte)(114)))));
            this.pnlRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRelatorio.Controls.Add(this.btnAtualizar);
            this.pnlRelatorio.Controls.Add(this.btnFechar);
            this.pnlRelatorio.Controls.Add(this.lblRelatorio);
            this.pnlRelatorio.Controls.Add(this.label1);
            this.pnlRelatorio.Controls.Add(this.btnLimpar);
            this.pnlRelatorio.Controls.Add(this.pctLogo);
            this.pnlRelatorio.Controls.Add(this.pnlFiltro);
            this.pnlRelatorio.Controls.Add(this.pnlTabela);
            this.pnlRelatorio.Controls.Add(this.btnSalvar);
            this.pnlRelatorio.Controls.Add(this.dgvRelatorio);
            this.pnlRelatorio.Location = new System.Drawing.Point(141, 129);
            this.pnlRelatorio.Name = "pnlRelatorio";
            this.pnlRelatorio.Size = new System.Drawing.Size(1224, 633);
            this.pnlRelatorio.TabIndex = 4;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImage = global::barbeariaSrJack.Properties.Resources.atualizar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(1082, 73);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(45, 45);
            this.btnAtualizar.TabIndex = 31;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::barbeariaSrJack.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1148, 73);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 45);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.BackColor = System.Drawing.Color.Black;
            this.lblRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRelatorio.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.ForeColor = System.Drawing.Color.White;
            this.lblRelatorio.Location = new System.Drawing.Point(0, 0);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(1224, 48);
            this.lblRelatorio.TabIndex = 28;
            this.lblRelatorio.Text = "RELATÓRIO";
            this.lblRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 72);
            this.label1.TabIndex = 27;
            this.label1.Text = "SALVAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(16, 464);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(249, 72);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::barbeariaSrJack.Properties.Resources.logoB;
            this.pctLogo.Location = new System.Drawing.Point(27, 61);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(191, 165);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 25;
            this.pctLogo.TabStop = false;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.Black;
            this.pnlFiltro.Controls.Add(this.radTelefone);
            this.pnlFiltro.Controls.Add(this.radInativo);
            this.pnlFiltro.Controls.Add(this.radAtivo);
            this.pnlFiltro.Controls.Add(this.lblFiltro);
            this.pnlFiltro.Location = new System.Drawing.Point(275, 125);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(787, 64);
            this.pnlFiltro.TabIndex = 24;
            // 
            // radTelefone
            // 
            this.radTelefone.AutoSize = true;
            this.radTelefone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTelefone.ForeColor = System.Drawing.Color.White;
            this.radTelefone.Location = new System.Drawing.Point(281, 32);
            this.radTelefone.Name = "radTelefone";
            this.radTelefone.Size = new System.Drawing.Size(118, 22);
            this.radTelefone.TabIndex = 26;
            this.radTelefone.TabStop = true;
            this.radTelefone.Text = "TELEFONE";
            this.radTelefone.UseVisualStyleBackColor = true;
            // 
            // radInativo
            // 
            this.radInativo.AutoSize = true;
            this.radInativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInativo.ForeColor = System.Drawing.Color.White;
            this.radInativo.Location = new System.Drawing.Point(138, 32);
            this.radInativo.Name = "radInativo";
            this.radInativo.Size = new System.Drawing.Size(105, 22);
            this.radInativo.TabIndex = 25;
            this.radInativo.TabStop = true;
            this.radInativo.Text = "INATIVO";
            this.radInativo.UseVisualStyleBackColor = true;
            // 
            // radAtivo
            // 
            this.radAtivo.AutoSize = true;
            this.radAtivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAtivo.ForeColor = System.Drawing.Color.White;
            this.radAtivo.Location = new System.Drawing.Point(4, 32);
            this.radAtivo.Name = "radAtivo";
            this.radAtivo.Size = new System.Drawing.Size(84, 22);
            this.radAtivo.TabIndex = 24;
            this.radAtivo.TabStop = true;
            this.radAtivo.Text = "ATIVO";
            this.radAtivo.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFiltro.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(0, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(787, 21);
            this.lblFiltro.TabIndex = 11;
            this.lblFiltro.Text = "FILTRO";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTabela
            // 
            this.pnlTabela.BackColor = System.Drawing.Color.Black;
            this.pnlTabela.Controls.Add(this.radFuncionario);
            this.pnlTabela.Controls.Add(this.radEmpresa);
            this.pnlTabela.Controls.Add(this.radCliente);
            this.pnlTabela.Controls.Add(this.lblTabela);
            this.pnlTabela.Location = new System.Drawing.Point(275, 61);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(787, 64);
            this.pnlTabela.TabIndex = 23;
            // 
            // radFuncionario
            // 
            this.radFuncionario.AutoSize = true;
            this.radFuncionario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFuncionario.ForeColor = System.Drawing.Color.White;
            this.radFuncionario.Location = new System.Drawing.Point(281, 32);
            this.radFuncionario.Name = "radFuncionario";
            this.radFuncionario.Size = new System.Drawing.Size(156, 22);
            this.radFuncionario.TabIndex = 26;
            this.radFuncionario.TabStop = true;
            this.radFuncionario.Text = "FUNCIONÁRIO";
            this.radFuncionario.UseVisualStyleBackColor = true;
            // 
            // radEmpresa
            // 
            this.radEmpresa.AutoSize = true;
            this.radEmpresa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmpresa.ForeColor = System.Drawing.Color.White;
            this.radEmpresa.Location = new System.Drawing.Point(138, 32);
            this.radEmpresa.Name = "radEmpresa";
            this.radEmpresa.Size = new System.Drawing.Size(111, 22);
            this.radEmpresa.TabIndex = 25;
            this.radEmpresa.TabStop = true;
            this.radEmpresa.Text = "EMPRESA";
            this.radEmpresa.UseVisualStyleBackColor = true;
            // 
            // radCliente
            // 
            this.radCliente.AutoSize = true;
            this.radCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCliente.ForeColor = System.Drawing.Color.White;
            this.radCliente.Location = new System.Drawing.Point(4, 32);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(103, 22);
            this.radCliente.TabIndex = 24;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "CLIENTE";
            this.radCliente.UseVisualStyleBackColor = true;
            // 
            // lblTabela
            // 
            this.lblTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblTabela.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTabela.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.ForeColor = System.Drawing.Color.White;
            this.lblTabela.Location = new System.Drawing.Point(0, 0);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(787, 21);
            this.lblTabela.TabIndex = 11;
            this.lblTabela.Text = "TABELA";
            this.lblTabela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(1068, 135);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 51);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.Black;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Enabled = false;
            this.dgvRelatorio.Location = new System.Drawing.Point(275, 195);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(931, 422);
            this.dgvRelatorio.TabIndex = 0;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::barbeariaSrJack.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 840);
            this.Controls.Add(this.pnlRelatorio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_11_Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.pnlRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlTabela.ResumeLayout(false);
            this.pnlTabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRelatorio;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.RadioButton radTelefone;
        private System.Windows.Forms.RadioButton radInativo;
        private System.Windows.Forms.RadioButton radAtivo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel pnlTabela;
        private System.Windows.Forms.RadioButton radFuncionario;
        private System.Windows.Forms.RadioButton radEmpresa;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnLimpar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnFechar;
    }
}