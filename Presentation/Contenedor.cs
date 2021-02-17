using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Contenedor : Form
    {
        private Form form = null;

        public Contenedor()
        {
            InitializeComponent();
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {
            ShadowForm();
        }

        private void ShadowForm()
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void OpenForm(Form ChildForm)
        {
            if (form != null) form.Close();
            form = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            panel_container.Controls.Add(ChildForm);
            panel_container.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private async void btn_clientes_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadClientes))
            {
                task.Start();
                await task;
            }
        }

        private void LoadClientes()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenForm(new Cliente.Cliente())));
            }
        }

        private async void btn_empleados_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadEmpleados))
            {
                task.Start();
                await task;
            }
        }

        private void LoadEmpleados()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenForm(new Empleado.Empleado())));
            }
        }

        private async void btn_facturas_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadFacturas))
            {
                task.Start();
                await task;
            }
        }

        private void LoadFacturas()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenForm(new Factura.Factura())));
            }
        }

        private async void btn_nominas_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadNominas))
            {
                task.Start();
                await task;
            }
        }

        private void LoadNominas()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenForm(new Nomina.Nomina())));
            }
        }

        private async void btn_corte_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadCorte))
            {
                task.Start();
                await task;
            }
        }

        private void LoadCorte()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenForm(new Corte.Corte())));
            }
        }

        private async void btn_inventario_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadInventario))
            {
                task.Start();
                await task;
            }
        }

        private void LoadInventario()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenForm(new Inventario.Inventario())));
            }
        }

        private async void btn_usuarios_Click(object sender, EventArgs e)
        {
            using (Task task = new Task(LoadUsuarios))
            {
                task.Start();
                await task;
            }
        }

        private void LoadUsuarios()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OpenForm(new Usuario.Usuario())));
            }
        }
    }
}
