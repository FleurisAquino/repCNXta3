# repCNXta3using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crud_nomina
{
    public partial class frmDepartamento : Form
    {
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void btcrear_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.ConsultaSinResultado(" INSERT INTO cargo (nombre, estatus)VALUES('" + tbnombre.Text.ToString() + "','" + tbestatus.Text.ToString() + "')");

            MessageBox.Show("Guardado Correctamente");
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.ConsultaSinResultado(" DELETE FROM cargo WHERE codigo='" + tbcodigo.Text + "'");

            MessageBox.Show("Eliminado");
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.ConsultaSinResultado(" UPDATE cargo SET nombre='" + tbnombre.Text.ToString() + "',estatus='" + tbestatus.Text.ToString() + "' WHERE codigo='" + tbcodigo.Text + "'");

            MessageBox.Show("Modificado");
        }
    }
}
