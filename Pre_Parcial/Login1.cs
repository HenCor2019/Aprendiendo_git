using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var passw = ConectionBD.ExecuteQuery($"SELECT contraseña FROM Usuario " +
                                                     $"WHERE usuario='{comboBox1.SelectedItem.ToString()}'");
                var passWd = passw.Rows[0];
                String passWord = passWd[0].ToString();
                label3.Text = passWord;

                if (textBox1.Text == passWord)
                {
                    var ad = ConectionBD.ExecuteQuery($"SELECT admins FROM USUARIO " +
                                                      $"WHERE usuario='{comboBox1.SelectedItem.ToString()}'");
                    var adm = ad.Rows[0];
                    bool admin = Convert.ToBoolean(adm[0].ToString());

                    if (admin == true)
                    {
                        Form1 win = new Form1();
                        win.Show();
                        this.Hide();
                    }

                    else
                    {
                        Form2 win2 = new Form2();
                        win2.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void Login1_Load_1(object sender, EventArgs e)
        {
            var users = ConectionBD.ExecuteQuery("SELECT usuario FROM USUARIO");
            var usersCombo = new List<string>();

            foreach (DataRow row in users.Rows)
            {
                usersCombo.Add(row[0].ToString());
            }
            comboBox1.DataSource = usersCombo;
        }
    }
}