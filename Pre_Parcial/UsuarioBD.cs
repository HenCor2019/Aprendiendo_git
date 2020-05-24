using System;
using System.Collections.Generic;
using System.Data;

namespace Pre_Parcial
{
    public static class UsuarioBD
    {
        public static List<Usuario> getLista()
        {
            var table = ConectionBD.ExecuteQuery("SELECT * FROM USUARIO");
            var tableFill = new List<Usuario>();

            foreach (DataRow row in table.Rows)
            {
                Usuario u = new Usuario();
                u.usuario = row[0].ToString();
                u.contraseña = row[1].ToString();
                u.admin = Convert.ToBoolean(row[2].ToString());
                tableFill.Add(u);
            }

            return tableFill;
        }
    }
}