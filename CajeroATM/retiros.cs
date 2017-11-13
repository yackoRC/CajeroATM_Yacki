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
    public partial class retiros : Form
    {
        public retiros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dolares dolar = new Dolares();
            this.Hide();
            dolar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lempiras lempira = new Lempiras();
            this.Hide();
            lempira.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
