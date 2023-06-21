/// <summary>
/// Classe responsável pelo item do mapa árvore
/// </summary>
public class Tree : Obstacle, Rechargeable {
    /// <summary>
    /// Atribui simbolo da árvore.
    /// </summary>
    public Tree() : base("$$ ") {}
    /// <summary>
    /// Incrementa energia ao pressionar "G" junto a árvore.
    /// </summary>
    public void Recharge(Robot r)
    {
        r.energy += 3;
    }

    // Retorna a cor desejada para a Arvore
    public override ConsoleColor GetForegroundColor()
    {
        return ConsoleColor.DarkYellow;
    }
}