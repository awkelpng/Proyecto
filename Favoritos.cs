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
    public partial class Favoritos : Form
    {
        public Favoritos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Crear_Cuenta crear_Cuenta = new Crear_Cuenta();
            crear_Cuenta.Show();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Inicio_Sesion Inicio_Sesion = new Inicio_Sesion();
            Inicio_Sesion.Show();
        }

        private void btnAvisoPrivacidad_Click(object sender, EventArgs e)
        {
            Aviso_Privacidad aviso_Privacidad = new Aviso_Privacidad();
            aviso_Privacidad.Show();
            this.Hide();
        }

        private void btnTerminos_Click(object sender, EventArgs e)
        {
            Terminos_Condiciones terminos_Condiciones = new Terminos_Condiciones();
            terminos_Condiciones.Show();
            this.Hide();
        }
    }
}
