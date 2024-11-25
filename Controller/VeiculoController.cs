using DriveManager.DAO;
using DriveManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveManager.Controller
{
    public class VeiculoController
    {
        private VeiculoDAO veiculoDAO;
        private MotoristaController motoristaController;

        public VeiculoController()
        {
            veiculoDAO = new VeiculoDAO();
            motoristaController = new MotoristaController();
        }

        public List<Veiculo> GetAllVeiculo()
        {
            return veiculoDAO.GetAllVeiculos();
        }

        public void CadastrarVeiculos(string placa, string modelo, string cor, int idMotorista)
        {
            Veiculo veiculo = new Veiculo()
            {
                Placa = placa,
                Modelo = modelo,
                Cor = cor
            };

            veiculoDAO.CadastrarVeiculo(veiculo, idMotorista);
        }

        public Veiculo GetVeiculoById(int id)
        {
            return veiculoDAO.GetVeiculoById(id);
        }

        public void DeleteVeiculo(int id)
        {
            veiculoDAO.DeleteVeiculo(id);
        }

        public List<Veiculo> GetVeiculosByMotorista(int idMotorista)
        {
            return veiculoDAO.GetVeiculoByMotorista(idMotorista);
        }

        public List<(Veiculo veiculo, string nomeMotorista)> GetVeiculosComMotorista()
        {
            var veiculos = veiculoDAO.GetAllVeiculos();
            var resultado = new List<(Veiculo veiculo, string nomeMotorista)>();

            foreach (var veiculo in veiculos)
            {
                string nomeMotorista = motoristaController.GetNomeMotoristaById(veiculo.MotoristaId) ?? "Desconhecido";
                resultado.Add((veiculo, nomeMotorista));
            }

            return resultado;
        }

        public (Veiculo veiculo, string nomeMotorista) GetVeiculoComMotoristaPorId(int idVeiculo)
        {
            var veiculo = veiculoDAO.GetVeiculoById(idVeiculo);

            string nomeMotorista = motoristaController.GetNomeMotoristaById(veiculo.MotoristaId);

            return (veiculo, nomeMotorista);
        }

        public void AtualizarVeiculo(int id, string placa, string modelo, string cor, int motoristaId)
        {
            var veiculo = new Veiculo
            {
                Id = id,
                Placa = placa,
                Modelo = modelo,
                Cor = cor,
                MotoristaId = motoristaId,
            };

            veiculoDAO.AtualizarVeiculo(veiculo);
        }



    }
}
