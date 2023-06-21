/// <summary>
/// Classe responsável pelo itens do mapa, em específico os obstáculos.
/// </summary>
public abstract class Obstacle : ItemMap {
    public Obstacle(string Symbol) : base(Symbol) {}
    
    // Retorna a cor desejada para o Obstaculo
    public override ConsoleColor GetForegroundColor()
    {
        return ConsoleColor.DarkGray;
    }   
     
}