namespace VetControlSystem.Clases
{
    public class Administrador : Persona
    {
        public int IdAdministrador { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public Administrador(string nombre, string telefono, string direccion,
                             int idAdministrador, string usuario, string contrasena)
            : base(nombre, telefono, direccion)
        {
            IdAdministrador = idAdministrador;
            Usuario = usuario;
            Contrasena = contrasena;
        }

        public void GestionarEmpleados()
        {
            Console.WriteLine("Gestionando empleados...");
        }

        public void AdministrarInventario()
        {
            Console.WriteLine("Administrando inventario...");
        }

        public void GenerarReportes()
        {
            Console.WriteLine("Generando reportes...");
        }
    }
}
