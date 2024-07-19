using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaModelo;
using CamadaControle;

namespace MARKETPLACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            mdlCliente _mdlCliente = new mdlCliente();
            ctlCliente _ctlCliente = new ctlCliente();

            try
            {

                _mdlCliente.nome = txtNome.Text;
                _mdlCliente.senha = txtSenha.Text;
                _mdlCliente.cpf = txtCpf.Text;
                _mdlCliente.email = txtEmail.Text;
                _mdlCliente.endereco = txtEndereco.Text;
                _mdlCliente.cep = txtCep.Text;

                bool retorno = _ctlCliente.Cadastrar(_mdlCliente);
                if (retorno)
                {
                    txtNome.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                    txtCpf.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtCep.Text = string.Empty;
                    txtNome.Focus();
                    MessageBox.Show("Dados do aluno incluídos com sucesso!");
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
