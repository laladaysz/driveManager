﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroMotoristas cadastro = new CadastroMotoristas();
            cadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroVeiculo cadastroVeiculo = new CadastroVeiculo();
            cadastroVeiculo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            GenMotorista cadastro = new GenMotorista();
            cadastro.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 GenVeiculos = new Form1();
            GenVeiculos.Show();
        }
    }
}
