/// <summary>
/// Classe reponsável pelo item Radioativo.
/// </summary>
public class Radioactive : ItemMap
{
    public Radioactive() : base("!! "){}
    
    // Retorna a cor de fundo desejada para o Item Radioativo
    public override ConsoleColor GetBackgroundColor()
    {
        return ConsoleColor.Black;
    }
    // Retorna a cor desejada para o Item Radioativo
    public override ConsoleColor GetForegroundColor()
    {
        return ConsoleColor.DarkMagenta;
    }
}