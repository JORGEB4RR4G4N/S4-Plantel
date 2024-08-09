namespace S4.Dominio.Comunes.Catalogos;

public class Torneo
{
    public int IdTorneo { get; set; }
    public string NombreTorneo { get; set; }
    public string Temporada { get; set; }
    public DateTime IncioTorneo { get; set; }
    public DateTime FinTorneo { get; set; }

}
