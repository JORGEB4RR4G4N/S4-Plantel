namespace S4.Dominio.Comunes.InformaciónEquipos.ResultadosPlantel;

public class Resultado
{
    public int IdPartido { get; set; }
    public int? IdTiempoExtra { get; set; }
    public int? IdPenales { get; set; }
    public int IdTorneo { get; set; }
    public DateTime IncioPartido { get; set; }
    public DateTime FinPartido { get; set; }
    public int TiempoCompensacion { get; set; }
    public DateTime FechaPartido { get; set; }
}
