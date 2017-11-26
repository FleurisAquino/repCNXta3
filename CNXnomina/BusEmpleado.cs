using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crud_nomina
{
    public partial class BusEmpleado : Form
    {
        public BusEmpleado()
        {
            InitializeComponent();
        }

        private void BusEmpleado_Load(object sender, EventArgs e)
        {
              
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form crear = new Form1();
            crear.Show();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            //  DataSet ds = oper.ConsultaConResultado(" select * from empleado");

            DataSet ds = oper.ConsultaConResultado("  select empleado.id, empleado.nombre, empleado.apellidos, departamento.nombre as departamento FROM empleado left join departamento on empleado.id_departamento = departamento.id; ");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
