namespace S4.Dominio.Comunes.InformaciónEquipos.ResultadosPlantel;
public class Partido
{
    public int IdPartido { get; set; }
    public int IdEquipoLocal { get; set; }
    public int IdPartidoGolesPlantel { get; set; }
    public int IdEquipoVisitante { get; set; }
    public int GolesVisitante { get; set; }
    public int TiempoCompensacionPartido { get; set; }
    public DateTime FechaPartido { get; set; }

}
