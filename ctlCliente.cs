using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaModelo;
using System.Data.SQLite;

namespace CamadaControle
{
    public class ctlCliente
    {
        public bool Cadastrar(mdlCliente _mdlCliente)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "INSERT INTO CLIENTE (nome, cpf, email, senha, endereco, cep) VALUES (@Nome, @Cpf, @Email, @Senha, @Endereco, @Cep)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", "nome");
                        command.Parameters.AddWithValue("@Cpf", "cpf");
                        command.Parameters.AddWithValue("@Email", "email");
                        command.Parameters.AddWithValue("@Senha", "senha");
                        command.Parameters.AddWithValue("@Endereco", "endereco");
                        command.Parameters.AddWithValue("@Cep", "cep");

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
                    throw new Exception("Erro ao cadastrar cliente: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Alterar(mdlCliente _mdlCliente)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "UPTADE CLIENTE set nome = @Nome where cpf = @Cpf where email = @Email where senha = @Senha where endereco = @Endereco where cep = @Cep";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", "nome");
                        command.Parameters.AddWithValue("@Cpf", "cpf");
                        command.Parameters.AddWithValue("@Email", "email");
                        command.Parameters.AddWithValue("@Senha", "senha");
                        command.Parameters.AddWithValue("@Endereco", "endereco");
                        command.Parameters.AddWithValue("@Cep", "cep");

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
                    throw new Exception("Erro ao alterar aluno: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public bool Excluir(mdlCliente _mdlCliente)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

                try
                {
                    connection.Open();

                    string query = "DELETE FROM CLIENTE nome = @Nome where cpf = @Cpf where email = @Email where senha = @Senha where endereco = @Endereco where cep = @Cep";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", "nome");
                        command.Parameters.AddWithValue("@Cpf", "cpf");
                        command.Parameters.AddWithValue("@Email", "email");
                        command.Parameters.AddWithValue("@Senha", "senha");
                        command.Parameters.AddWithValue("@Endereco", "endereco");
                        command.Parameters.AddWithValue("@Cep", "cep");

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
                    throw new Exception("Erro ao excluir aluno: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
        }
        public List<mdlCliente> Consultar(mdlCliente _mdlCliente)
        {
            string connectionString = "Data Source=C:/ProgramFiles/SQLiteStudio/PIMVIII.sql;Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))

            try
            {
                connection.Open();

                string query = "SELECT * FROM CLIENTE WITH(NOLOCK) WHERE cpf = @Cpf";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cpf", "cpf");

                        SQLiteDataReader rd = command.ExecuteReader();

                        while (rd.Read())
                        {
                            _mdlCliente.nome = rd.GetString(1);
                            _mdlCliente.cpf = rd.GetString(2);
                            _mdlCliente.email = rd.GetString(3);
                            _mdlCliente.senha = rd.GetString(4);
                            _mdlCliente.endereco = rd.GetString(5);
                            _mdlCliente.cep = rd.GetString(6);
                        }
                        return List<mdlCliente>;
                    }
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception("Erro ao consultar dados do aluno: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
