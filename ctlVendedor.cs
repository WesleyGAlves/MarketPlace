using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelo;
using System.Data.SQLite;

namespace CamadaControle
{
    public class ctlVendedor
    {
        public bool Cadastrar(mdlVendedor _mdlVendedor)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "INSERT INTO VENDEDOR (razao_social, nome_fantasia, emailvendedor, senhavendedor, cnpj, comissao) VALUES (@RazaoSocial, @NomeFantasia, @EmailVendedor, @SenhaVendedor, @Cnpj, @Comissao)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RazaoSocial", "razao_social");
                        command.Parameters.AddWithValue("@NomeFantasia", "nome_fantasia");
                        command.Parameters.AddWithValue("@EmailVendedor", "emailvendedor");
                        command.Parameters.AddWithValue("@SenhaVendedor", "senhavendedor");
                        command.Parameters.AddWithValue("@Cnpj", "cnpj");
                        command.Parameters.AddWithValue("@Comissao", "comissao");

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
                    throw new Exception("Erro ao cadastrar vendedor: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Alterar(mdlVendedor _mdlVendedor)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "UPTADE VENDEDOR set razao_social = @RazaoSocial where nome_fantasia = @NomeFantasia where emailvendedor = @EmailVendedor where senhavendedor = @SenhaVendedor where cnpj = @Cnpj where comissao = @Comissao";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RazaoSocial", "razao_social");
                        command.Parameters.AddWithValue("@NomeFantasia", "nome_fantasia");
                        command.Parameters.AddWithValue("@EmailVendedor", "emailvendedor");
                        command.Parameters.AddWithValue("@SenhaVendedor", "senhavendedor");
                        command.Parameters.AddWithValue("@Cnpj", "cnpj");
                        command.Parameters.AddWithValue("@Comissao", "comissao");

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
                    throw new Exception("Erro ao alterar vendedor: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Excluir(mdlVendedor _mdlVendedor)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "DELETE FROM VENDEDOR razao_social = @RazaoSocial where nome_fantasia = @NomeFantasia where emailvendedor = @EmailVendedor where senhavendedor = @SenhaVendedor where cnpj = @Cnpj where comissao = @Comissao";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RazaoSocial", "razao_social");
                        command.Parameters.AddWithValue("@NomeFantasia", "nome_fantasia");
                        command.Parameters.AddWithValue("@EmailVendedor", "emailvendedor");
                        command.Parameters.AddWithValue("@SenhaVendedor", "senhavendedor");
                        command.Parameters.AddWithValue("@Cnpj", "cnpj");
                        command.Parameters.AddWithValue("@Comissao", "comissao");

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
                    throw new Exception("Erro ao excluir vendedor: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public List<mdlVendedor> Consultar(mdlVendedor _mdlVendedor)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "SELECT * FROM VENDEDOR WITH(NOLOCK) WHERE nome_fantasia = @NomeFantasia";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NomeFantasia", "nome_fantasia");

                        SQLiteDataReader rd = command.ExecuteReader();

                        while (rd.Read())
                        {
                            _mdlVendedor.razaosocial = rd.GetString(1);
                            _mdlVendedor.nomefantasia = rd.GetString(2);
                            _mdlVendedor.emailvendedor = rd.GetString(3);
                            _mdlVendedor.senhavendedor = rd.GetString(4);
                            _mdlVendedor.cnpj = rd.GetString(5);
                            _mdlVendedor.comissao = rd.GetString(6);
                        }
                        return List<mdlVendedor>;
                    }
                }
                catch (Exception ex)
                {
                    connection.Close();
                    throw new Exception("Erro ao consultar dados do vendedor: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
    }
}
