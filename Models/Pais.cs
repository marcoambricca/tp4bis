public class Pais{
    public string Nombre{get;set;}
    public string imgBandera{get;set;}
    public int poblacion{get;set;}
    public DateTime fechaIndependencia{get;set;}
    public string atractivosTuristicos{get;set;}

    public Pais(string nom, string imgban, int pob, DateTime fecha, string atracturis){
        Nombre = nom;
        imgBandera = imgban;
        poblacion = pob;
        fechaIndependencia = fecha;
        atractivosTuristicos = atracturis;
    }
}