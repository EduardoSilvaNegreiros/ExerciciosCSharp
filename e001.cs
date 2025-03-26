Lucian's Luscious Lasagna

public class Lasagna
{
    // 1. Define the expected oven time in minutes
    // O primeiro passo é definir o tempo esperado que a lasanha deve ficar no forno. 
    // O livro de receitas especifica que o tempo esperado é de 40 minutos.
    // O método ExpectedMinutesInOven não recebe parâmetros e retorna esse valor fixo de 40 minutos.
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // 2. Calculate the remaining oven time in minutes
    // O segundo passo é calcular o tempo restante que a lasanha precisa ficar no forno. 
    // O método RemainingMinutesInOven recebe como parâmetro o tempo que a lasanha já está no forno.
    // Ele retorna o tempo que ainda falta, subtraindo o tempo passado no forno do tempo total esperado (40 minutos).
    public int RemainingMinutesInOven(int minutesInOven)
    {
        return ExpectedMinutesInOven() - minutesInOven;
    }

    // 3. Calculate the preparation time in minutes
    // O terceiro passo é calcular o tempo gasto no preparo da lasanha. 
    // O método PreparationTimeInMinutes recebe como parâmetro o número de camadas adicionadas à lasanha.
    // Cada camada leva 2 minutos para ser preparada, então o tempo de preparação total é o número de camadas multiplicado por 2.
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // 4. Calculate the elapsed time in minutes
    // O quarto e último passo é calcular o tempo total que você já trabalhou na lasanha até o momento.
    // O método ElapsedTimeInMinutes recebe dois parâmetros:
    // 1. O número de camadas que você adicionou à lasanha, para calcular o tempo de preparação.
    // 2. O número de minutos que a lasanha já está no forno.
    // O resultado é a soma do tempo de preparação e do tempo que a lasanha já ficou no forno.
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return PreparationTimeInMinutes(layers) + minutesInOven;
    }



}