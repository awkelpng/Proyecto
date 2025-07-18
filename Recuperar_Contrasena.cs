using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Recuperar_Contrasena : Form
    {
        public Recuperar_Contrasena()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio_Sesion inicio_Sesion = new Inicio_Sesion();
            inicio_Sesion.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aviso_Privacidad aviso_Privacidad = new Aviso_Privacidad();
            aviso_Privacidad.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terminos_Condiciones terminos_Condiciones = new Terminos_Condiciones();
            terminos_Condiciones.Show();
            this.Hide();
        }
    }
}
