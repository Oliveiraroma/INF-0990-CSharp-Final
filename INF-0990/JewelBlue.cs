/// <summary>
/// Classe reponsável pela Jóia Azul, pontuação e recarregar energia
/// </summary>
public class JewelBlue : Jewel, Rechargeable {
    
    /// <summary>
    /// Classe método que fornece energia para o robô
    /// </summary>
    public void Recharge(Robot r)
    {
        r.energy += 5;
    }

    public JewelBlue() : base("JB ", 10) {}
    
    // Retorna a cor desejada para a joia
    public override ConsoleColor GetForegroundColor()
    {
        return ConsoleColor.Blue;
    }
}