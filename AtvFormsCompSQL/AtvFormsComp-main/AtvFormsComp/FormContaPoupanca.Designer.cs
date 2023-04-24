namespace AtvFormsComp
{
    partial class FormContaPoupanca
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
            this.ctnClearData = new System.Windows.Forms.Button();
            this.btnSaveContaPoupanca = new System.Windows.Forms.Button();
            this.dgvContaPoupanca = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipoMoedaDescricao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBonusDescricao = new System.Windows.Forms.TextBox();
            this.txtTipoContaDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaPoupanca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctnClearData
            // 
            this.ctnClearData.Location = new System.Drawing.Point(100, 202);
            this.ctnClearData.Name = "ctnClearData";
            this.ctnClearData.Size = new System.Drawing.Size(85, 28);
            this.ctnClearData.TabIndex = 24;
            this.ctnClearData.Text = "Limpar";
            this.ctnClearData.UseVisualStyleBackColor = true;
            this.ctnClearData.Click += new System.EventHandler(this.ctnClearData_Click);
            // 
            // btnSaveContaPoupanca
            // 
            this.btnSaveContaPoupanca.Location = new System.Drawing.Point(10, 202);
            this.btnSaveContaPoupanca.Name = "btnSaveContaPoupanca";
            this.btnSaveContaPoupanca.Size = new System.Drawing.Size(85, 28);
            this.btnSaveContaPoupanca.TabIndex = 23;
            this.btnSaveContaPoupanca.Text = "Salvar";
            this.btnSaveContaPoupanca.UseVisualStyleBackColor = true;
            this.btnSaveContaPoupanca.Click += new System.EventHandler(this.btnSaveContaPoupanca_Click);
            // 
            // dgvContaPoupanca
            // 
            this.dgvContaPoupanca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContaPoupanca.Location = new System.Drawing.Point(10, 236);
            this.dgvContaPoupanca.Name = "dgvContaPoupanca";
            this.dgvContaPoupanca.RowHeadersWidth = 51;
            this.dgvContaPoupanca.Size = new System.Drawing.Size(752, 212);
            this.dgvContaPoupanca.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taxa Juros";
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(75, 118);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaJuros.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtd Tempo";
            // 
            // txtQtdTempo
            // 
            this.txtQtdTempo.Location = new System.Drawing.Point(75, 91);
            this.txtQtdTempo.Name = "txtQtdTempo";
            this.txtQtdTempo.Size = new System.Drawing.Size(100, 20);
            this.txtQtdTempo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(75, 38);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(75, 64);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Descrição";
            // 
            // txtTipoMoedaDescricao
            // 
            this.txtTipoMoedaDescricao.Location = new System.Drawing.Point(574, 30);
            this.txtTipoMoedaDescricao.Name = "txtTipoMoedaDescricao";
            this.txtTipoMoedaDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtTipoMoedaDescricao.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Descrição";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBonusDescricao);
            this.groupBox1.Location = new System.Drawing.Point(273, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(182, 58);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bonus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição";
            // 
            // txtBonusDescricao
            // 
            this.txtBonusDescricao.Location = new System.Drawing.Point(73, 23);
            this.txtBonusDescricao.Name = "txtBonusDescricao";
            this.txtBonusDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtBonusDescricao.TabIndex = 8;
            // 
            // txtTipoContaDescricao
            // 
            this.txtTipoContaDescricao.Location = new System.Drawing.Point(335, 34);
            this.txtTipoContaDescricao.Name = "txtTipoContaDescricao";
            this.txtTipoContaDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtTipoContaDescricao.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dados Contas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tipo Contas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tipo Moedas";
            // 
            // FormContaPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTipoMoedaDescricao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoContaDescricao);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdTempo);
            this.Controls.Add(this.ctnClearData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveContaPoupanca);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dgvContaPoupanca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormContaPoupanca";
            this.Text = "Tela Conta Poupança";
            this.Load += new System.EventHandler(this.FormContaPoupanca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContaPoupanca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctnClearData;
        private System.Windows.Forms.Button btnSaveContaPoupanca;
        private System.Windows.Forms.DataGridView dgvContaPoupanca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdTempo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipoMoedaDescricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTipoContaDescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBonusDescricao;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}