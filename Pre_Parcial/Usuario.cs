namespace Pre_Parcial
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public bool admin { get; set; }

        public Usuario()
        {
            usuario = "";
            contraseña = "";
            admin = false;
        }
    }
}