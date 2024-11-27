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
        private string connectionString = "server=localhost;database=EasyPark;user=root;password=";

        public void CadastrarUsuario(Usuario usuario)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Usuario (nome, login, senha, role) VALUES (@Nome, @Login, @Senha, @Role)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", usuario.nome);
                cmd.Parameters.AddWithValue("@Login", usuario.login);
                cmd.Parameters.AddWithValue("@Senha", usuario.senha);
                cmd.Parameters.AddWithValue("@Role", usuario.role);
               
                cmd.ExecuteNonQuery();
            }
        }

       

      

        public Usuario AutenticarUsuario(string login)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Usuario WHERE login = @Login";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Login", login);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        id_usuario = (long)reader["id_usuario"],  
                        login = (string)reader["login"],
                        senha = (string)reader["senha"],
                        nome = (string)reader["nome"],
                        role = (string)reader["role"]
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
                        id_usuario = (long)reader["idUsuario"],
                        nome = (string)reader["nome"],
                        login = (string)reader["login"],
                        senha = (string)reader["senha"],
                        role = (string)reader["role"]
                    };

                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

     
    }
}
