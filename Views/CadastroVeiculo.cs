using DriveManager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveManager.Views
{
    public partial class CadastroVeiculo : Form
    {
        private VeiculoController veiculoController;
        private MotoristaController motoristaController;
        public CadastroVeiculo()
        {
            InitializeComponent();
            veiculoController = new VeiculoController();
            motoristaController = new MotoristaController();
            CarregarMotoristasComboBox();
        }

        private void CarregarMotoristasComboBox()
        {
            var motoristas = motoristaController.GetMotoristaAtivos();

            motoristaBox.DataSource = motoristas;
            motoristaBox.DisplayMember = "Nome";
            motoristaBox.ValueMember = "Id";
        }

        private void cadBtn_Click(object sender, EventArgs e)
        {
            string placa = placaTxt.Text;
            string modelo = modeloTxt.Text;
            string cor = corTxt.Text;
            int id_motorista = (int)motoristaBox.SelectedValue;

            veiculoController.CadastrarVeiculos(placa, modelo, cor, id_motorista);

            MessageBox.Show("Veículo cadastrado com sucesso!");

            placaTxt.Clear();
            modeloTxt.Clear();
            corTxt.Clear();
            motoristaBox.SelectedIndex = -1;
        }
        private void label2_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
