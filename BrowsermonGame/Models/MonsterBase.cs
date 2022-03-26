using BrowsermonGame.Enums;

namespace BrowsermonGame.Models
{
    public class MonsterBase
    {
        public string Name { get; }
        public int BaseHealth { get; }
        public int BaseAttack { get; }
        public int BaseDefense { get; }
        public int BaseSpecialAttack { get; }
        public int BaseSpecialDefense { get; }
        public int BaseSpeed { get; }
        public EType PrimaryType { get; } 
        public EType SecondaryType { get; }
        public List<Ability> Abilities { get; }
        public List<Attack> Attacks { get; }
        public bool CanBeMale { get; }
        public bool CanBeFemale { get; }

        public string FrontSpriteUrl { get; }
        public string BackSpriteUrl { get; }
        public string FrontShinySpriteUrl { get; }
        public string BackShinySpriteUrl { get; }

        protected MonsterBase() { }

        private MonsterBase(
            string name,
            int health,
            int attack,
            int defense,
            int specialAttack,
            int specialDefense,
            int speed,
            EType primaryType,
            EType secondaryType,
            List<Ability> abilities,
            List<Attack> attacks,
            bool canBeMale,
            bool canBeFemale)
        {
            Name = name;
            BaseHealth = health;
            BaseAttack = attack;
            BaseDefense = defense;
            BaseSpecialAttack = specialAttack;
            BaseSpecialDefense = specialDefense;
            BaseSpeed = speed;
            PrimaryType = primaryType;
            SecondaryType = secondaryType;
            Abilities = abilities;
            Attacks = attacks;
            CanBeMale = canBeMale;
            CanBeFemale = canBeFemale;
        }

        public static MonsterBase Create(
            string name,
            int health,
            int attack,
            int defense,
            int specialAttack,
            int specialDefense,
            int speed,
            EType primaryType,
            EType secondaryType,
            List<Ability> abilities,
            List<Attack> attacks,
            bool canBeMale,
            bool canBeFemale){

            if (primaryType == EType.None || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }

            var monster = new MonsterBase(name, health, attack, defense, specialAttack, specialDefense, speed, primaryType, secondaryType, abilities, attacks, canBeMale, canBeFemale);


            return monster;
        }
    }
}
