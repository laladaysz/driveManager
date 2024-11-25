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
        private string connectionString = "server=localhost;database=parking_lot;user=root;password=";

        public void cadastrarMotorista(Motorista motorista)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Motorista (Nome, Email, Telefone, Ativo) VALUES (@Nome, @Email, @Telefone, @Ativo)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", motorista.Nome);
                cmd.Parameters.AddWithValue("@Email", motorista.Email);
                cmd.Parameters.AddWithValue("@Telefone", motorista.Telefone);
                cmd.Parameters.AddWithValue("@Ativo", motorista.Ativo);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Motorista BuscarMotoristaPorId(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Motorista WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Motorista motorista = new Motorista()
                    {
                        Id = (int)reader["Id"],
                        Nome = (string)reader["Nome"],
                        Email = (string)reader["Email"],
                        Telefone = (string)reader["Telefone"],
                        Ativo = (bool)reader["Ativo"]
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
                string query = "SELECT * FROM Motorista";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Motorista motorista = new Motorista
                    {
                        Id = (int)reader["Id"],
                        Nome = (string)reader["Nome"],
                        Email = (string)reader["Email"],
                        Telefone = (string)reader["Telefone"],
                        Ativo = (bool)reader["Ativo"]
                    };

                    motoristas.Add(motorista);
                }
                conn.Close();
            }
            return motoristas;
        }


        public void ExcluirMotorista(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string deleteVeiculosQuery = "DELETE FROM Veiculo WHERE MotoristaId = @IdMotorista";
                MySqlCommand deleteVeiculosCmd = new MySqlCommand(deleteVeiculosQuery, conn);
                deleteVeiculosCmd.Parameters.AddWithValue("@IdMotorista", id);
                deleteVeiculosCmd.ExecuteNonQuery();

                string query = "DELETE FROM Motorista WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        public void DesativarMotorista(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Motorista SET Ativo = 0 WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


        public string BuscarNomeMotoristaPorId(int motoristaId)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Nome FROM Motorista WHERE Id = @MotoristaId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MotoristaId", motoristaId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["Nome"].ToString();
                    }
                }
            }

            return null;
        }


        public List<Motorista> GetMotoristaAtivo()
        {
            List<Motorista> motoristas = new List<Motorista>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Motorista WHERE Ativo = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Motorista motorista = new Motorista
                    {
                        Id = (int)reader["Id"],
                        Nome = (string)reader["Nome"],
                        Email = (string)reader["Email"],
                        Telefone = (string)reader["Telefone"],
                        Ativo = (bool)reader["Ativo"]
                    };

                    motoristas.Add(motorista);
                }
                conn.Close();
            }
            return motoristas;
        }

    }
}
