using TheWorld.GameMechanics;
using TheWorld.Display;
using TheWorld.GameMechanics.StockEntities;
using TheWorld.Rules;

using static TheWorld.Rules.DiceRollStrategies;

// This is the one Random Number Generator for the whole program.  We inject it everywhere a roll happens.
Random rng = new();

PlayerBuilder.FromName("Hardcore").WithAbilities(rng).Build().ShowSheet();
PlayerBuilder.FromName("Lucky")
    .WithAbilities(rng, Dice.D6 with { Count = 3 }, HighestOfThreeRolls)
    .Build().ShowSheet();

PlayerBuilder.FromName("Emmie").WithAbilities(rng, Dice.Coin, Default)
    .Build().ShowSheet();

// The party.  Bree is the wizard;  Tamsin is the fighter.
var bree = StockPlayers.Bree;
var tamsin = StockPlayers.Tamsin;

// What they're up against.
var goblin = StockCreatures.Goblin;

bree.ShowSheet();
tamsin.ShowSheet();
goblin.ShowSheet();

Console.WriteLine($"Tamsin swings at the goblin:  {tamsin.AttackBonus:+0;-0;+0} to hit, against AC {goblin.ArmorClass}.");
Console.WriteLine($"The goblin swings back:  {goblin.AttackBonus:+0;-0;+0} to hit, against AC {tamsin.ArmorClass}.");
Console.WriteLine(Dice.D6 with { Count = 0 });

