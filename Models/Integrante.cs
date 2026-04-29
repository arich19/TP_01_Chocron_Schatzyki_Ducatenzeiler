public class Integrante{
    private int DNI;
    private string nombre;
    private DateTime fechaNacimiento;
    private string foto;
    private List<string> listaFamiliares;
    private List<string> listaIntereses;

    public Integrante(int dni2,DateTime fechaNacimiento2, string foto2, string nombre2, List<string> listaFamiliares2, List<string> listaIntereses2){
        DNI = dni2;
        nombre = nombre2;
        fechaNacimiento = fechaNacimiento2;
        foto = foto2;
        listaFamiliares = listaFamiliares2;
        listaIntereses = listaIntereses2;
    } 
    public int getDni(){
        return DNI;
    }
    public string getNombre(){
        return nombre;
    }
    public DateTime getFechaNacimiento(){
        return fechaNacimiento;
    }
    public string getFoto(){
        return foto;
    }
    public List<string> getListaFamiliares(){
        return listaFamiliares;
    }
    public List<string> getListaIntereses(){
        return listaIntereses;
    }
}