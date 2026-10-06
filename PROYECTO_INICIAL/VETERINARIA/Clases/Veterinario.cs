namespace VetControlSystem.Clases
{
    public class Veterinario : Persona
    {
        public int IdVeterinario { get; set; }
        public string Especialidad { get; set; }

        public Veterinario(string nombre, string telefono, string direccion,
                           int idVeterinario, string especialidad)
            : base(nombre, telefono, direccion)
        {
            IdVeterinario = idVeterinario;
            Especialidad = especialidad;
        }

        public void AtenderConsulta()
        {
            Console.WriteLine("Atendiendo consulta...");
        }

        public void DiagnosticarMascota()
        {
            Console.WriteLine("Diagnosticando mascota...");
        }

        public void PrescribirTratamiento()
        {
            Console.WriteLine("Prescribiendo tratamiento...");
        }
    }
}
