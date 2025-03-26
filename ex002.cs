/*
 * Tarefa 1:
 * Implementar o método CanFastAttack que recebe um booleano indicando se o cavaleiro está acordado.
 * Retorna true se um ataque rápido pode ser feito (ou seja, se o cavaleiro está dormindo).
 *
 * Tarefa 2:
 * Implementar o método CanSpy que recebe três booleanos indicando se o cavaleiro, o arqueiro e o prisioneiro estão acordados.
 * Retorna true se for possível espionar (ou seja, se pelo menos um deles estiver acordado).
 *
 * Tarefa 3:
 * Implementar o método CanSignalPrisoner que recebe dois booleanos indicando se o arqueiro e o prisioneiro estão acordados.
 * Retorna true se o prisioneiro pode ser sinalizado (ou seja, se o arqueiro está dormindo e o prisioneiro está acordado).
 *
 * Tarefa 4:
 * Implementar o método CanFreePrisoner que recebe quatro booleanos indicando se o cavaleiro, o arqueiro e o prisioneiro estão acordados,
 * além de um quarto parâmetro indicando se o cachorro de Annalyn está presente.
 * O prisioneiro pode ser libertado se:
 * - O cachorro está presente e o arqueiro está dormindo.
 * - O cachorro está ausente, mas o prisioneiro está acordado, e os outros dois (cavaleiro e arqueiro) estão dormindo.
 */

static class QuestLogic
{
  public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

  public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) =>
      knightIsAwake || archerIsAwake || prisonerIsAwake;

  public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) =>
      prisonerIsAwake && !archerIsAwake;

  public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) =>
      (petDogIsPresent && !archerIsAwake) ||
      (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake);
}
