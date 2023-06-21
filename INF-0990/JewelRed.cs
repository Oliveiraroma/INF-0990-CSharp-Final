/// <summary>
/// Classe reponsável pela Jóia Vermelha e pontuação.
/// </summary>
public class JewelRed : Jewel{
    public JewelRed() : base("JR ", 100){}

    // Retorna a cor desejada para a joia
    public override ConsoleColor GetForegroundColor()
    {
        return ConsoleColor.Red;
    }
}