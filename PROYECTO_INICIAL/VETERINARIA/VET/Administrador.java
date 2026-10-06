public class Administrador extends Persona {
    private int idAdministrador;
    private String usuario;
    private String contrasena;

    public Administrador(String nombre, String telefono, String direccion, int idAdministrador, String usuario, String contrasena) {
        super(nombre, telefono, direccion);
        this.idAdministrador = idAdministrador;
        this.usuario = usuario;
        this.contrasena = contrasena;
    }

    public void gestionarEmpleados() {
        System.out.println("Gestionando empleados...");
    }

    public void administrarInventario() {
        System.out.println("Administrando inventario...");
    }

    public void generarReportes() {
        System.out.println("Generando reportes...");
    }
}
