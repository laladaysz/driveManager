using DriveManager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveManager.DAO
{
    public class MotoristaDAO
    {
        private string connectionString = "server=localhost;database=EasyPark;user=root;password=";

        public void cadastrarMotorista(Motorista motorista)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Motoristas (nome, email, telefone) VALUES (@Nome, @Email, @Telefone)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", motorista.nome);
                cmd.Parameters.AddWithValue("@Email", motorista.email);
                cmd.Parameters.AddWithValue("@Telefone", motorista.telefone);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Motorista BuscarMotoristaPorId(long id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Motoristas WHERE id_motorista = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Motorista motorista = new Motorista()
                    {
                        id_motorista = (long)reader["id_motorista"],
                        nome = (string)reader["nome"],
                        email = (string)reader["email"],
                        telefone = (string)reader["telefone"],
                        
                    };
                    conn.Close();
                    return motorista;
                }

                return null;
            }
        }
        public List<Motorista> GetAllMotorista()
        {
            List<Motorista> motoristas = new List<Motorista>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Motoristas";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Motorista motorista = new Motorista
                    {
                        id_motorista = (long)reader["id_motorista"],
                        nome = (string)reader["nome"],
                        email = (string)reader["email"],
                        telefone = (string)reader["telefone"],

                    };

                    motoristas.Add(motorista);
                }
                conn.Close();
            }
            return motoristas;
        }


        public void ExcluirMotorista(long id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string deleteVeiculosQuery = "DELETE FROM Veiculos WHERE id_motorista = @IdMotorista";
                MySqlCommand deleteVeiculosCmd = new MySqlCommand(deleteVeiculosQuery, conn);
                deleteVeiculosCmd.Parameters.AddWithValue("@IdMotorista", id);
                deleteVeiculosCmd.ExecuteNonQuery();

                string query = "DELETE FROM Motoristas WHERE id_motorista = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


       


        public string BuscarNomeMotoristaPorId(long motoristaId)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT nome FROM Motoristas WHERE id_motorista = @MotoristaId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MotoristaId", motoristaId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["nome"].ToString();
                    }
                }
            }

            return null;
        }


        

    }
}
