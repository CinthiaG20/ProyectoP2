namespace Library;

public class TiposAtk
{
    private string nombre;
    public string Nombre { get; set; }
    private double efectividad;
    public double Efectividad { get; set; }
    public void EfectividadAtk(string propio, string enemigo)
    {
      
    }

    public TiposAtk(string nombre, Pokemon propio, Pokemon enemigo)
    {
        this.Nombre = nombre;
        EfectividadAtk(propio.Tipo,enemigo.Tipo);
    }
}