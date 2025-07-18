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
    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();                        
            Inicio.InstanciaGlobal.Show();
        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            Crear_Cuenta crear_Cuenta = new Crear_Cuenta();
            crear_Cuenta.Show();
            this.Hide();

        }

        private void btnRecuperarC_Click(object sender, EventArgs e)
        {
            Recuperar_Contrasena recuperar_Contrasena = new Recuperar_Contrasena();
            recuperar_Contrasena.Show();
            this.Hide();
        }

        private void btnIniciarS_Click(object sender, EventArgs e)
        {

        }
    }
}
