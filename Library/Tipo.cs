namespace Library;

public class Tipo
{ 
    public string Nombre { get; set; }
    public Dictionary<string, double> Efectividad { get; set; } 
    
    public Tipo(string nombre)
    {
        Nombre = nombre;
        Efectividad = new Dictionary<string, double>();
    }

    public void AgregarEfectividad(string tipo, double multiplicador) 
    {
        Efectividad[tipo] = multiplicador; 
    }
}