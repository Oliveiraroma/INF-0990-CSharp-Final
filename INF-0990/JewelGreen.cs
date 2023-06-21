/// <summary>
/// Classe reponsável pela Jóia Verde e pontuação.
/// </summary>
public class JewelGreen : Jewel {
    public JewelGreen() : base("JG ", 50){}
   
    // Retorna a cor desejada para a joia
    public override ConsoleColor GetForegroundColor()
    {
        return ConsoleColor.Green;
    }
}