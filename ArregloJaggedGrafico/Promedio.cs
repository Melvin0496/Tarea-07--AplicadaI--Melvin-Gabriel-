using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloJaggedGrafico
{
    public partial class Promedio : Form
    {
        ArrayList Arreglo;
        public Promedio()
        {
            InitializeComponent();
            Arreglo = new ArrayList();
        }
        int i = 0;
        float promedio = 0.0f,suma = 0.0f;
        int valor;
        private void Presionabutton_Click(object sender, EventArgs e)
        {
            valor = Convert.ToInt32(TextotextBox.Text);
            Arreglo.Add(valor);
            i++;
            suma += valor;
            promedio = suma / i;
            TextotextBox.Text = "";
        }
        
        private void Clickbutton_Click(object sender, EventArgs e)
        {
            int i,x = 0;
            for(i = 0;i < Arreglo.Count;i++)
            {
                Arreglo.Sort();
                NumeroslistBox.Items.Add(Arreglo[i]);
            }
            SumatextBox.Text = Convert.ToString(suma);
            PromediotextBox.Text = Convert.ToString(promedio);
            MinimatextBox.Text = Convert.ToString(Arreglo[0]);
           // MaximatextBox.Text = Convert.ToString(Arreglo[1]);
           
        }
    }
}
