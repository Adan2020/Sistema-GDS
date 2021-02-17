using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Cliente
{
    public partial class Cliente : Form
    {
        Domain.Cliente ClienteD = new Domain.Cliente();

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            ShowClientes();
        }

        private void ShowClientes()
        {
            dataGridView1.DataSource = ClienteD.Show();
            dataGridView1.RowTemplate.Height = 38;
            dataGridView1.Columns[0].DisplayIndex = 10;
            dataGridView1.Columns[1].DisplayIndex = 9;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[10].Width = 170;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormCliente AddCliente = new FormCliente();
            AddCliente.Show();
        }
    }
}
