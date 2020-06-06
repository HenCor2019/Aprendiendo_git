using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arkanoid.Controlador;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            DoubleBuffered = true;
        }

        protected override void WndProc(ref Message m)
        {
            const int wmSyscommand = 0x0112;
            const int scMove = 0xF010;
            const int wmNclbuttondblclk = 0x00A3;

            switch(m.Msg)
            {
                case wmSyscommand:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == scMove)
                        return;
                    break;
            }
            
            if (m.Msg == wmNclbuttondblclk)
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            BackgroundImage = Properties.Resources.background;
            //Agregando componente al panel mediante la clase controladora
            PanelControlator.panel1 = this.panel1;
            PanelControlator.panel1.Controls.Add(PanelControlator.menu);
            PanelControlator.uc = PanelControlator.menu;
            watch.Stop();
            MessageBox.Show($"Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}