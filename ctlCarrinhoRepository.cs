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
    class ctlCarrinhoRepository
    {
        public bool Adicionar(mdlCarrinhoRepository _mdlCarrinhoRepository)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "INSERT INTO CARRINHO (dataPedido, valorTotal, statusPedido, cliente) VALUES (@DataPedido, @ValorTotal, @StatusPedido, @Cliente)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DataPedido", "dataPedido");
                        command.Parameters.AddWithValue("@ValorTotal", "valorTotal");
                        command.Parameters.AddWithValue("@StatusPedido", "statusPedido");
                        command.Parameters.AddWithValue("@Cliente", "cliente");

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
                    throw new Exception("Erro ao cadastrar produto no carrinho: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Alterar(mdlCarrinhoRepository _mdlCarrinhoRepository)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "UPTADE CARRINHO set dataPedido = @DataPedido where valorTotal = @ValorTotal where statusPedido = @StatusPedido where cliente = @Cliente";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DataPedido", "dataPedido");
                        command.Parameters.AddWithValue("@ValorTotal", "valorTotal");
                        command.Parameters.AddWithValue("@StatusPedido", "statusPedido");
                        command.Parameters.AddWithValue("@Cliente", "cliente");

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
                    throw new Exception("Erro ao alterar produto no carrinho: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Excluir(mdlCarrinhoRepository _mdlCarrinhoRepository)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "DELETE FROM CARRINHO dataPedido = @DataPedido where valorTotal = @ValorTotal where statusPedido = @StatusPedido where cliente = @Cliente";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DataPedido", "dataPedido");
                        command.Parameters.AddWithValue("@ValorTotal", "valorTotal");
                        command.Parameters.AddWithValue("@StatusPedido", "statusPedido");
                        command.Parameters.AddWithValue("@Cliente", "cliente");

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
                    throw new Exception("Erro ao excluir produto do carrinho: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool ObterPorId(mdlCarrinhoRepository _mdlCarrinhoRepository)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "SELECT INTO CARRINHO (dataPedido, valorTotal, statusPedido, cliente) VALUES (@DataPedido, @ValorTotal, @StatusPedido, @Cliente)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", "id");

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
                    throw new Exception("Erro ao selecionar o produto por id: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public List<mdlCarrinhoRepository> ObterTodos(mdlCarrinhoRepository _mdlCarrinhoRepository)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "SELECT * FROM CARRINHO WITH(NOLOCK) WHERE dataPedido = @DataPedido where valorTotal = @ValorTotal where statusPedido = @StatusPedido where cliente = @Cliente";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DataPedido", "dataPedido");
                        command.Parameters.AddWithValue("@ValorTotal", "valorTotal");
                        command.Parameters.AddWithValue("@StatusPedido", "statusPedido");
                        command.Parameters.AddWithValue("@Cliente", "cliente");

                        SQLiteDataReader rd = command.ExecuteReader();

                        while (rd.Read())
                        {
                            _mdlCarrinhoRepository.dataPedido = rd.GetString(1);
                            _mdlCarrinhoRepository.valorTotal = rd.GetString(2);
                            _mdlCarrinhoRepository.statusPedido = rd.GetString(3);
                            _mdlCarrinhoRepository.cliente = rd.GetString(4);
                        }
                        return List<mdlCarrinhoRepository>;
                    }
                }
                catch (Exception ex)
                {
                    connection.Close();
                    throw new Exception("Erro ao consultar dados do produto no carrinho: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
    }
}

