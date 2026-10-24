//The reason why PlayerBuilder has strategies but CreatureBuilder doesn't is because strategies are only utilized when you need to choose how a number gets made (in this case, using a dice strategy to randomly choose different stats for the character). However, every creature type (like goblin) is that same type, with the same stats, and thus strategies are not necessary.


namespace TheWorld.GameMechanics;

public record CreatureBuilder
{
    private string _name = "YourMomMonster";
    private HealthPoints _healthPoints = HealthPoints.Create(40);
    private AbilityScore _abilities = AbilityScore.Create(10, 10, 10, 10, 10, 10)!;
    private int _experienceReward = 0;

    private CreatureBuilder()
    {
    }
    
    public static CreatureBuilder FromName(string name) => new() { _name = ValidateName(name) };
    
    private static string ValidateName(string name) =>
        name switch
        {
            var n when string.IsNullOrWhiteSpace(n) => "YourMomMonster",
            _ => name.Trim()
        };
    
    public CreatureBuilder WithHealthPoints(HealthPoints hp) => this with { _healthPoints = hp };
    public CreatureBuilder WithAbilities(AbilityScore abilities) => this with { _abilities = abilities };
    
    public CreatureBuilder WithExperienceReward(int xp) => this with { _experienceReward = xp};
    
    
    public Creature Build() => 
        Creature.Create(_name, _healthPoints, _abilities, _experienceReward);

}