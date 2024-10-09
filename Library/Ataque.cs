namespace Library;

public class Ataque
{
    private string nombre;
    public string Nombre { get; set; }
    private string tipo;
    public string Tipo { get; set; }
    private bool esEspecial;
    public bool EsEspecial { get; set; }

    public Ataque(string nombre,string tipo,bool esEspecial)
    {
        this.Nombre = nombre;
        this.Tipo = tipo;
        this.EsEspecial = esEspecial;
    }
}