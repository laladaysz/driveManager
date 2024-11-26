using DriveManager.DAO;
using DriveManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveManager.Controller
{
    public class MotoristaController
    {
        private MotoristaDAO motoristaDao;

        public MotoristaController()
        {
            motoristaDao = new MotoristaDAO();
        }

        public void CadastrarMotorista(string nome, string email, string telefone)
        {
            Motorista motorista = new Motorista
            {
                nome = nome,
                email = email,
                telefone = telefone,
                
            };
            motoristaDao.cadastrarMotorista(motorista);
        }

        public Motorista BuscarMotoristaPorId(long id)
        {
            return motoristaDao.BuscarMotoristaPorId(id);
        }

        public List<Motorista> GetAllMotoristas()
        {
            return motoristaDao.GetAllMotorista();
        }

        public void ExcluirMotorista(long id)
        {
            motoristaDao.ExcluirMotorista(id);
        }

        

        public string GetNomeMotoristaById(long motoristaId)
        {
            return motoristaDao.BuscarNomeMotoristaPorId(motoristaId);
        }

        
    }
}
