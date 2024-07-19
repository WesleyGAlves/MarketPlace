using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using CamadaControle;
using CamadaModelo;

namespace MARKETPLACE
{
    public partial class Tela_Produtos : Form
    {
        public Tela_Produtos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            {
                mdlProdutoCliente _mdlProdutoCliente = new mdlProdutoCliente();
                ctlProdutoCliente _ctlProdutoCliente = new ctlProdutoCliente();

                try
                {

                    _mdlProdutoCliente.descricao = lblProduto1.Text;
                    _mdlProdutoCliente.preco = lblProduto1.Text;
                    _mdlProdutoCliente.imagem = lblProduto1.Text;
                    _mdlProdutoCliente.status = lblProduto1.Text;

                    bool retorno = _ctlProdutoCliente.Cadastrar(_mdlProdutoCliente);
                    if (retorno)
                    {
                        chcNike.Text = string.Empty;
                        chcAdidas.Text = string.Empty;
                        chcLacoste.Text = string.Empty;
                        chcCouro.Text = string.Empty;
                        MessageBox.Show("Dados do produto incluídos com sucesso!");
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
