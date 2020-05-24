using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace Pre_Parcial
{
    public partial class Logins : UserControl
    {
        public Logins()
        {
            InitializeComponent();
        }

        private void Logins_Load(object sender, EventArgs e)
        {
            var users = ConectionBD.ExecuteQuery("SELECT usuario FROM USUARIO");
            var usersCombo = new List<String>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }
            comboBox1.DataSource = usersCombo;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Este método será que cuando le des enter, pase a los formularios
            //if ()
            //{
            //}
        }
    }
}