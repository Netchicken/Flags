using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void pbxPulau_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Pulau";
        }

        private void pbxMarshallIslands_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Marshall Islands";
        }

        private void pbxNZ_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Aotearoa New Zealand";
        }
    }
}
