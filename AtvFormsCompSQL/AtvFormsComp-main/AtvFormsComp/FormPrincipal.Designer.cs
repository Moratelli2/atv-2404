namespace AtvFormsComp
{
    partial class fmrPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnContaClientes = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPoupanca = new System.Windows.Forms.Button();
            this.btnCorrente = new System.Windows.Forms.Button();
            this.Contas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(141, 88);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(152, 23);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Tela Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnContaClientes
            // 
            this.btnContaClientes.Location = new System.Drawing.Point(141, 117);
            this.btnContaClientes.Name = "btnContaClientes";
            this.btnContaClientes.Size = new System.Drawing.Size(152, 23);
            this.btnContaClientes.TabIndex = 2;
            this.btnContaClientes.Text = "Tela Conta Clientes";
            this.btnContaClientes.UseVisualStyleBackColor = true;
            this.btnContaClientes.Click += new System.EventHandler(this.btnContaClientes_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(90, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 31);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Sistema de Registro";
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.Location = new System.Drawing.Point(141, 167);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(152, 23);
            this.btnPoupanca.TabIndex = 3;
            this.btnPoupanca.Text = "Tela Conta Poupança";
            this.btnPoupanca.UseVisualStyleBackColor = true;
            this.btnPoupanca.Click += new System.EventHandler(this.btnPoupanca_Click);
            // 
            // btnCorrente
            // 
            this.btnCorrente.Location = new System.Drawing.Point(141, 207);
            this.btnCorrente.Name = "btnCorrente";
            this.btnCorrente.Size = new System.Drawing.Size(152, 23);
            this.btnCorrente.TabIndex = 4;
            this.btnCorrente.Text = "Tela Conta Corrente";
            this.btnCorrente.UseVisualStyleBackColor = true;
            this.btnCorrente.Click += new System.EventHandler(this.btnCorrente_Click);
            // 
            // Contas
            // 
            this.Contas.AutoSize = true;
            this.Contas.Location = new System.Drawing.Point(138, 148);
            this.Contas.Name = "Contas";
            this.Contas.Size = new System.Drawing.Size(40, 13);
            this.Contas.TabIndex = 7;
            this.Contas.Text = "Contas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pessoas";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContaClientes);
            this.Controls.Add(this.Contas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCorrente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnPoupanca);
            this.Name = "fmrPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnContaClientes;
        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.Button btnCorrente;
        private System.Windows.Forms.Label Contas;
        private System.Windows.Forms.Label label1;
    }
}

