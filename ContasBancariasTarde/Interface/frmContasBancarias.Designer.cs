
namespace Interface
{
    partial class frmContasBancarias
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
            this.grpCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdoPoupanca = new System.Windows.Forms.RadioButton();
            this.rdoCorrente = new System.Windows.Forms.RadioButton();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.cboLimite = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.grpContas = new System.Windows.Forms.GroupBox();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.grpOperacao = new System.Windows.Forms.GroupBox();
            this.txtOperacaoValor = new System.Windows.Forms.TextBox();
            this.txtOperacaoConta = new System.Windows.Forms.TextBox();
            this.lblOperacaValor = new System.Windows.Forms.Label();
            this.lblOperacaoConta = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDepósito = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.grpCadastro.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.grpContas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.grpOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.btnCadastrar);
            this.grpCadastro.Controls.Add(this.grpTipo);
            this.grpCadastro.Controls.Add(this.txtTaxa);
            this.grpCadastro.Controls.Add(this.cboLimite);
            this.grpCadastro.Controls.Add(this.txtValor);
            this.grpCadastro.Controls.Add(this.txtConta);
            this.grpCadastro.Controls.Add(this.txtAgencia);
            this.grpCadastro.Controls.Add(this.lblTaxa);
            this.grpCadastro.Controls.Add(this.lblLimite);
            this.grpCadastro.Controls.Add(this.lblValor);
            this.grpCadastro.Controls.Add(this.lblConta);
            this.grpCadastro.Controls.Add(this.lblAgencia);
            this.grpCadastro.Location = new System.Drawing.Point(39, 25);
            this.grpCadastro.Name = "grpCadastro";
            this.grpCadastro.Size = new System.Drawing.Size(387, 198);
            this.grpCadastro.TabIndex = 0;
            this.grpCadastro.TabStop = false;
            this.grpCadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(236, 125);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdoPoupanca);
            this.grpTipo.Controls.Add(this.rdoCorrente);
            this.grpTipo.Location = new System.Drawing.Point(209, 25);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(142, 94);
            this.grpTipo.TabIndex = 10;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rdoPoupanca
            // 
            this.rdoPoupanca.AutoSize = true;
            this.rdoPoupanca.Location = new System.Drawing.Point(6, 55);
            this.rdoPoupanca.Name = "rdoPoupanca";
            this.rdoPoupanca.Size = new System.Drawing.Size(105, 17);
            this.rdoPoupanca.TabIndex = 1;
            this.rdoPoupanca.TabStop = true;
            this.rdoPoupanca.Text = "Conta Poupança";
            this.rdoPoupanca.UseVisualStyleBackColor = true;
            // 
            // rdoCorrente
            // 
            this.rdoCorrente.AutoSize = true;
            this.rdoCorrente.Location = new System.Drawing.Point(6, 28);
            this.rdoCorrente.Name = "rdoCorrente";
            this.rdoCorrente.Size = new System.Drawing.Size(96, 17);
            this.rdoCorrente.TabIndex = 0;
            this.rdoCorrente.TabStop = true;
            this.rdoCorrente.Text = "Conta Corrente";
            this.rdoCorrente.UseVisualStyleBackColor = true;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(92, 134);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(100, 20);
            this.txtTaxa.TabIndex = 9;
            // 
            // cboLimite
            // 
            this.cboLimite.FormattingEnabled = true;
            this.cboLimite.Location = new System.Drawing.Point(92, 106);
            this.cboLimite.Name = "cboLimite";
            this.cboLimite.Size = new System.Drawing.Size(100, 21);
            this.cboLimite.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(92, 79);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(92, 52);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 6;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(92, 25);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtAgencia.TabIndex = 5;
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Location = new System.Drawing.Point(35, 137);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(42, 13);
            this.lblTaxa.TabIndex = 4;
            this.lblTaxa.Text = "Taxa %";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(35, 109);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(51, 13);
            this.lblLimite.TabIndex = 3;
            this.lblLimite.Text = "Limite R$";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(35, 82);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(48, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor R$";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(35, 55);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(35, 13);
            this.lblConta.TabIndex = 1;
            this.lblConta.Text = "Conta";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(35, 28);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(46, 13);
            this.lblAgencia.TabIndex = 0;
            this.lblAgencia.Text = "Agência";
            // 
            // grpContas
            // 
            this.grpContas.Controls.Add(this.dgvContas);
            this.grpContas.Location = new System.Drawing.Point(39, 230);
            this.grpContas.Name = "grpContas";
            this.grpContas.Size = new System.Drawing.Size(387, 208);
            this.grpContas.TabIndex = 1;
            this.grpContas.TabStop = false;
            this.grpContas.Text = "Contas";
            // 
            // dgvContas
            // 
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Location = new System.Drawing.Point(7, 20);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.Size = new System.Drawing.Size(374, 182);
            this.dgvContas.TabIndex = 0;
            this.dgvContas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContas_CellClick);
            // 
            // grpOperacao
            // 
            this.grpOperacao.Controls.Add(this.btnRemover);
            this.grpOperacao.Controls.Add(this.btnDepósito);
            this.grpOperacao.Controls.Add(this.btnSaque);
            this.grpOperacao.Controls.Add(this.txtOperacaoValor);
            this.grpOperacao.Controls.Add(this.lblOperacaoConta);
            this.grpOperacao.Controls.Add(this.lblOperacaValor);
            this.grpOperacao.Controls.Add(this.txtOperacaoConta);
            this.grpOperacao.Location = new System.Drawing.Point(39, 444);
            this.grpOperacao.Name = "grpOperacao";
            this.grpOperacao.Size = new System.Drawing.Size(387, 100);
            this.grpOperacao.TabIndex = 2;
            this.grpOperacao.TabStop = false;
            this.grpOperacao.Text = "Operação Saque/Depósito";
            // 
            // txtOperacaoValor
            // 
            this.txtOperacaoValor.Location = new System.Drawing.Point(72, 51);
            this.txtOperacaoValor.Name = "txtOperacaoValor";
            this.txtOperacaoValor.Size = new System.Drawing.Size(100, 20);
            this.txtOperacaoValor.TabIndex = 15;
            // 
            // txtOperacaoConta
            // 
            this.txtOperacaoConta.Location = new System.Drawing.Point(72, 24);
            this.txtOperacaoConta.Name = "txtOperacaoConta";
            this.txtOperacaoConta.Size = new System.Drawing.Size(100, 20);
            this.txtOperacaoConta.TabIndex = 14;
            // 
            // lblOperacaValor
            // 
            this.lblOperacaValor.AutoSize = true;
            this.lblOperacaValor.Location = new System.Drawing.Point(15, 54);
            this.lblOperacaValor.Name = "lblOperacaValor";
            this.lblOperacaValor.Size = new System.Drawing.Size(48, 13);
            this.lblOperacaValor.TabIndex = 13;
            this.lblOperacaValor.Text = "Valor R$";
            // 
            // lblOperacaoConta
            // 
            this.lblOperacaoConta.AutoSize = true;
            this.lblOperacaoConta.Location = new System.Drawing.Point(15, 27);
            this.lblOperacaoConta.Name = "lblOperacaoConta";
            this.lblOperacaoConta.Size = new System.Drawing.Size(35, 13);
            this.lblOperacaoConta.TabIndex = 12;
            this.lblOperacaoConta.Text = "Conta";
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(191, 21);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 16;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDepósito
            // 
            this.btnDepósito.Location = new System.Drawing.Point(191, 50);
            this.btnDepósito.Name = "btnDepósito";
            this.btnDepósito.Size = new System.Drawing.Size(75, 23);
            this.btnDepósito.TabIndex = 17;
            this.btnDepósito.Text = "Depósito";
            this.btnDepósito.UseVisualStyleBackColor = true;
            this.btnDepósito.Click += new System.EventHandler(this.btnDepósito_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(290, 22);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 49);
            this.btnRemover.TabIndex = 18;
            this.btnRemover.Text = "Remover Conta";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmContasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 553);
            this.Controls.Add(this.grpOperacao);
            this.Controls.Add(this.grpContas);
            this.Controls.Add(this.grpCadastro);
            this.Name = "frmContasBancarias";
            this.Text = "Contas Bancárias";
            this.Load += new System.EventHandler(this.frmContasBancarias_Load);
            this.grpCadastro.ResumeLayout(false);
            this.grpCadastro.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpContas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.grpOperacao.ResumeLayout(false);
            this.grpOperacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdoPoupanca;
        private System.Windows.Forms.RadioButton rdoCorrente;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.ComboBox cboLimite;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.GroupBox grpContas;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.GroupBox grpOperacao;
        private System.Windows.Forms.Button btnDepósito;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.TextBox txtOperacaoValor;
        private System.Windows.Forms.Label lblOperacaoConta;
        private System.Windows.Forms.Label lblOperacaValor;
        private System.Windows.Forms.TextBox txtOperacaoConta;
        private System.Windows.Forms.Button btnRemover;
    }
}

