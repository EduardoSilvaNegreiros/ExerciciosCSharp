/*
 * Lucian's Luscious Lasagna
 *
 * 1. ExpectedMinutesInOven:
 *    Retorna o tempo esperado de cozimento no forno (40 minutos).
 *
 * 2. RemainingMinutesInOven:
 *    Retorna o tempo restante no forno, subtraindo o tempo já passado do tempo total esperado.
 *
 * 3. PreparationTimeInMinutes:
 *    Calcula o tempo de preparação da lasanha com base no número de camadas (cada camada leva 2 minutos).
 *
 * 4. ElapsedTimeInMinutes:
 *    Retorna o tempo total gasto na lasanha até o momento, somando o tempo de preparação e o tempo no forno.
 */

public class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesInOven) =>
        ExpectedMinutesInOven() - minutesInOven;

    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int minutesInOven) =>
        PreparationTimeInMinutes(layers) + minutesInOven;
}
