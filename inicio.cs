using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            btnSolicitar.Enabled = false;
        }

        private void controlBotones()
        {
                                                     // sirve para validar que no coloquen numeros      
            if (nombre.Text.Trim() != String.Empty && nombre.Text.All(char.IsLetter))
            {
                btnSolicitar.Enabled = true;
                errorProvider1.SetError(nombre, "");
                
            }
            else
            {
                if (!(nombre.Text.All(char.IsLetter)))
                {
                    errorProvider1.SetError(nombre, "el nombre debe ingresar solo letras");

                }
                else
                {
                    errorProvider1.SetError(nombre, "Debe ingresar su nombre");
                }
                btnSolicitar.Enabled = false;
                nombre.Focus();
            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            using (ventanaPrestamo ventana = new ventanaPrestamo(nombre.Text))
                ventana.ShowDialog();
        }
    }
}
