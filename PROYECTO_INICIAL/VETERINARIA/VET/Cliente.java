public class Cliente extends Persona {
    private int idCliente;
    private String correo;

    public Cliente(String nombre, String telefono, String direccion, int idCliente, String correo) {
        super(nombre, telefono, direccion);
        this.idCliente = idCliente;
        this.correo = correo;
    }

    public void solicitarCita() {
        System.out.println("Solicitando cita...");
    }

    public void registrarMascota() {
        System.out.println("Registrando mascota...");
    }

    public void pagarServicios() {
        System.out.println("Pagando servicios...");
    }
}
