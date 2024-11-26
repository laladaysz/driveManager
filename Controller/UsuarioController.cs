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

        public void CadastrarUsuario(string nome, string login, string senha, string role)
        {
            Usuario usuario = new Usuario
            {
                nome = nome,
                login = login,
                senha = senha,
                role = role
            };
            usuarioDAO.CadastrarUsuario(usuario);
        }

        public Usuario AutenticarUsuario(string login, string senha)
        {
            return usuarioDAO.AutenticarUsuario(login, senha);
        }

        public List<Usuario> GetAllUsuarios()
        {
            return usuarioDAO.GetAllUsuarios();
        }
    }
}
