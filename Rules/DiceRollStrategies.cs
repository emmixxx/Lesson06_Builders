//first-class function: function that can be passed as a variable
//a higher-order function: function that builds a function - strategy that builds a bigger strategy, mix and matching it

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
    //dice roll strategy - function that takes a random number generator and gives back integer

    public static DiceRollStrategy ClampRoll(int minRoll = 8, int maxRoll = 18, DiceRollStrategy? strategy = null) =>
        (rng, dice) => //lambda expression that returns a method
            dice.Roll(rng, strategy ?? HighestOfThreeRolls) switch
            {
                var roll when roll < minRoll =>
                    ClampRoll(minRoll, maxRoll, strategy)(rng, dice), //recursive function: function that calls itself - a problem because this is an example of infinite recursion
                var roll when roll > maxRoll =>
                    ClampRoll(minRoll, maxRoll, strategy)(rng, dice),
                var roll => roll
            };
    //passing HighestOfThreeRolls function without parentheses (thus HighestOfThreeRolls is a first-class function)
    //returning DiceRollStrategy
    
}

