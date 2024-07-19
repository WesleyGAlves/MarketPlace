using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelo;
using CamadaControle;
using System.Data.SQLite;

namespace CamadaControle
{
    public class ctlProdutoCliente
    {
        public bool Cadastrar(mdlProdutoCliente _mdlProdutoCliente)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "INSERT INTO CARRINHO (datapedido, valortotal) VALUES (@DataPedido, @ValorTotal)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descricao", "descricao");
                        command.Parameters.AddWithValue("@Preco", "preco");

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
                    throw new Exception("Erro ao adicionar produto: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Alterar(mdlProdutoCliente _mdlProdutoCliente)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "UPTADE PRODUTO set descricao = @Descricao where preco = @Preco where imagem = @Imagem where status = @Status";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descricao", "descricao");
                        command.Parameters.AddWithValue("@Preco", "preco");
                        command.Parameters.AddWithValue("@Imagem", "imagem");
                        command.Parameters.AddWithValue("@Status", "status");

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
                    throw new Exception("Erro ao alterar produto: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Excluir(mdlProdutoCliente _mdlProdutoCliente)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "DELETE FROM PRODUTO descricao = @Descricao where preco = @Preco where imagem = @Imagem where status = @Status";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descricao", "descricao");
                        command.Parameters.AddWithValue("@Preco", "preco");
                        command.Parameters.AddWithValue("@Imagem", "imagem");
                        command.Parameters.AddWithValue("@Status", "status");

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
                    throw new Exception("Erro ao excluir produto: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public List<mdlProdutoCliente> Consultar(mdlProdutoCliente _mdlProdutoCliente)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "SELECT * FROM PRODUTO WITH(NOLOCK) WHERE descricao = @Descricao";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descricao", "descricao");

                        SQLiteDataReader rd = command.ExecuteReader();

                        while (rd.Read())
                        {
                            _mdlProdutoCliente.descricao = rd.GetString(1);
                            _mdlProdutoCliente.preco = rd.GetString(2);
                            _mdlProdutoCliente.imagem = rd.GetString(3);
                            _mdlProdutoCliente.status = rd.GetString(4);
                        }
                        return List<mdlProdutoCliente>;
                    }
                }
                catch (Exception ex)
                {
                    connection.Close();
                    throw new Exception("Erro ao consultar dados do produto: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
    }
}
