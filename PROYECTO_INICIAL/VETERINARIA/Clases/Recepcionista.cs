namespace VetControlSystem.Clases
{
    public class Recepcionista : Persona
    {
        public int IdRecepcionista { get; set; }
        public string Turno { get; set; }

        public Recepcionista(string nombre, string telefono, string direccion,
                             int idRecepcionista, string turno)
            : base(nombre, telefono, direccion)
        {
            IdRecepcionista = idRecepcionista;
            Turno = turno;
        }

        public void RegistrarCita()
        {
            Console.WriteLine("Registrando cita...");
        }

        public void ActualizarDatosCliente()
        {
            Console.WriteLine("Actualizando datos del cliente...");
        }
    }
}
