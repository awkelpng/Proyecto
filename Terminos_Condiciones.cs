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
    public partial class Terminos_Condiciones : Form
    {
        public Terminos_Condiciones()
        {
            InitializeComponent();
        }

        private void btnAvisoPrivacidad_Click(object sender, EventArgs e)
        {
            Aviso_Privacidad aviso_Privacidad = new Aviso_Privacidad();
            aviso_Privacidad.Show();
            this.Hide();
        }

        private void lblTxtAviso_Click(object sender, EventArgs e)
        {

        }
    }
}
