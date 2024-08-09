using S4.Dominio.Comunes.InformaciónEquipos.Jugadores;
using S4.Dominio.Comunes.InformaciónEquipos.Planteles;

namespace S4.Dominio.Comunes.ListItems;

public class PlantelListItem : Plantel
{
    public List<PlantelJugadores> jugadoresDelPlantel = new List<PlantelJugadores>();
    public string NombrePlantel { get; set; }
    public int Apariciones { get; set; }
    public int TotaleGoles { get; set; }
    public int Asistencias { get; set; }
    public int TirosAMeta { get; set; }
    public int FaltasCometidas { get; set; }
    public int FaltasSufridas { get; set; }
    public int TarjetasAmarillas { get; set; }
    public int TarjetaRoja { get; set; }
    public int GolesConcedidos { get; set; }
}
