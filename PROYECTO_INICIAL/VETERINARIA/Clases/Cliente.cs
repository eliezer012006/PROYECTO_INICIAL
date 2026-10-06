namespace VetControlSystem.Clases
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string Correo { get; set; }

        public Cliente(string nombre, string telefono, string direccion,
                       int idCliente, string correo)
            : base(nombre, telefono, direccion)
        {
            IdCliente = idCliente;
            Correo = correo;
        }

        public void SolicitarCita()
        {
            Console.WriteLine("Solicitando cita...");
        }

        public void RegistrarMascota()
        {
            Console.WriteLine("Registrando mascota...");
        }

        public void PagarServicios()
        {
            Console.WriteLine("Pagando servicios...");
        }
    }
}
