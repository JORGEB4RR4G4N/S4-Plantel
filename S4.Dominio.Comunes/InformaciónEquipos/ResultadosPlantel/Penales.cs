namespace S4.Dominio.Comunes.InformaciónEquipos.ResultadosPlantel;

public class Penales
{
    public int IdPenales { get; set; }
    public int IdEquipo { get; set; }
    public bool Gol { get; set; }
    public DateTime FechaPartido { get; set; }
}
