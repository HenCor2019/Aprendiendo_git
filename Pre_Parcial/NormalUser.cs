using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Pre_Parcial
{
    public partial class NormalUser : UserControl
    {
        public NormalUser()
        {
            InitializeComponent();
        }


        private void NormalUser_Load(object sender, EventArgs e)
        {
            var art = ConectionBD.ExecuteQuery("SELECT nombre FROM ARTICULO");
            var artCombo = new List<string>();

            foreach (DataRow row in art.Rows)
            {
                artCombo.Add(row[0].ToString());
            }
            comboBox3.DataSource = artCombo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sk = ConectionBD.ExecuteQuery($"SELECT stockActual FROM INVENTARIO " +
                                                  $"WHERE nombre='{comboBox3.SelectedItem.ToString()}'");
                var stk = sk.Rows[0];
                int stockActual = Convert.ToInt32(stk[0].ToString());
                int cant = Convert.ToInt32(textBox1.Text);
                int total = stockActual - cant;
            
                if (total>=0 && cant>0)
                {
                    ConectionBD.ExecuteNonQuery($"UPDATE INVENTARIO " +
                                                $"SET stockActual={total} " +
                                                $"WHERE nombre='{comboBox3.SelectedItem.ToString()}");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void NormalUser_Load_1(object sender, EventArgs e)
        {
            try
            {
                var dt = ConectionBD.ExecuteQuery($"SELECT idRegistro.idr,  " +
                                                  $"FROM " +
                                                  $"WHER ");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}