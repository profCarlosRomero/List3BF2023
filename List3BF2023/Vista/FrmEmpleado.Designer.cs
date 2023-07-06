
namespace List3BF2023.Vista
{
    partial class FrmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcEmpleado = new System.Windows.Forms.TabControl();
            this.tabEmpListado = new System.Windows.Forms.TabPage();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.btnEmpMod = new System.Windows.Forms.Button();
            this.dgvListEmp = new System.Windows.Forms.DataGridView();
            this.tabEmpAlta = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDepto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxGerente = new System.Windows.Forms.ListBox();
            this.btnEmpAlta = new System.Windows.Forms.Button();
            this.btnEmpCancel = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaN = new System.Windows.Forms.DateTimePicker();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcEmpleado.SuspendLayout();
            this.tabEmpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmp)).BeginInit();
            this.tabEmpAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEmpleado
            // 
            this.tcEmpleado.Controls.Add(this.tabEmpListado);
            this.tcEmpleado.Controls.Add(this.tabEmpAlta);
            this.tcEmpleado.Location = new System.Drawing.Point(12, 12);
            this.tcEmpleado.Name = "tcEmpleado";
            this.tcEmpleado.SelectedIndex = 0;
            this.tcEmpleado.Size = new System.Drawing.Size(560, 325);
            this.tcEmpleado.TabIndex = 0;
            // 
            // tabEmpListado
            // 
            this.tabEmpListado.Controls.Add(this.btnEmpDel);
            this.tabEmpListado.Controls.Add(this.btnEmpMod);
            this.tabEmpListado.Controls.Add(this.dgvListEmp);
            this.tabEmpListado.Location = new System.Drawing.Point(4, 24);
            this.tabEmpListado.Name = "tabEmpListado";
            this.tabEmpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpListado.Size = new System.Drawing.Size(552, 297);
            this.tabEmpListado.TabIndex = 0;
            this.tabEmpListado.Text = "Listado";
            this.tabEmpListado.UseVisualStyleBackColor = true;
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.Location = new System.Drawing.Point(466, 82);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(80, 27);
            this.btnEmpDel.TabIndex = 2;
            this.btnEmpDel.Text = "Borrar";
            this.btnEmpDel.UseVisualStyleBackColor = true;
            this.btnEmpDel.Click += new System.EventHandler(this.btnEmpDel_Click);
            // 
            // btnEmpMod
            // 
            this.btnEmpMod.Location = new System.Drawing.Point(466, 37);
            this.btnEmpMod.Name = "btnEmpMod";
            this.btnEmpMod.Size = new System.Drawing.Size(80, 27);
            this.btnEmpMod.TabIndex = 1;
            this.btnEmpMod.Text = "Modificar";
            this.btnEmpMod.UseVisualStyleBackColor = true;
            this.btnEmpMod.Click += new System.EventHandler(this.btnEmpMod_Click);
            // 
            // dgvListEmp
            // 
            this.dgvListEmp.AllowUserToAddRows = false;
            this.dgvListEmp.AllowUserToDeleteRows = false;
            this.dgvListEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmp.Location = new System.Drawing.Point(6, 6);
            this.dgvListEmp.Name = "dgvListEmp";
            this.dgvListEmp.ReadOnly = true;
            this.dgvListEmp.RowTemplate.Height = 25;
            this.dgvListEmp.Size = new System.Drawing.Size(454, 279);
            this.dgvListEmp.TabIndex = 0;
            this.dgvListEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListEmp_CellClick);
            // 
            // tabEmpAlta
            // 
            this.tabEmpAlta.Controls.Add(this.label7);
            this.tabEmpAlta.Controls.Add(this.cbDepto);
            this.tabEmpAlta.Controls.Add(this.label6);
            this.tabEmpAlta.Controls.Add(this.listBoxGerente);
            this.tabEmpAlta.Controls.Add(this.btnEmpAlta);
            this.tabEmpAlta.Controls.Add(this.btnEmpCancel);
            this.tabEmpAlta.Controls.Add(this.txtSalario);
            this.tabEmpAlta.Controls.Add(this.label5);
            this.tabEmpAlta.Controls.Add(this.dtpFechaN);
            this.tabEmpAlta.Controls.Add(this.cbSexo);
            this.tabEmpAlta.Controls.Add(this.label4);
            this.tabEmpAlta.Controls.Add(this.label3);
            this.tabEmpAlta.Controls.Add(this.txtNombre);
            this.tabEmpAlta.Controls.Add(this.label2);
            this.tabEmpAlta.Controls.Add(this.txtNSS);
            this.tabEmpAlta.Controls.Add(this.label1);
            this.tabEmpAlta.Location = new System.Drawing.Point(4, 24);
            this.tabEmpAlta.Name = "tabEmpAlta";
            this.tabEmpAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpAlta.Size = new System.Drawing.Size(552, 297);
            this.tabEmpAlta.TabIndex = 1;
            this.tabEmpAlta.Text = "Alta";
            this.tabEmpAlta.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gerente";
            // 
            // cbDepto
            // 
            this.cbDepto.FormattingEnabled = true;
            this.cbDepto.Location = new System.Drawing.Point(304, 34);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(204, 23);
            this.cbDepto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Departamento";
            // 
            // listBoxGerente
            // 
            this.listBoxGerente.FormattingEnabled = true;
            this.listBoxGerente.ItemHeight = 15;
            this.listBoxGerente.Location = new System.Drawing.Point(304, 116);
            this.listBoxGerente.Name = "listBoxGerente";
            this.listBoxGerente.Size = new System.Drawing.Size(229, 109);
            this.listBoxGerente.TabIndex = 9;
            // 
            // btnEmpAlta
            // 
            this.btnEmpAlta.Location = new System.Drawing.Point(390, 267);
            this.btnEmpAlta.Name = "btnEmpAlta";
            this.btnEmpAlta.Size = new System.Drawing.Size(75, 23);
            this.btnEmpAlta.TabIndex = 8;
            this.btnEmpAlta.Text = "Alta";
            this.btnEmpAlta.UseVisualStyleBackColor = true;
            this.btnEmpAlta.Click += new System.EventHandler(this.btnEmpAlta_Click);
            // 
            // btnEmpCancel
            // 
            this.btnEmpCancel.Location = new System.Drawing.Point(471, 267);
            this.btnEmpCancel.Name = "btnEmpCancel";
            this.btnEmpCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEmpCancel.TabIndex = 7;
            this.btnEmpCancel.Text = "Cancelar";
            this.btnEmpCancel.UseVisualStyleBackColor = true;
            this.btnEmpCancel.Click += new System.EventHandler(this.btnEmpCancel_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(18, 228);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(180, 23);
            this.txtSalario.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Salario";
            // 
            // dtpFechaN
            // 
            this.dtpFechaN.Location = new System.Drawing.Point(18, 122);
            this.dtpFechaN.Name = "dtpFechaN";
            this.dtpFechaN.Size = new System.Drawing.Size(241, 23);
            this.dtpFechaN.TabIndex = 6;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(18, 175);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(150, 23);
            this.cbSexo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtNSS
            // 
            this.txtNSS.Location = new System.Drawing.Point(18, 34);
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(180, 23);
            this.txtNSS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NSS";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 347);
            this.Controls.Add(this.tcEmpleado);
            this.Name = "FrmEmpleado";
            this.Text = "txtNSSMod";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.tcEmpleado.ResumeLayout(false);
            this.tabEmpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmp)).EndInit();
            this.tabEmpAlta.ResumeLayout(false);
            this.tabEmpAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEmpleado;
        private System.Windows.Forms.TabPage tabEmpListado;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Button btnEmpMod;
        private System.Windows.Forms.DataGridView dgvListEmp;
        private System.Windows.Forms.TabPage tabEmpAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxGerente;
        private System.Windows.Forms.Button btnEmpAlta;
        private System.Windows.Forms.Button btnEmpCancel;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaN;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDepto;
    }
}