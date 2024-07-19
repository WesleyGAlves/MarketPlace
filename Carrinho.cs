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
using System.Data.SQLite;

namespace MARKETPLACE
{
    public partial class Carrinho : Form
    {
        public Carrinho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Excluir(mdlProdutoCliente _mdlProdutoCliente)
            {
                string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM ITEM_CARRINHO quantidade = @Quantidade where total = @Total";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Quantidade", "quantidade");
                            command.Parameters.AddWithValue("@Total", "total");

                            if (command.ExecuteNonQuery() > 0)
                            {
                                connection.Close();
                                return true;
                            }
                            else
                            {
                                connection.Close();
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        throw new Exception("Erro ao excluir item do carrinho: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
            }
        }
    }
}
