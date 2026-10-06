namespace VetControlSystem.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona(string nombre, string telefono, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
