using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crud_nomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile("user.png");// imagen de usuario se guardo en la ruta del bin del proyecto
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btcrear_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.ConsultaSinResultado(" INSERT INTO empleado (nombre, apellido,fecha_nacimiento,fcha_ingreso,sexo)VALUES('" + tbnombre.Text.ToString() + "','" + tbapellido.Text.ToString() + "','" + tbfechan.Text.ToString() + "','" + tbfechai.Text.ToString() + "','" + cbsexo.Text.ToString() + "')");

            MessageBox.Show("Guardado Correctamente"); // retorna mensage al introducir el regitro 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Operaciones oper = new Operaciones();
                oper.ConsultaSinResultado(" UPDATE empleado SET nombre='" + tbnombre.Text.ToString() + "', apellido='" + tbapellido.Text.ToString()  + "' WHERE codigo_emp='" + tbcodigo.Text + "'");

                MessageBox.Show("Modificado");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Operaciones oper = new Operaciones();
            oper.ConsultaSinResultado(" DELETE FROM empleado WHERE codigo_emp='" + tbcodigo.Text + "'");

            MessageBox.Show("Eliminado");
        }

        private void panel_datos_emp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmostrar_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form car = new frmCrearCargo();
            car.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form dep = new frmDepartamento();
            dep.Show();
        }
    }
}
