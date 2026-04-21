public class Integrantes{
    private int DNI;
    private string nombre;
    private DateTime fechaNacimiento;
    private string foto;
    private List<string> listaFamiliares;
    private List<string> listaIntereses;

    public Integrantes(int dni2,DateTime fechaNacimiento2, string foto2, string nombre2, List<string> listaFamiliares2, list<string> listaIntereses2){
        dni = dni2;
        nombre = nombre2;
        fechaNacimiento = fechaNacimiento2;
        foto = foto2;
        listaFamiliares = listaFamiliares2;
        listaIntereses = listaIntereses;
    }
    
}