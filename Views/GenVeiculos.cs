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
    public partial class Form1 : Form
    {
        VeiculoController veiculoControl;
        public Form1()
        {
            InitializeComponent();
            veiculoControl = new VeiculoController();
            CofigurarListView();
        }

        private void CofigurarListView()
        {
            listaVeiculos.View = System.Windows.Forms.View.Details;
            listaVeiculos.FullRowSelect = true;
            listaVeiculos.GridLines = true;

            listaVeiculos.Columns.Add("ID", 50);
            listaVeiculos.Columns.Add("Placa", 150);
            listaVeiculos.Columns.Add("Modelo", 200);
            listaVeiculos.Columns.Add("Cor", 100);
            listaVeiculos.Columns.Add("Motorista", 80);

        }
        private void attBtn_Click(object sender, EventArgs e)
        {
            listaVeiculos.Items.Clear();

            var veiculosComMotorista = veiculoControl.GetVeiculosComMotorista();

            foreach (var (veiculo, nomeMotorista) in veiculosComMotorista)
            {
                ListViewItem item = new ListViewItem(veiculo.id_veiculo.ToString());
                item.SubItems.Add(veiculo.placa);
                item.SubItems.Add(veiculo.modelo);
                item.SubItems.Add(veiculo.cor);
                item.SubItems.Add(nomeMotorista);

                listaVeiculos.Items.Add(item);
            }

        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listaVeiculos.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaVeiculos.SelectedItems[0];
                int veiculoId = int.Parse(selectedItem.Text);
                veiculoControl.DeleteVeiculo(veiculoId);

                attBtn_Click(sender, e);

                MessageBox.Show("Veículo excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um veículo para excluir.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Home homeAdmin = new Home();
            homeAdmin.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (long.TryParse(idTxtBox.Text, out long veiculoId))
            {
                try
                {
                    var (veiculo, nomeMotorista) = veiculoControl.GetVeiculoComMotoristaPorId(veiculoId);

                    listaVeiculos.Items.Clear();

                    ListViewItem item = new ListViewItem(veiculo.id_veiculo.ToString());
                    item.SubItems.Add(veiculo.placa);
                    item.SubItems.Add(veiculo.modelo);
                    item.SubItems.Add(veiculo.cor);
                    item.SubItems.Add(nomeMotorista);

                    listaVeiculos.Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veículo não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.");
            }
        }
    }
}
