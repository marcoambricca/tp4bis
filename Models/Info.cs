public static class Info{
    public static List<Pais> Paises = new List<Pais>();

    public static void InicializarLista(){
        Pais españa = new Pais("España", "/img/España.jpg", 50, DateTime.Parse("14/10/1400"), "Bernabeu");
        Pais japon = new Pais("Japon", "/img/Japon.jpg", 80, DateTime.Parse("6/8/1200"), "tokio");
        Pais argentina = new Pais("Argentina", "/img/Argentina.jpg", 45, DateTime.Parse("25/05/1910"), "avellaneda");
        Pais peru = new Pais("Peru", "/img/Peru.jpg", 15, DateTime.Parse("12/05/1990"), "machupichu");
        Pais alemania = new Pais("Alemania", "/img/Alemania.jpg", 60, DateTime.Parse("22/10/1800"), "berlin");
        Paises.Add(españa);
        Paises.Add(japon);
        Paises.Add(argentina);
        Paises.Add(peru);
        Paises.Add(alemania);
    }
    public static List<Pais> ListarPaises(){
        if(Paises.Count<1){
            InicializarLista();
        } 
        return Paises;
    }

    public static Pais DetallePais(string pais){
        bool seEncontro = false;
        int i = 0;
        while(seEncontro == false && i<Paises.Count){
            if(Paises[i].Nombre == pais){
                seEncontro = true;
            }else{
                i++;
            }
        }
        return Paises[i];
    }
}