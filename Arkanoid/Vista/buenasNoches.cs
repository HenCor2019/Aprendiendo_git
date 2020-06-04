using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class buenasNoches : UserControl
    {
        public buenasNoches()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            label1.Text = "Pensaste que te iba a desear buenas noches";
            label2.Text = "Pero era yo Dio";
        }
    }
}