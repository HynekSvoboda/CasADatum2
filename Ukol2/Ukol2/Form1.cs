using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        DateTime zacatek = new DateTime();
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            zacatek = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            DateTime konec = new DateTime();
            konec = DateTime.Now;
            TimeSpan rozdil = konec - zacatek;
            MessageBox.Show("Uběhlý čas minuty: "+rozdil.Minutes.ToString()+" Sekund: "+ rozdil.Seconds.ToString());

        }
    }
}
