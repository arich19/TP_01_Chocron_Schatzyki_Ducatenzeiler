public class Grupo{
    Dictionary<int, Integrante> dicIntegrantes = new Dictionary<int, Integrante>();

public Grupo(){
    CargaDatosManual();
}

private void CargaDatosManual()
{
    List<string> familiaAri = new List<string>();
    familiaAri.Add("Mamá sandra");
    familiaAri.Add("Papá sergio");
    familiaAri.Add("Hermano ilan");
    List<string> interesesAri = new List<string>();
    interesesAri.Add("juntarme con amigos");
    interesesAri.Add("jugar a la compu");
    interesesAri.Add("ver peliculas");
    List<string> familiaLucas = new List<string>();
    familiaLucas.Add("Mamá myriam");
    familiaLucas.Add("Papá diego");
    familiaLucas.Add("Hermano bruno");
    List<string> interesesLucas = new List<string>();
    interesesLucas.Add("futbol");
    interesesLucas.Add("jugar a la compu");
    interesesLucas.Add("ver series");
    interesesLucas.Add("escuchar musica");
    List<string> familiaTobi = new List<string>();
    familiaTobi.Add("Mamá silvia");
    familiaTobi.Add("Papá adrian");
    familiaTobi.Add("Hermano sacho");
    List<string> interesesTobi = new List<string>();
    interesesTobi.Add("futbol");
    interesesTobi.Add("jugar a la compu");
    interesesTobi.Add("ver series");
    interesesTobi.Add("escuchar musica");
    dicIntegrantes.Add(49980088, new Integrante(49980088, new DateTime(2010, 1, 1), "/img/Lucas.png", "Lucas", familiaLucas, interesesLucas));
    dicIntegrantes.Add(49628292, new Integrante(49628292, new DateTime(2009, 7, 19), "/img/Chocron.png", "Ari", familiaAri, interesesAri));
    dicIntegrantes.Add(50104466, new Integrante(50104466, new DateTime(2010, 2, 3), "/img/Tobi.png", "Tobi", familiaTobi, interesesTobi));
}
public Dictionary<int, Integrante> devolverIntegrantes(){

    return dicIntegrantes;
}
public Integrante getIntegrante(int dni)
    {
        Integrante integrante;
        bool x;
    
     x = dicIntegrantes.ContainsKey(dni);
     if(x)
     {
        integrante = dicIntegrantes[dni];
        return integrante;
     }
    
    return null;
}
}
