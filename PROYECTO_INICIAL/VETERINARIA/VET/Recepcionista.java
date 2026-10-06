public class Recepcionista extends Persona {
    private int idRecepcionista;
    private String turno;

    public Recepcionista(String nombre, String telefono, String direccion, int idRecepcionista, String turno) {
        super(nombre, telefono, direccion);
        this.idRecepcionista = idRecepcionista;
        this.turno = turno;
    }

    public void registrarCita() {
        System.out.println("Registrando cita...");
    }

    public void actualizarDatosCliente() {
        System.out.println("Actualizando datos del cliente...");
    }
}
