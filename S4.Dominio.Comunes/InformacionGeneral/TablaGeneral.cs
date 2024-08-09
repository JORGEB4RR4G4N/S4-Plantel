using S4.Dominio.Comunes.Enums;

namespace S4.Dominio.Comunes.InformacionGeneral;

public class TablaGeneral
{
    public int IdTablaGeneral { get; set; }
    public int IdTorneo { get; set; }
    public int Jugados { get; set; }
    public int Ganados { get; set; }
    public int Empatados { get; set; }
    public int Perdidos { get; set; }
    public int GolesAFavor { get; set; }
    public int GolesEnContra { get; set; }
    public int Diferencia { get { return GolesAFavor - GolesEnContra; } }
    public int Puntos { get { return Ganados * (int)EnumResultado.Ganado + (int)EnumResultado.Empate; } }
}
