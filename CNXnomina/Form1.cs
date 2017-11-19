using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CNXnomina
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

        }
    }
}
