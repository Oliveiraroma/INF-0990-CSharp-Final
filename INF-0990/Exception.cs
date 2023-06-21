/// <summary>
/// Classe responsável pelas exceções tanto nos casos de o robo tentar sair do mapa, posição ocupada e sem energia.
/// </summary>

/// <summary>
/// Classe responsável pela exceção no caso de o robo tentar sair do mapa
/// </summary>
public class OutOfMapException : Exception {}

/// <summary>
/// Classe responsável pela exceção no caso de o robo tentar ir para uma posição ocupada no mapa
/// </summary>
public class OccupiedPositionException : Exception {}

/// <summary>
/// Classe responsável pela exceção no caso de o robo ficar sem energia
/// </summary>
public class RanOutOfEnergyException : Exception {}
