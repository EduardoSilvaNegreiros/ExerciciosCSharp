using system;

class Lasagna {
  public int ExpectedMinutesInOven() => 40;

  public int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;

  public int PreparationTimeInMinutes(int layers) => layers * 2;

  public int ElapsedTimeInMinutes(int layers, int timeInOven) => PreparationTimeInMinutes(layers) + timeInOven;
}