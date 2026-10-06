public class Cajera extends Persona {
    private int idCajera;
    private String turno;

    public Cajera(String nombre, String telefono, String direccion, int idCajera, String turno) {
        super(nombre, telefono, direccion);
        this.idCajera = idCajera;
        this.turno = turno;
    }

    public void generarFactura() {
        System.out.println("Generando factura...");
    }

    public void procesarPago() {
        System.out.println("Procesando pago...");
    }
}
