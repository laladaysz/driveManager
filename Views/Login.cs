using DriveManager.Controller;
using DriveManager.Model;
using DriveManager.Views;
using Org.BouncyCastle.Crypto.Generators;
using System.Text;
using BCrypt.Net;

namespace DriveManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text;
            string senha = senhaTxtBox.Text;

            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = usuarioController.AutenticarUsuario(email);

            if (usuario != null)
            {

                bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senha, usuario.senha);

                if (senhaCorreta)
                {
                    MessageBox.Show("Login realizado com sucesso! Seja bem-vindo, " + usuario.nome);
                    this.Hide();

                    if (usuario.role == "ROLE_ADMIN")
                    {
                        this.Hide();
                        Home home = new Home();
                        home.Show();

                    }
                    else
                    {
                        MessageBox.Show("Voc� n�o tem permiss�o para acessar esse sistema!");
                    }
                } else
                {
                    MessageBox.Show("Senha incorreta!");
                }
            }
            else
            {
                MessageBox.Show("Usu�rio n�o encontrado! Tente novamente.");
            }
        }

        
    }
}
