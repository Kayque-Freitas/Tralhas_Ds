namespace FormularioBasico
{
    partial class frmCliente
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
            this.lbldadosPessoais = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.cbbprofissao = new System.Windows.Forms.ComboBox();
            this.lblprofissao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldadosPessoais
            // 
            this.lbldadosPessoais.AutoSize = true;
            this.lbldadosPessoais.Location = new System.Drawing.Point(339, 75);
            this.lbldadosPessoais.Name = "lbldadosPessoais";
            this.lbldadosPessoais.Size = new System.Drawing.Size(83, 13);
            this.lbldadosPessoais.TabIndex = 0;
            this.lbldadosPessoais.Text = "Dados Pessoais";
            this.lbldadosPessoais.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(52, 74);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblprofissao);
            this.panel1.Controls.Add(this.cbbprofissao);
            this.panel1.Controls.Add(this.txtcpf);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.txtcod);
            this.panel1.Controls.Add(this.lblcpf);
            this.panel1.Controls.Add(this.lblcod);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Location = new System.Drawing.Point(237, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 174);
            this.panel1.TabIndex = 3;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(98, 103);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 6;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(98, 67);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 5;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(98, 32);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 4;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(60, 110);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(27, 13);
            this.lblcpf.TabIndex = 3;
            this.lblcpf.Text = "CPF";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(52, 39);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(40, 13);
            this.lblcod.TabIndex = 2;
            this.lblcod.Text = "Código";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(281, 334);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Fechar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(362, 334);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(440, 334);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // cbbprofissao
            // 
            this.cbbprofissao.FormattingEnabled = true;
            this.cbbprofissao.Items.AddRange(new object[] {
            "Analista Ecommerce",
            "Gerente",
            "Auxiliar",
            "Pedreiro",
            "Eletricista",
            "Pintor",
            "Manuteção",
            "Supervisor"});
            this.cbbprofissao.Location = new System.Drawing.Point(98, 134);
            this.cbbprofissao.Name = "cbbprofissao";
            this.cbbprofissao.Size = new System.Drawing.Size(121, 21);
            this.cbbprofissao.TabIndex = 10;
            // 
            // lblprofissao
            // 
            this.lblprofissao.AutoSize = true;
            this.lblprofissao.Location = new System.Drawing.Point(42, 142);
            this.lblprofissao.Name = "lblprofissao";
            this.lblprofissao.Size = new System.Drawing.Size(50, 13);
            this.lblprofissao.TabIndex = 11;
            this.lblprofissao.Text = "Profissão";
            this.lblprofissao.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lbldadosPessoais);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldadosPessoais;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblprofissao;
        private System.Windows.Forms.ComboBox cbbprofissao;
    }
}