
namespace S4.Dominio.Comunes.InformaciónEquipos.ResultadosPlantel;

public class GolesPlantel
{
    public int IdGolPlantel { get; set; }
    public int IdPartido { get; set; }
    public int IdJugador { get; set; }
    public DateTime TiempoGolaAnotado { get; set; }
    public int IdTipoGol { get; set; }
}
