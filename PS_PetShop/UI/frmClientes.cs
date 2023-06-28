using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Importar o projeto BLL
using BLL;
//Importar a classe dos correios
using Correios;

namespace UI
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instância - Carregar classe na memória.
            //Criar um objeto.
            //Armazenar a classe em uma variável
            ClientesDTO clientes = new ClientesDTO();

            clientes.numero = Convert.ToInt32(txtNumero.Text);
            MessageBox.Show(clientes.numero.ToString());
        }

        private void mskCEP_Leave(object sender, EventArgs e)
        {
            CorreiosApi correios = new CorreiosApi();

            try
            {                    
                var retornoCep = correios.consultaCEP(mskCEP.Text.Replace("-", ""));
                if (retornoCep != null)
                {
                    txtEndereco.Text = retornoCep.end;
                    txtUF.Text = retornoCep.uf;
                    txtCidade.Text = retornoCep.cidade;
                    txtBairro.Text = retornoCep.bairro;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString(), "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja sair?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
