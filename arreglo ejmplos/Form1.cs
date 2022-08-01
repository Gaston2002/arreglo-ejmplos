using arreglo_ejmplos.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglo_ejmplos
{
    public partial class Form1 : Form
    {
        public persona[] personas { get; set; } = new persona[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e, persona personas)
        {
            persona persona = new persona();
            personas.nombres = txtNombre.Text;
            //persona [0] = personas;
        }

        private void btMostar_Click(object sender, EventArgs e)
        {
            lblLista.Text = "lista: \r\n";
            foreach (persona item in personas)
            {
                lblLista.Text = lblLista.Text + item.nombres + "\r\n";
            }
        }
    }
}
