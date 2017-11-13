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
    public partial class Dolares : Form
    {
        public Dolares()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio fm = new Inicio();
            this.Hide();
            fm.ShowDialog();
        }
    }
}
