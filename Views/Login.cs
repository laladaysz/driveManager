using DriveManager.Controller;
using DriveManager.Model;
using DriveManager.Views;

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

            Usuario usuario = usuarioController.AutenticarUsuario(email, senha);

            if (usuario != null)
            {
                MessageBox.Show("Login realizado com sucesso! Seja bem-vindo, " + usuario.Nome);
                this.Hide();

                if (usuario.Role == "ADMIN")
                {
                    this.Hide();
                    Home home = new Home();
                    home.Show();

                }
                else
                {
                    MessageBox.Show("Você não tem permissão para acessar esse sistema!");
                }

            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
            }
        }

        
    }
}
