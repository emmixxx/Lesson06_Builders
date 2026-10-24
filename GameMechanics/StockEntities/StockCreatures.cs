namespace TheWorld.GameMechanics.StockEntities;

public static class StockCreatures
{
    public static Creature Goblin =>
        CreatureBuilder.FromName("Goblin")
            .WithHealthPoints(HealthPoints.Create(7))
            .WithAbilities(AbilityScore.Create(8, 14, 10, 10, 8, 8)!)
            .WithExperienceReward(50)
            .Build();
    
    public static Creature Cat =>
        CreatureBuilder.FromName("Cat")
            .WithHealthPoints(HealthPoints.Create(1000000))
            .WithAbilities(AbilityScore.Create(9, 11, 17, 13, 18, 18)!)
            .WithExperienceReward(300)
            .Build();
    
    public static Creature Blobfish =>
        CreatureBuilder.FromName("Blobfish")
            .WithHealthPoints(HealthPoints.Create(1))
            .WithAbilities(AbilityScore.Create(3, 4, 10, 1, 1, 2)!)
            .WithExperienceReward(4)
            .Build();
}