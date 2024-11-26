using DriveManager.Controller;
using DriveManager.Model;
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
    public partial class GenMotorista : Form
    {
        private MotoristaController motoristaController;
        public GenMotorista()
        {
            InitializeComponent();
            motoristaController = new MotoristaController();
            CofigurarListView();
        }

        private void CofigurarListView()
        {
            listaMotoristas.View = System.Windows.Forms.View.Details;
            listaMotoristas.FullRowSelect = true;
            listaMotoristas.GridLines = true;

            listaMotoristas.Columns.Add("ID", 50);
            listaMotoristas.Columns.Add("Nome", 150);
            listaMotoristas.Columns.Add("Email", 200);
            listaMotoristas.Columns.Add("Telefone", 100);
            

        }

        private void attBtn_Click(object sender, EventArgs e) // att button
        {
            List<Motorista> motoristas = motoristaController.GetAllMotoristas();
            listaMotoristas.Items.Clear();

            foreach (var motorista in motoristas)
            {
                ListViewItem item = new ListViewItem(motorista.id_motorista.ToString());
                item.SubItems.Add(motorista.nome);
                item.SubItems.Add(motorista.email);
                item.SubItems.Add(motorista.telefone);
               

                listaMotoristas.Items.Add(item);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (listaMotoristas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaMotoristas.SelectedItems[0];
                long usuarioId = int.Parse(selectedItem.Text);
                motoristaController.ExcluirMotorista(usuarioId);

                attBtn_Click(sender, e);

                MessageBox.Show("Motorista excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um motorista para excluir.");
            }
        }


        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTxtBox.Text, out int motoristaId))
            {
                Motorista motorista = motoristaController.BuscarMotoristaPorId(motoristaId);
                listaMotoristas.Items.Clear();

                if (motorista != null)
                {
                    ListViewItem item = new ListViewItem(motorista.id_motorista.ToString());
                    item.SubItems.Add(motorista.nome);
                    item.SubItems.Add(motorista.email);
                    item.SubItems.Add(motorista.telefone);

                    listaMotoristas.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Motorista não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home homeAdmin = new Home();
            homeAdmin.Show();
        }

        private void listaMotoristas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
