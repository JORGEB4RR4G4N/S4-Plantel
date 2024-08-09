namespace S4.Dominio.Comunes.InformaciónEquipos.ResultadosPlantel;

public class TiempoExtra
{
    public int IdTiempoExtra { get; set; }
    public int GolesLocal { get; set; }
    public int GolesVisitante { get; set; }
    public int TiempoCompensacionTiempoExtra { get; set; }
    public DateTime FechaPartido { get; set; }
}
