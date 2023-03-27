namespace barbeariaSrJack
{
    partial class FrmAjuda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjuda));
            this.pnlAjuda = new System.Windows.Forms.Panel();
            this.btnFecharAjuda = new System.Windows.Forms.Button();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.lblMenu = new System.Windows.Forms.Label();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.tabFuncionario = new System.Windows.Forms.TabPage();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabServico = new System.Windows.Forms.TabPage();
            this.lblServico = new System.Windows.Forms.Label();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.tabReserva = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlAjuda.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            this.tabFuncionario.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabServico.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.tabReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAjuda
            // 
            this.pnlAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(127)))), ((int)(((byte)(114)))));
            this.pnlAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAjuda.Controls.Add(this.pctLogo);
            this.pnlAjuda.Controls.Add(this.btnFecharAjuda);
            this.pnlAjuda.Controls.Add(this.lblAjuda);
            this.pnlAjuda.Controls.Add(this.tabControl1);
            this.pnlAjuda.Controls.Add(this.btnFechar);
            this.pnlAjuda.Location = new System.Drawing.Point(188, 50);
            this.pnlAjuda.Name = "pnlAjuda";
            this.pnlAjuda.Size = new System.Drawing.Size(1200, 600);
            this.pnlAjuda.TabIndex = 6;
            // 
            // btnFecharAjuda
            // 
            this.btnFecharAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.btnFecharAjuda.BackgroundImage = global::barbeariaSrJack.Properties.Resources.fechar;
            this.btnFecharAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFecharAjuda.FlatAppearance.BorderSize = 0;
            this.btnFecharAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharAjuda.Location = new System.Drawing.Point(1139, 0);
            this.btnFecharAjuda.Name = "btnFecharAjuda";
            this.btnFecharAjuda.Size = new System.Drawing.Size(58, 58);
            this.btnFecharAjuda.TabIndex = 31;
            this.btnFecharAjuda.UseVisualStyleBackColor = false;
            this.btnFecharAjuda.Click += new System.EventHandler(this.btnFecharAjuda_Click);
            // 
            // lblAjuda
            // 
            this.lblAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblAjuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAjuda.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.ForeColor = System.Drawing.Color.White;
            this.lblAjuda.Location = new System.Drawing.Point(0, 0);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(1200, 58);
            this.lblAjuda.TabIndex = 29;
            this.lblAjuda.Text = "AJUDA";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblAjuda, "Ajuda");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabMenu);
            this.tabControl1.Controls.Add(this.tabEmpresa);
            this.tabControl1.Controls.Add(this.tabFuncionario);
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabServico);
            this.tabControl1.Controls.Add(this.tabRelatorio);
            this.tabControl1.Controls.Add(this.tabReserva);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(260, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 511);
            this.tabControl1.TabIndex = 23;
            this.toolTip1.SetToolTip(this.tabControl1, "Menu");
            // 
            // tabLogin
            // 
            this.tabLogin.AutoScroll = true;
            this.tabLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.tabLogin.Controls.Add(this.lblLogin);
            this.tabLogin.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLogin.Location = new System.Drawing.Point(4, 34);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(894, 473);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "LOGIN";
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Black;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogin.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblLogin.Location = new System.Drawing.Point(3, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(888, 467);
            this.lblLogin.TabIndex = 24;
            this.lblLogin.Text = resources.GetString("lblLogin.Text");
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblLogin, "Login");
            // 
            // tabMenu
            // 
            this.tabMenu.AutoScroll = true;
            this.tabMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.tabMenu.Controls.Add(this.lblMenu);
            this.tabMenu.Location = new System.Drawing.Point(4, 34);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(894, 473);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.Text = "MENU";
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.Black;
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblMenu.Location = new System.Drawing.Point(3, 3);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(888, 467);
            this.lblMenu.TabIndex = 25;
            this.lblMenu.Text = resources.GetString("lblMenu.Text");
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblMenu, "Menu");
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.AutoScroll = true;
            this.tabEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabEmpresa.Controls.Add(this.lblEmpresa);
            this.tabEmpresa.Location = new System.Drawing.Point(4, 34);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Size = new System.Drawing.Size(894, 473);
            this.tabEmpresa.TabIndex = 2;
            this.tabEmpresa.Text = "EMPRESA";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BackColor = System.Drawing.Color.Black;
            this.lblEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpresa.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblEmpresa.Location = new System.Drawing.Point(0, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(894, 473);
            this.lblEmpresa.TabIndex = 26;
            this.lblEmpresa.Text = resources.GetString("lblEmpresa.Text");
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblEmpresa, "Empresa");
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.AutoScroll = true;
            this.tabFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabFuncionario.Controls.Add(this.lblFuncionario);
            this.tabFuncionario.Location = new System.Drawing.Point(4, 34);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.Size = new System.Drawing.Size(894, 473);
            this.tabFuncionario.TabIndex = 3;
            this.tabFuncionario.Text = "FUNCIONARIO";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.BackColor = System.Drawing.Color.Black;
            this.lblFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFuncionario.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblFuncionario.Location = new System.Drawing.Point(0, 0);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(894, 473);
            this.lblFuncionario.TabIndex = 27;
            this.lblFuncionario.Text = resources.GetString("lblFuncionario.Text");
            this.lblFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblFuncionario, "Funcionário");
            // 
            // tabCliente
            // 
            this.tabCliente.AutoScroll = true;
            this.tabCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabCliente.Controls.Add(this.lblCliente);
            this.tabCliente.Location = new System.Drawing.Point(4, 34);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Size = new System.Drawing.Size(894, 473);
            this.tabCliente.TabIndex = 4;
            this.tabCliente.Text = "CLIENTE";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Black;
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblCliente.Location = new System.Drawing.Point(0, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(894, 473);
            this.lblCliente.TabIndex = 28;
            this.lblCliente.Text = resources.GetString("lblCliente.Text");
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCliente, "Cliente");
            // 
            // tabServico
            // 
            this.tabServico.AutoScroll = true;
            this.tabServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabServico.Controls.Add(this.lblServico);
            this.tabServico.Location = new System.Drawing.Point(4, 34);
            this.tabServico.Name = "tabServico";
            this.tabServico.Size = new System.Drawing.Size(894, 473);
            this.tabServico.TabIndex = 5;
            this.tabServico.Text = "SERVIÇO";
            // 
            // lblServico
            // 
            this.lblServico.BackColor = System.Drawing.Color.Black;
            this.lblServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServico.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblServico.Location = new System.Drawing.Point(0, 0);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(894, 473);
            this.lblServico.TabIndex = 29;
            this.lblServico.Text = resources.GetString("lblServico.Text");
            this.lblServico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblServico, "Serviço");
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.AutoScroll = true;
            this.tabRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.tabRelatorio.Controls.Add(this.lblRelatorio);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 34);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Size = new System.Drawing.Size(894, 473);
            this.tabRelatorio.TabIndex = 6;
            this.tabRelatorio.Text = "RELATORIO";
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.BackColor = System.Drawing.Color.Black;
            this.lblRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelatorio.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.lblRelatorio.Location = new System.Drawing.Point(0, 0);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(894, 473);
            this.lblRelatorio.TabIndex = 30;
            this.lblRelatorio.Text = resources.GetString("lblRelatorio.Text");
            this.lblRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblRelatorio, "Relatório");
            // 
            // tabReserva
            // 
            this.tabReserva.AutoScroll = true;
            this.tabReserva.BackColor = System.Drawing.Color.Black;
            this.tabReserva.Controls.Add(this.label1);
            this.tabReserva.Location = new System.Drawing.Point(4, 34);
            this.tabReserva.Name = "tabReserva";
            this.tabReserva.Size = new System.Drawing.Size(894, 473);
            this.tabReserva.TabIndex = 7;
            this.tabReserva.Text = "RESERVA";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(148)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 473);
            this.label1.TabIndex = 31;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "Reserva");
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1109, 15);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 45);
            this.btnFechar.TabIndex = 22;
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::barbeariaSrJack.Properties.Resources.logoB;
            this.pctLogo.Location = new System.Drawing.Point(23, 82);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(191, 165);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 32;
            this.pctLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.pctLogo, "Logo");
            // 
            // FrmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::barbeariaSrJack.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnlAjuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAjuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAjuda_Load);
            this.pnlAjuda.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.tabFuncionario.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabServico.ResumeLayout(false);
            this.tabRelatorio.ResumeLayout(false);
            this.tabReserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAjuda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TabPage tabFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabPage tabServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.TabPage tabReserva;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Button btnFecharAjuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}