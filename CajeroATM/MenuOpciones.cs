using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroATM
{
    public partial class MenuOpciones : Form
    {
        public MenuOpciones()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultasTransacciones consulta = new ConsultasTransacciones();
            this.Hide();
            consulta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            retiros retiro = new retiros();
            this.Hide();
            retiro.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CambioPin pin = new CambioPin();
            this.Hide();
            pin.ShowDialog();
        }
    }
}
