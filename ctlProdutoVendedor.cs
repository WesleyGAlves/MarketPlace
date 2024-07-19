using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaControle;
using CamadaModelo;
using System.Data.SQLite;

namespace CamadaControle
{
    public class ctlProdutoVendedor
        {
        public bool Cadastrar(mdlProdutoVendedor _mdlProdutoVendedor)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "INSERT INTO PRODUTO (descricao, preco, imagem, status) VALUES (@Descricao, @Preco, @Imagem, @Status)";
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
                    throw new Exception("Erro ao cadastrar produto: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Alterar(mdlProdutoVendedor _mdlProdutoVendedor)
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
        public bool Excluir(mdlProdutoVendedor _mdlProdutoVendedor)
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
        public List<mdlProdutoVendedor> Consultar(mdlProdutoVendedor _mdlProdutoVendedor)
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
                            _mdlProdutoVendedor.descricao = rd.GetString(1);
                            _mdlProdutoVendedor.preco = rd.GetString(2);
                            _mdlProdutoVendedor.imagem = rd.GetString(3);
                            _mdlProdutoVendedor.status = rd.GetString(4);
                        }
                        return List<mdlProdutoVendedor>;
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
