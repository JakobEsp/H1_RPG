
namespace H1_RPGProj
{
    class Character
    {
        private int level;
        private string playerName;
        private string characterClass;
        private string race;
        private DateTime birthDate;
        private TimeSpan age;
        private Stats stats;

        public Character(int level, string playerName, string characterClass, string race, DateTime birthDate, Stats stats)
        {
            this.level = level;
            this.playerName = playerName;
            this.characterClass = characterClass;  
            this.race = race;
            this.birthDate = birthDate;
            this.age = DateTime.Now - this.birthDate;
            this.stats = stats;
        }
    }
    class Stats
    {
        
        private int health;
        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;

        public Stats(int health, int strength, int dexterity, int constitution, int intelligence, int wisdom)
        {
            this.health = health;
            this.strength = strength;
            this.dexterity= dexterity;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
        }
    }
}
