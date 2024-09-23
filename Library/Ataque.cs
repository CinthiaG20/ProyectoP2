namespace Library;

public class Ataque
{
    private string nombre;
    public string Nombre { get; set; }
    private TiposAtk tipo;
    public TiposAtk Tipo { get; set; }
    private bool esEspecial;
    public bool EsEspecial { get; set; }

    public Ataque(string nombre,TiposAtk tipo,bool esEspecial)
    {
        this.Nombre = nombre;
        this.Tipo = tipo;
        this.EsEspecial = esEspecial;
    }
}