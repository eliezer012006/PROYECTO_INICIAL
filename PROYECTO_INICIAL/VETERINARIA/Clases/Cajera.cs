namespace VetControlSystem.Clases
{
    public class Cajera : Persona
    {
        public int IdCajera { get; set; }
        public string Turno { get; set; }

        public Cajera(string nombre, string telefono, string direccion,
                      int idCajera, string turno)
            : base(nombre, telefono, direccion)
        {
            IdCajera = idCajera;
            Turno = turno;
        }

        public void GenerarFactura()
        {
            Console.WriteLine("Generando factura...");
        }

        public void ProcesarPago()
        {
            Console.WriteLine("Procesando pago...");
        }
    }
}
