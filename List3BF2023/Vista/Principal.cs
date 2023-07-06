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
    public partial class Principal : Form
    {
        private FrmEmpleado frmEmp;
        public Principal()
        {
            InitializeComponent();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            if (frmEmp == null || frmEmp.IsDisposed)
                frmEmp = new();

            frmEmp.MdiParent = this;

            frmEmp.Show();
            frmEmp.Focus();
        }
    }
}
