﻿namespace barbeariaSrJack
{
    partial class frmEmpresa
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
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.pnlClienteBusca = new System.Windows.Forms.Panel();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.pnlBusca = new System.Windows.Forms.Panel();
            this.pctVoltar = new System.Windows.Forms.PictureBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlEmpresa.SuspendLayout();
            this.pnlClienteBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.pnlBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(127)))), ((int)(((byte)(114)))));
            this.pnlEmpresa.Controls.Add(this.pnlClienteBusca);
            this.pnlEmpresa.Controls.Add(this.pctLogo);
            this.pnlEmpresa.Location = new System.Drawing.Point(127, 128);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(1240, 655);
            this.pnlEmpresa.TabIndex = 1;
            // 
            // pnlClienteBusca
            // 
            this.pnlClienteBusca.BackColor = System.Drawing.Color.Black;
            this.pnlClienteBusca.Controls.Add(this.lblExcluir);
            this.pnlClienteBusca.Controls.Add(this.lblAlterar);
            this.pnlClienteBusca.Controls.Add(this.lblCadastrar);
            this.pnlClienteBusca.Controls.Add(this.dgvEmpresa);
            this.pnlClienteBusca.Controls.Add(this.pnlBusca);
            this.pnlClienteBusca.Location = new System.Drawing.Point(218, 0);
            this.pnlClienteBusca.Name = "pnlClienteBusca";
            this.pnlClienteBusca.Size = new System.Drawing.Size(1022, 655);
            this.pnlClienteBusca.TabIndex = 5;
            // 
            // lblExcluir
            // 
            this.lblExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblExcluir.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.White;
            this.lblExcluir.Location = new System.Drawing.Point(677, 585);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(306, 47);
            this.lblExcluir.TabIndex = 21;
            this.lblExcluir.Text = "EXCLUIR";
            this.lblExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlterar
            // 
            this.lblAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblAlterar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterar.ForeColor = System.Drawing.Color.White;
            this.lblAlterar.Location = new System.Drawing.Point(362, 585);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(306, 47);
            this.lblAlterar.TabIndex = 20;
            this.lblAlterar.Text = "ALTERAR";
            this.lblAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblCadastrar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.ForeColor = System.Drawing.Color.White;
            this.lblCadastrar.Location = new System.Drawing.Point(51, 585);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(302, 47);
            this.lblCadastrar.TabIndex = 19;
            this.lblCadastrar.Text = "CADASTRAR";
            this.lblCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadastrar.Click += new System.EventHandler(this.lblCadastrar_Click);
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.Color.Black;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(17, 69);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(991, 498);
            this.dgvEmpresa.TabIndex = 7;
            // 
            // pnlBusca
            // 
            this.pnlBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.pnlBusca.Controls.Add(this.pctVoltar);
            this.pnlBusca.Controls.Add(this.cmbStatus);
            this.pnlBusca.Controls.Add(this.txtEmpresa);
            this.pnlBusca.Controls.Add(this.lblStatus);
            this.pnlBusca.Controls.Add(this.lblEmpresa);
            this.pnlBusca.Location = new System.Drawing.Point(0, 0);
            this.pnlBusca.Name = "pnlBusca";
            this.pnlBusca.Size = new System.Drawing.Size(1022, 50);
            this.pnlBusca.TabIndex = 6;
            // 
            // pctVoltar
            // 
            this.pctVoltar.BackColor = System.Drawing.Color.White;
            this.pctVoltar.Image = global::barbeariaSrJack.Properties.Resources.seta;
            this.pctVoltar.Location = new System.Drawing.Point(973, 0);
            this.pctVoltar.Name = "pctVoltar";
            this.pctVoltar.Size = new System.Drawing.Size(49, 50);
            this.pctVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVoltar.TabIndex = 29;
            this.pctVoltar.TabStop = false;
            this.pctVoltar.Click += new System.EventHandler(this.pctVoltar_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(752, 9);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(179, 29);
            this.cmbStatus.TabIndex = 4;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtEmpresa.Location = new System.Drawing.Point(115, 11);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(539, 29);
            this.txtEmpresa.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(660, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 27);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "STATUS";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(5, 11);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(111, 27);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "EMPRESA";
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::barbeariaSrJack.Properties.Resources.logoB;
            this.pctLogo.Location = new System.Drawing.Point(3, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(191, 165);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::barbeariaSrJack.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1462, 873);
            this.Controls.Add(this.pnlEmpresa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlClienteBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.pnlBusca.ResumeLayout(false);
            this.pnlBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.Panel pnlClienteBusca;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Panel pnlBusca;
        private System.Windows.Forms.PictureBox pctVoltar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}