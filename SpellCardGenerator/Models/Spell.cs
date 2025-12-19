namespace SpellCardGenerator.Models;

public class Spell
{
    public int Id { get; set; }
    public int Level { get; set; }
    public required string Name { get; set; }
    public required string CastingTime { get; set; }
    public required string Duration { get; set; }
    public required string Range { get; set; }
    public string? Area { get; set; }
    public string? AttackSave { get; set; }
    public bool HasVocalComponent { get; set; } = false;
    public bool HasSomaticComponent { get; set; } = false;
    public string? MaterialComponent { get; set; }
    public bool IsRitual { get; set; } = false;
    public bool RequiresConcentration { get; set; } = false;
    public required string School { get; set; }
    public string? DamageEffect { get; set; }
    public required string Description { get; set; }
}