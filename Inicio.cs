namespace Proyecto
{
    public partial class Inicio : Form
    {
        public static Inicio InstanciaGlobal;
        public Inicio()
        {
            InitializeComponent();
            InstanciaGlobal = this;
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Inicio_Sesion Inicio_Sesion = new Inicio_Sesion();
            Inicio_Sesion.Show();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Crear_Cuenta crear_Cuenta = new Crear_Cuenta();
            crear_Cuenta.Show();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            Explorar explorar = new Explorar();
            this.Hide();
            explorar.Show();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Favoritos favoritos = new Favoritos();
            favoritos.Show();
            this.Hide();
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
