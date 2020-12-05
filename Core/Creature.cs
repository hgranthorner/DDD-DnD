using System;
using System.Collections.Generic;

namespace Core
{
    public abstract class Creature
    {
    }

    public class Character : Creature
    {
        public Class Class { get; set; }
        public Subclass Subclass { get; set; }
        public Race Race { get; set; }
        public Alignment Alignment { get; set; }
        public Background Background { get; set; }
        public int Experience { get; set; }
        public int Proficiency { get; set; }
        public AbilityCollection AbilityCollection { get; set; }
        public SkillCollection Skills { get; set; }
    }

    public class SkillCollection : HashSet<Skill>
    {
    }

    public class Skill
    {
        public SkillName Name { get; set; }
        public bool Proficient { get; set; }
        public AbilityType BackingAbilityType { get; set; }
    }

    public enum AbilityType
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma,
    }

    public enum SkillName
    {
        Athletics,
        Acrobatics,
        SleightOfHand,
        Stealth,
        Arcana,
        History,
        Investigation,
        Nature,
        Religion,
        AnimalHandling,
        Insight,
        Medicine,
        Perception,
        Survival,
        Deception,
        Intimidation,
        Performance,
        Persuasion,
    }

    public record Skills();

    public class AbilityCollection : HashSet<Ability>
    {}

    public class Ability
    {
        public AbilityType Type { get; set; }
        public int Score { get; set; }
        public int Modifier => (int) Math.Floor((Score - 10.0) / 2);
    }

    public class Background
    {
    }

    public record Alignment(Morality Morality, Lawfulness Lawfulness);

    public enum Lawfulness
    {
        Lawful,
        Neutral,
        Chaotic
    }

    public enum Morality
    {
        Good,
        Neutral,
        Evil
    }

    public enum Race
    {
        Elf,
        Human,
    }

    public enum Subclass
    {
    }

    public enum Class
    {
        Artificer,
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard
    }
}