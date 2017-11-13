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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        public int xClick = 0, yClick = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.ShowDialog();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
