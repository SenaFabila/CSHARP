using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class frmContasBancarias : Form
    {
        public frmContasBancarias()
        {
            InitializeComponent();
            rdoCorrente.Checked = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (rdoCorrente.Checked == true)
            {
                //Instância das classes - Criar um Objeto
                Corrente corrente = new Corrente();
                CadastrarCCorrente cadastrar = new CadastrarCCorrente();

                //Armazenar os dados do formulário
                corrente.agencia = Convert.ToInt32(txtAgencia.Text);
                corrente.conta = Convert.ToInt32(txtConta.Text);
                corrente.saldo = Convert.ToDecimal(txtValor.Text);
                corrente.tipo = "CC";
                corrente.limite = Convert.ToDecimal(cboLimite.Text);

                //Executar o método de cadastro
                cadastrar.CadastrarDados(corrente);

                //Mensagem para o usuário
                MessageBox.Show(corrente.mensagem, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Instância das classes - Criar um Objeto
                Poupanca poupanca = new Poupanca();
                CadastrarCPoupanca cadastrar = new CadastrarCPoupanca();

                //Armazenar os dados do formulário
                poupanca.agencia = Convert.ToInt32(txtAgencia.Text);
                poupanca.conta = Convert.ToInt32(txtConta.Text);
                poupanca.saldo = Convert.ToDecimal(txtValor.Text);
                poupanca.tipo = "CP";
                poupanca.taxa = Convert.ToDecimal(txtTaxa.Text.Replace(".",","));

                //Executar o método de cadastro
                cadastrar.CadastrarDados(poupanca);

                //Mensagem para o usuário
                MessageBox.Show(poupanca.mensagem, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarContas();
        }

        private void frmContasBancarias_Load(object sender, EventArgs e)
        {
           ListarContas();
        }

        public void ListarContas()
        {
            ListarContas listar = new ListarContas();
            dgvContas.DataSource = listar.ListarDadosContas();
        }

        private void dgvContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOperacaoConta.Text = dgvContas.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            //Intanciar a classe Saque
            Saque saque = new Saque();
            Conta conta = new Conta();

            conta.conta = Convert.ToInt32(txtOperacaoConta.Text);
            conta.valorOperacao = Convert.ToDecimal(txtOperacaoValor.Text);

            saque.RealizarSaque(conta);
            ListarContas();
        }

        private void btnDepósito_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito();
            Conta conta = new Conta();

            conta.conta = Convert.ToInt32(txtOperacaoConta.Text);
            conta.valorOperacao = Convert.ToDecimal(txtOperacaoValor.Text);

            deposito.RealizarDeposito(conta);
            ListarContas();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remover conta?","Aviso", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeletarConta deletar = new DeletarConta();
                Conta conta = new Conta();

                conta.conta = Convert.ToInt32(txtOperacaoConta.Text);

                deletar.RemoverConta(conta);
                ListarContas();
            }
        }
    }
}
