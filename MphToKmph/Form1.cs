using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MphToKmph
{
    public partial class MphToKMph : Form
    {
        public MphToKMph()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double MPH = Convert.ToDouble(tbMph.Text);
            double KMPH = MPH * 0.44704 * 3600 / 1000;
            lbKMph.Text = Convert.ToString(KMPH);
        }
    }
}
