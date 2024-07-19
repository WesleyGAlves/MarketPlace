using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaControle;
using CamadaModelo;

namespace MARKETPLACE
{
    public partial class Tela_login_Vendedor : Form
    {
        public Tela_login_Vendedor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComissao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginVendedor_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarVendedor_Click(object sender, EventArgs e)
        {
            mdlVendedor _mdlVendedor = new mdlVendedor();
            ctlVendedor _ctlVendedor = new ctlVendedor();

            try
            {

                _mdlVendedor.razaosocial = txtRazaoSocial.Text;
                _mdlVendedor.nomefantasia = txtNomeFantasia.Text;
                _mdlVendedor.emailvendedor = txtEmailVendedor.Text;
                _mdlVendedor.senhavendedor = txtSenhaVendedor.Text;
                _mdlVendedor.cnpj = txtCnpj.Text;
                _mdlVendedor.comissao = txtComissao.Text;

                bool retorno = _ctlVendedor.Cadastrar(_mdlVendedor);
                if (retorno)
                {
                    txtRazaoSocial.Text = string.Empty;
                    txtNomeFantasia.Text = string.Empty;
                    txtEmailVendedor.Text = string.Empty;
                    txtSenhaVendedor.Text = string.Empty;
                    txtCnpj.Text = string.Empty;
                    txtComissao.Text = string.Empty;
                    txtRazaoSocial.Focus();
                    MessageBox.Show("Dados do vendedor incluídos com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar a inclusão.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
