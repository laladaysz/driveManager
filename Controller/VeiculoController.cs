using DriveManager.DAO;
using DriveManager.Model;
using Org.BouncyCastle.Math.EC.Endo;
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

        public void CadastrarVeiculos(string placa, string modelo, string cor, long idMotorista)
        {
            Veiculo veiculo = new Veiculo()
            {
                placa = placa,
                modelo = modelo,
                cor = cor
            };

            veiculoDAO.CadastrarVeiculo(veiculo, idMotorista);
        }

        public Veiculo GetVeiculoById(long id)
        {
            return veiculoDAO.GetVeiculoById(id);
        }

        public void DeleteVeiculo(long id)
        {
            veiculoDAO.DeleteVeiculo(id);
        }

        public List<Veiculo> GetVeiculosByMotorista(long idMotorista)
        {
            return veiculoDAO.GetVeiculoByMotorista(idMotorista);
        }

        public List<(Veiculo veiculo, string nomeMotorista)> GetVeiculosComMotorista()
        {
            var veiculos = veiculoDAO.GetAllVeiculos();
            var resultado = new List<(Veiculo veiculo, string nomeMotorista)>();

            foreach (var veiculo in veiculos)
            {
                string nomeMotorista = motoristaController.GetNomeMotoristaById(veiculo.id_motorista) ?? "Desconhecido";
                resultado.Add((veiculo, nomeMotorista));
            }

            return resultado;
        }

        public (Veiculo veiculo, string nomeMotorista) GetVeiculoComMotoristaPorId(long idVeiculo)
        {
            Veiculo veiculo = veiculoDAO.GetVeiculoById(idVeiculo);
            
            string nomeMotorista = motoristaController.GetNomeMotoristaById(veiculo.id_motorista);

            return (veiculo, nomeMotorista);
        }




    }
}
