using Negocio;
using Entidades;


namespace ClienteServicios
{
    public partial class Form1 : Form
    {
        private Task<IEnumerable<Alumno>>? l;
        public Form1()
        {
            InitializeComponent();
        }

        public IEnumerable<Alumno> cargarTabla()
        {
            l = AlumnoNegocio.GetAll();
            return l.Result;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<Alumno>> task = new Task<IEnumerable<Alumno>>(cargarTabla);
            task.Start();
            dataGridView1.DataSource = await task;
        }
    }
}
