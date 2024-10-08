namespace Library;

public class TablaTipos
{
    private Dictionary<string, Tipo> tipos;

    public TablaTipos()
    {
        tipos = new Dictionary<string, Tipo>();
        InicializarTipos();
    }

    private void InicializarTipos()
    {
        var fuego = new Tipo("Fuego");
        fuego.AgregarEfectividad("Planta", 2.0);
        fuego.AgregarEfectividad("Agua", 0.5);
        fuego.AgregarEfectividad("Fuego", 1.0);
        fuego.AgregarEfectividad("Volador", 1.0);
        fuego.AgregarEfectividad("Roca", 0.5);
        fuego.AgregarEfectividad("Electrico", 1.0);
        tipos["Fuego"] = fuego;

        var agua = new Tipo("Agua");
        agua.AgregarEfectividad("Fuego", 2.0);
        agua.AgregarEfectividad("Planta", 0.5);
        agua.AgregarEfectividad("Agua", 1.0);
        agua.AgregarEfectividad("Volador", 1.0);
        agua.AgregarEfectividad("Roca", 2.0);
        agua.AgregarEfectividad("Electrico", 1.0);
        tipos["Agua"] = agua;
        
        var planta = new Tipo("Planta");
        planta.AgregarEfectividad("Planta", 1.0);
        planta.AgregarEfectividad("Agua", 2.0);
        planta.AgregarEfectividad("Fuego", 0.5);
        planta.AgregarEfectividad("Volador", 0.5);
        planta.AgregarEfectividad("Roca", 2.0);
        planta.AgregarEfectividad("Electrico", 1.0);
        tipos["Planta"] = planta;
        
        var volador = new Tipo("Volador");
        volador.AgregarEfectividad("Planta", 2.0);
        volador.AgregarEfectividad("Agua", 1.0);
        volador.AgregarEfectividad("Fuego", 1.0);
        volador.AgregarEfectividad("Volador", 1.0);
        volador.AgregarEfectividad("Roca", 0.5);
        volador.AgregarEfectividad("Electrico", 0.5);
        tipos["Volador"] = volador;
        
        var electrico = new Tipo("Electrico");
        electrico.AgregarEfectividad("Planta", 0.5);
        electrico.AgregarEfectividad("Agua", 2.0);
        electrico.AgregarEfectividad("Fuego", 1.0);
        electrico.AgregarEfectividad("Volador",2.0);
        electrico.AgregarEfectividad("Roca",0.0);
        electrico.AgregarEfectividad("Electrico",0.5);
        tipos["Electrico"] = electrico;
        
        var roca = new Tipo("Roca");
        roca.AgregarEfectividad("Planta", 1.0);
        roca.AgregarEfectividad("Agua", 1.0);
        roca.AgregarEfectividad("Fuego", 2.0);
        roca.AgregarEfectividad("Volador",2.0);
        roca.AgregarEfectividad("Roca",1.0);
        roca.AgregarEfectividad("Electrico",1.0);
        tipos["Roca"] = roca;
    }

    public double ObtenerEfectividad(string tipoAtacante, string tipoDefensor)
    {
        if (tipos.ContainsKey(tipoAtacante) && tipos[tipoAtacante].Efectividad.ContainsKey(tipoDefensor))
        {
            return tipos[tipoAtacante].Efectividad[tipoDefensor];
        }
        return 1.0;
    }
}
