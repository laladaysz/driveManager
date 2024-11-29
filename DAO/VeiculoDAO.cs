using DriveManager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveManager.DAO
{
    public class VeiculoDAO
    {
        private string connectionString = "server=localhost;database=EasyPark;user=root;password=";

        public void CadastrarVeiculo(Veiculo veiculo, long idMotorista)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Veiculos (placa, id_motorista, modelo, cor) VALUES (@Placa, @MotoristaId, @Modelo, @Cor)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Placa", veiculo.placa);
                cmd.Parameters.AddWithValue("@Modelo", veiculo.modelo);
                cmd.Parameters.AddWithValue("@Cor", veiculo.cor);
                cmd.Parameters.AddWithValue("@MotoristaId", idMotorista);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<Veiculo> GetAllVeiculos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Veiculos";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Veiculo veiculo = new Veiculo
                    {
                        id_veiculo = (long)reader["id_veiculo"],
                        placa = (string)reader["placa"],
                        modelo = (string)reader["modelo"],
                        cor = (string)reader["cor"],
                        id_motorista = (long)reader["id_motorista"]
                    };

                    veiculos.Add(veiculo);
                }
                con.Close();
            }
            return veiculos;
        }

        public Veiculo GetVeiculoById(long id)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Veiculos WHERE id_veiculo = @Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Veiculo veiculo = new Veiculo()
                    {
                        id_veiculo = (long)reader["id_veiculo"],
                        placa = (string)reader["placa"],
                        modelo = (string)reader["modelo"],
                        cor = (string)reader["cor"],
                        id_motorista = (long)reader["id_motorista"]
                    };
                    con.Close();
                    return veiculo;
                }

                return null;
            }
        }

        public void DeleteVeiculo(long id)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                
                string deleteEntradaSaida = "DELETE FROM entradas_saidas WHERE id_veiculo = @Id";
                using (MySqlCommand del = new MySqlCommand(deleteEntradaSaida, conn))
                {
                    del.Parameters.AddWithValue("@Id", id);
                    del.ExecuteNonQuery(); 
                }

                
                string query = "DELETE FROM Veiculos WHERE id_veiculo = @Id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Veiculo> GetVeiculoByMotorista(long MotoristaId)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Veiculos WHERE id_motorista = @MotoristaId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MotoristaId", MotoristaId);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Veiculo veiculo = new Veiculo
                    {
                        id_veiculo = (long)reader["id_veiculo"],
                        placa = (string)reader["placa"],
                        modelo = (string)reader["modelo"],
                        cor = (string)reader["cor"],
                        id_motorista = (long)reader["id_motorista"]
                    };

                    veiculos.Add(veiculo);
                }
                conn.Close();
            }
            return veiculos;

        }

    }
}
