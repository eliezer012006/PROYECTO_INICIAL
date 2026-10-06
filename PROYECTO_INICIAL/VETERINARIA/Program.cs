using System;
using VetControlSystem.Clases;

namespace VetControlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema Veterinaria ===\n");

            // Crear objetos principales
            Administrador admin = new Administrador("Carlos", "555-1234", "Zona 1", 1, "admin01", "1234");
            Veterinario vet = new Veterinario("Ana", "555-5678", "Zona 2", 101, "Pequeños animales");
            Recepcionista recep = new Recepcionista("Luis", "555-9876", "Zona 3", 201, "Mañana");
            Cajera cajera = new Cajera("María", "555-4567", "Zona 4", 301, "Tarde");
            Cliente cliente = new Cliente("Eliezer", "555-0000", "Zona 5", 401, "eliezer@mail.com");

            // Flujo del sistema
            Console.WriteLine("\n--- Flujo de trabajo ---");

            cliente.SolicitarCita();
            recep.RegistrarCita();

            vet.AtenderConsulta();
            vet.DiagnosticarMascota();
            vet.PrescribirTratamiento();

            cajera.GenerarFactura();
            cajera.ProcesarPago();
            cliente.PagarServicios();

            admin.GestionarEmpleados();
            admin.AdministrarInventario();
            admin.GenerarReportes();

            Console.WriteLine("\n=== Fin del flujo de trabajo ===");
        }
    }
}
