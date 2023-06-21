/// <summary>
/// Classe responsável pelas Jóias e contabilizar pontuação.
/// </summary>
public abstract class Jewel : ItemMap {
    public int Points {get; private set;}
    public Jewel(string Symbol, int Points) : base(Symbol)
    {
        this.Points = Points;
    //Define a cor da joia
    public override ConsoleColor GetForegroundColor()
    {
        return ConsoleColor.White;
    }
}