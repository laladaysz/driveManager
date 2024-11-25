using DriveManager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveManager.DAO
{
    public class UsuarioDAO
    {
        private string connectionString = "server=localhost;database=parking_lot;user=root;password=";

        public void CadastrarUsuario(Usuario usuario)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Usuario (Nome, Email, Senha, Role, Ativado) VALUES (@Nome, @Email, @Senha, @Role, @Ativado)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@Role", usuario.Role);
                cmd.Parameters.AddWithValue("@Ativado", usuario.Ativado);
                cmd.ExecuteNonQuery();
            }
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Usuario WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Id = (int)reader["Id"],
                        Nome = (string)reader["Nome"],
                        Email = (string)reader["Email"],
                        Senha = (string)reader["Senha"],
                        Role = (string)reader["Role"],
                        Ativado = (bool)reader["Ativado"]
                    };
                    return usuario;
                }
            }
            return null;
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Usuario SET Nome = @Nome, Email = @Email, Senha = @Senha, Role = @Role, Ativado = @Ativado WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@Role", usuario.Role);
                cmd.Parameters.AddWithValue("@Ativado", usuario.Ativado);
                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public Usuario AutenticarUsuario(string email, string senha)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Usuario WHERE Email = @Email AND Senha = @Senha";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    bool ativado = (bool)reader["Ativado"];
                    if (!ativado)
                    {
                        throw new Exception("Conta desativada.");
                    }

                    Usuario usuario = new Usuario
                    {
                        Id = (int)reader["Id"],
                        Nome = (string)reader["Nome"],
                        Email = (string)reader["Email"],
                        Senha = (string)reader["Senha"],
                        Role = (string)reader["Role"],
                        Ativado = (bool)reader["Ativado"]
                    };
                    return usuario;
                }
            }
            return null;
        }

        public List<Usuario> GetAllUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Usuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        Id = (int)reader["Id"],
                        Nome = (string)reader["Nome"],
                        Email = (string)reader["Email"],
                        Senha = (string)reader["Senha"],
                        Role = (string)reader["Role"],
                        Ativado = (bool)reader["Ativado"]
                    };

                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

        public void ExcluirUsuario(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Usuario WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void TornarAdmin(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Usuario SET Role = @Role where Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Role", "ADMIN");
                cmd.ExecuteNonQuery();
            }
        }

        public void Desativar(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Usuario SET Ativado = false where Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
