using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List3BF2023.Vista
{
    public partial class FrmEmpleado : Form
    {
        private int filaSeleccionada;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            Modelo.Empleados.GetInstancia().CargarPrueba();
            dgvListEmp.DataSource = Modelo.Empleados.GetInstancia().CargarDGV();
        }

        private void btnEmpAlta_Click(object sender, EventArgs e)
        {
            if (btnEmpAlta.Text.Equals("Alta"))
            {
                /*  private string nss;
                    private string nombrep;
                    private DateTime fechan;
                    private char sexo;
                    private double salario;*/
                string nss = txtNSS.Text;
                string nombrep = txtNombre.Text;
                DateTime fechan = dtpFechaN.Value.Date;
                char sexo = cbSexo.SelectedItem.ToString()[0];
                double salario = double.Parse(txtSalario.Text);

                Modelo.Empleado emp = new(nss, nombrep, fechan, sexo, salario);

                Modelo.Empleados.GetInstancia().Alta(emp);

                dgvListEmp.DataSource = Modelo.Empleados.GetInstancia().CargarDGV();
            }
            else
            {
                string nss = txtNSS.Text;
                /* Se cargan las modificaciones del empleado */
                string nombrep = txtNombre.Text;
                DateTime fechan = dtpFechaN.Value;
                char sexo = cbSexo.SelectedItem.ToString()[0];
                double salario = double.Parse(txtSalario.Text);

                Modelo.Empleado emp = new(nss, nombrep, fechan, sexo, salario);
                Modelo.Empleados.GetInstancia().Modificar(emp);
                MessageBox.Show($"{nss} {nombrep} {fechan.ToString()} {sexo} {salario}");

                dgvListEmp.DataSource = Modelo.Empleados.GetInstancia().CargarDGV();
            }
        }

        private void btnEmpMod_Click(object sender, EventArgs e)
        {
            tcEmpleado.SelectTab(1);
            tabEmpAlta.Text = "Modificación";
            btnEmpAlta.Text = "Modificar";
            txtNSS.Enabled = false;

            // MessageBox.Show(dgvListEmp.Rows[filaSeleccionada].Cells[0].Value.ToString());

            string nss = dgvListEmp.Rows[filaSeleccionada].Cells[0].Value.ToString();
            string nombrep = dgvListEmp.Rows[filaSeleccionada].Cells[1].Value.ToString();
            DateTime fechan = DateTime.Parse(dgvListEmp.Rows[filaSeleccionada].Cells[2].Value.ToString());
            char sexo = dgvListEmp.Rows[filaSeleccionada].Cells[3].Value.ToString()[0];
            double salario = double.Parse(dgvListEmp.Rows[filaSeleccionada].Cells[4].Value.ToString());
            //MessageBox.Show($"{nss} {nombrep} {fechan.ToString()} {sexo} {salario}");

            /* Se carga el formulario con los datos del empleado seleccionado */
            txtNSS.Text = nss;
            txtNombre.Text = nombrep;
            dtpFechaN.Value = fechan.Date;
            if (sexo == 'M')
                cbSexo.SelectedIndex = 0;
            else
                cbSexo.SelectedIndex = 1;
            txtSalario.Text = salario.ToString();

            /* Se cargan las modificaciones del empleado 
            nombrep = txtNombre.Text;
            fechan = dtpFechaN.Value;
            sexo = cbSexo.SelectedItem.ToString()[0];
            salario = double.Parse(txtSalario.Text);

            Modelo.Empleado emp = new(nss, nombrep, fechan, sexo, salario);
            Modelo.Empleados.GetInstancia().Modificar(emp);
            MessageBox.Show($"{nss} {nombrep} {fechan.ToString()} {sexo} {salario}");

            dgvListEmp.DataSource = Modelo.Empleados.GetInstancia().CargarDGV();*/
        }

        private void dgvListEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex>=0)
            {
                filaSeleccionada = e.RowIndex;
            }
        }

        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            string nss = dgvListEmp.Rows[filaSeleccionada].Cells[0].Value.ToString();
            Modelo.Empleados.GetInstancia().Baja(nss);

            dgvListEmp.DataSource = Modelo.Empleados.GetInstancia().CargarDGV();
        }

        private void btnEmpCancel_Click(object sender, EventArgs e)
        {
            tcEmpleado.SelectTab(0);
        }
    }
}
