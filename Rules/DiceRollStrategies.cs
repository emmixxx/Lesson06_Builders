using TheWorld.GameMechanics;

namespace TheWorld.Rules;

public static class DiceRollStrategies
{
    /// <summary>
    /// Just roll the damn thing.
    /// </summary>
    public static int Default(Random rng, Dice dice) => dice.Roll(rng);
    
    /// <summary>
    /// Roll twice and keep the Higher.
    /// </summary>
    public static int Advantage(Random rng, Dice dice) =>
        Enumerable.Range(0, 2)
            .Select(_ => dice.Roll(rng))
            .Max();
    public static int HighestOfThreeRolls(Random rng, Dice dice)=>
        Enumerable.Range(0,3)
    .Select(_ => dice.Roll(rng))
            .Max();
}

