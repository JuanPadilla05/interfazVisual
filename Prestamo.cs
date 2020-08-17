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
    public partial class ventanaPrestamo : Form
    {
        string nombre_cliente;
        string[] razas_disponibles = { "nemesis", "Tefha" ,"aries","tauro","geminis"};
        int[] cuotas_disponibles = { 12, 24, 36, 60, 120, 170, 210 };
        string[] lugares_disponibles;
        Dictionary<int, double> interes_base;
        public ventanaPrestamo( string nombre)
        {
            InitializeComponent();
            nombre_cliente = nombre;
            string listado_ciudades = Properties.Resources.lugares.ToString();
            lugares_disponibles = listado_ciudades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

           

            interes_base = new Dictionary<int,double>();
            int i;
            double interes;
            for (i = 0, interes = 3.0; i < cuotas_disponibles.Length; i++, interes+= 0.5)
            {
                interes_base[cuotas_disponibles[i]] = interes;
            }
            
        }


        private void ventanaPrestamo_Load(object sender, EventArgs e)
        {
            PopularCoutas();
            PopularRazas();
            PopularCiudades();
            saludos.Text = nombre_cliente;
        }

        void PopularCoutas()
        { 
            for(int i= 0; i<cuotas_disponibles.Length; i++)
            {
                cuotas.Items.Add(cuotas_disponibles[i]);
            }

        }
        void PopularRazas()
        {
            for (int i = 0; i < razas_disponibles.Length; i++)
            {
                raza.Items.Add(razas_disponibles[i]);
            }
        }
        void PopularCiudades()
        {
            for (int i = 0; i < lugares_disponibles.Length; i++)
            {
                lugar.Items.Add(lugares_disponibles [i]);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double calcularInteres()
        {
            int cuotas_perdidas = (int)cuotas.SelectedItem;
            string razas_selecionada = raza.SelectedItem.ToString().ToLower();
            string lugares_selecionado = lugar.SelectedItem.ToString().ToLower();
            double interes = interes_base[cuotas_perdidas];
            if (new[] { "nemesis", "Tefha", "aries", "tauro", "geminis" }.Contains(razas_selecionada)) ;
            {
                interes += 3.0;
            }

            if (new[] { "Trujillo", "Lima", "Huaraz", "Tarapoto", "Piura" }.Contains(lugares_selecionado)) ;
            {
                interes -= 3.0;
            }

            return interes;
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(datosPrestamos, "");
                        errorProvider1.SetError(datosPersonales, "");
                        double interesMensual = calcularInteres();
                        double montoPedido = double.Parse(monto.Text);
                        double cuotasPedidas = (int)cuotas.SelectedItem;
                        double interesTotal = montoPedido * (interesMensual / 100) * cuotasPedidas;
                        double montoPagar = montoPedido - interesTotal;
                        string mensaje = "Su Prestamo " + montoPedido + " en " + cuotasPedidas + " se considerara con un interés del " + interesMensual + " % menssual\n El monto final aciende  " + montoPagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "calculo el interes", buttons);
                        break;


                    }


                case 1:
                    {
                        errorProvider1.SetError(datosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(datosPrestamos, "");
                        break;
                    }

                case 2:
                    {
                        errorProvider1.SetError(datosPrestamos, "Debe ingresar un monto numérico y una cantidad de cuotas");
                        errorProvider1.SetError(datosPersonales, "");
                        break;
                    }

            }
        }

        int validaciones()
        {
            if((raza.SelectedIndex <=-1) || (lugar.SelectedIndex <=-1))
            {
                return 1;
            }
            if (!(monto.Text.All(char.IsDigit)) || (monto.Text == "") || (cuotas.SelectedIndex <= -1))
            {
                return 2;
            }

            else
            {
                return 0;
            }
        }
       

        //https://www.youtube.com/watch?v=lY1Z0Hgo288 53
    }
}
