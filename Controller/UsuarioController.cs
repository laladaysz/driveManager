using DriveManager.DAO;
using DriveManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveManager.Controller
{
    public class UsuarioController
    {
        private UsuarioDAO usuarioDAO;

        public UsuarioController()
        {
            usuarioDAO = new UsuarioDAO();
        }

        public void CadastrarUsuario(string nome, string email, string senha, string role, bool ativado)
        {
            Usuario usuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Senha = senha,
                Role = role,
                Ativado = ativado
            };
            usuarioDAO.CadastrarUsuario(usuario);
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return usuarioDAO.BuscarUsuarioPorId(id);
        }

        public void AtualizarUsuario(int id, string nome, string email, string senha, string role, bool ativado)
        {
            Usuario usuario = new Usuario
            {
                Id = id,
                Nome = nome,
                Email = email,
                Senha = senha,
                Role = role,
                Ativado = ativado
            };
            usuarioDAO.AtualizarUsuario(usuario);
        }

        public Usuario AutenticarUsuario(string email, string senha)
        {
            return usuarioDAO.AutenticarUsuario(email, senha);
        }

        public List<Usuario> GetAllUsuarios()
        {
            return usuarioDAO.GetAllUsuarios();
        }

        public void ExcluirUsuario(int id)
        {
            usuarioDAO.ExcluirUsuario(id);
        }

        public void TornarAdmin(int id)
        {
            usuarioDAO.TornarAdmin(id);
        }

        public void Desativar(int id)
        {
            usuarioDAO.Desativar(id);
        }
    }
}
