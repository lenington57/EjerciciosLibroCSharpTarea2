using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BibliaRegistro
{
    public partial class RegistrosForm : Form
    {
        public RegistrosForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void librosBibliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BibliaRegistro.UI.Registros.LibroForm libroForm = new UI.Registros.LibroForm();
            libroForm.Visible = true;
        }
    }
}
