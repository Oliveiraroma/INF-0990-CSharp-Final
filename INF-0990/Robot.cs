/// <summary>
/// Classe responsável pelo robo, sua interação com o mapa e os itens.
/// </summary>
public class Robot : ItemMap {
    public Map map {get; private set;}
    private int x, y;
    private List<Jewel> Bag = new List<Jewel>();
    public int energy {get; set;}
    
    /// <summary>
    /// Responsável por colocar o robo em sua posição inicial, atribuir energia que inicia o nível.
    /// </summary>
    public Robot(Map map, int x=0, int y=0, int energy=5) : base("ME "){
        this.map = map;
        this.x = x;
        this.y = y;
        this.energy = energy;
        this.map.Insert(this, x, y);
    }
    /// <summary>
    /// Responsável pela movimentação.
    /// </summary>
    public void MoveNorth(){
        try
        {
            IsRadioactiveIn(this.x-1, this.y);
            map.Update(this.x, this.y, this.x-1, this.y);
            this.x--;
            this.energy--;
            IsRadioactiveAdjacent(this.x, this.y);        
        }
        catch (OccupiedPositionException e)
        {
            Console.WriteLine($"\nPosition {this.x-1}, {this.y} is occupied");
        }
        catch (OutOfMapException e)
        {
            Console.WriteLine($"\nPosition {this.x-1}, {this.y} is out of map");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nPosition is prohibit");
        }
    }
    /// <summary>
    /// Responsável pela movimentação.
    /// </summary>
    public void MoveSouth(){
        try
        {
            IsRadioactiveIn(this.x+1, this.y);
            map.Update(this.x, this.y, this.x+1, this.y);
            this.x++;
            this.energy--;
            IsRadioactiveAdjacent(this.x, this.y);  
        }
        catch (OccupiedPositionException e)
        {
            Console.WriteLine($"\nPosition {this.x+1}, {this.y} is occupied");
        }
        catch (OutOfMapException e)
        {
            Console.WriteLine($"\nPosition {this.x+1}, {this.y} is out of map");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nPosition is prohibit");
        }
    }
    /// <summary>
    /// Responsável pela movimentação.
    /// </summary>
    public void MoveEast(){
        try
        {  
            IsRadioactiveIn(this.x, this.y+1);
            map.Update(this.x, this.y, this.x, this.y+1);
            this.y++;
            this.energy--;
            IsRadioactiveAdjacent(this.x, this.y);     
        }
        catch (OccupiedPositionException e)
        {
            Console.WriteLine($"\nPosition {this.x}, {this.y+1} is occupied");
        }
        catch (OutOfMapException e)
        {
            Console.WriteLine($"\nPosition {this.x}, {this.y+1} is out of map");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nPosition is prohibit");
        }
    }
    /// <summary>
    /// Responsável pela movimentação.
    /// </summary>
    public void MoveWest(){
        try
        { 
            IsRadioactiveIn(this.x, this.y-1);
            map.Update(this.x, this.y, this.x, this.y-1);
            this.y--;
            this.energy--;
            IsRadioactiveAdjacent(this.x, this.y);
        }
        catch (OccupiedPositionException e)
        {
            Console.WriteLine($"\nPosition {this.x}, {this.y-1} is occupied");
        }
        catch (OutOfMapException e)
        {
            Console.WriteLine($"\nPosition {this.x}, {this.y-1} is out of map");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nPosition is prohibit");
        }
    }
    /// <summary>
    /// Responsável por recarregar a energia do robo.
    /// </summary>
    public void Get(){
        //Console.Clear();
        Rechargeable? RechargeEnergy = map.GetRechargeable(this.x, this.y);
        RechargeEnergy?.Recharge(this);
        List<Jewel> NearJewels = map.GetJewels(this.x, this.y);
        foreach (Jewel j in NearJewels)
            Bag.Add(j);
    }
    /// <summary>
    /// Responsável por contar a quantidade de pontos.
    /// </summary>
    private (int, int) GetBagInfo()
    {
        int Points = 0;
        foreach (Jewel j in this.Bag)
            Points += j.Points;
        return (this.Bag.Count, Points);
    }
    /// <summary>
    /// Responsável por imprimir a quantidade de itens, pontos e energia.
    /// </summary>
    public void Print()
    {
        map.Print();
        (int ItensBag, int TotalPoints) = this.GetBagInfo();
        Console.WriteLine($"\nItens Bag: {ItensBag} - Total Points: {TotalPoints} - Energy: {this.energy} - x:{this.x}, y: {this.y}\n\n");
    }
    public bool HasEnergy()
    {
        return this.energy > 0;
    }
    /// <summary>
    /// Responsável por decrementar energia quando passar por cima de radioativo.
    /// </summary>
    public void IsRadioactiveIn(int x, int y)
    {
        // Decrementa energia quando passa por cima do elemento radioativo
        if (map.IsRadioactive(x,y))
        {
            energy -= 30;
        }
    }
    /// <summary>
    /// Responsável por decrementar energia quando passar adjacente a item radioativo.
    /// </summary>
    public void IsRadioactiveAdjacent(int x, int y)
    {
        // Decrementa energia quando elemento radioativo esta acima
        if (map.IsRadioactive(x, y - 1))
        {
            energy -= 10;
        }          

        // Decrementa energia quando elemento radioativo esta abaixo
        if (map.IsRadioactive(x, y + 1))
        {
            energy -= 10;
        }

        // Decrementa energia quando elemento radioativo esta à esquerda
        if (map.IsRadioactive(x - 1, y))
        {
            energy -= 10;
        }

        // Decrementa energia quando elemento radioativo esta à direita
        if (map.IsRadioactive(x + 1, y))
        {
            energy -= 10;
        }

    }
}