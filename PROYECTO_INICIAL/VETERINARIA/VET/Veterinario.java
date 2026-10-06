public class Veterinario extends Persona {
    private int idVeterinario;
    private String especialidad;

    public Veterinario(String nombre, String telefono, String direccion, int idVeterinario, String especialidad) {
        super(nombre, telefono, direccion);
        this.idVeterinario = idVeterinario;
        this.especialidad = especialidad;
    }

    public void atenderConsulta() {
        System.out.println("Atendiendo consulta...");
    }

    public void diagnosticarMascota() {
        System.out.println("Diagnosticando mascota...");
    }

    public void prescribirTratamiento() {
        System.out.println("Prescribiendo tratamiento...");
    }
}
