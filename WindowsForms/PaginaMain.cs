using WindowsForms;

namespace WindowsForms
{
    public partial class PaginaMain : Form
    {
        public PaginaMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PaginaMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            appLogin.ShowDialog();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {

            var frm = new UsuariosLista();

            frm.Show();

        }

        private void mnuCursos_Click(object sender, EventArgs e)
        {
            var frm = new CursosLista();

            frm.Show();
        }
    }
}
