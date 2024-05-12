using acceso.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acceso.Presentacion
{
    public partial class Man : Form
    {
        public Man()
        {
            InitializeComponent();
        }
        EstudianteNegocio objNegocio = new EstudianteNegocio();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objNegocio.ListarEstudiantes();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
