using BrowsermonGame.Enums;
using BrowsermonGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BrowsermonGameTest.Models
{
    public class MonsterBaseTests
    {
        /// <summary>
        /// Tests that the standard Create Monster Base creates with expected values
        /// </summary>
        [Fact]
        public void CreateMonsterBase_CreatesWithExpectedValues()
        {
            // Arrange
            const string name = "test";
            const int health = 100;
            const int attack = 101;
            const int defense = 102;
            const int specialAttack = 103;
            const int specialDefense = 104;
            const int speed = 105;
            const EType type1 = EType.Bug;
            const EType type2 = EType.Ice;
            List<Ability> abilities = new List<Ability>() { new Ability() };
            List<Attack> attacks = new List<Attack> { new Attack() };
            const bool canBeMale = true;
            const bool canBeFemale = true;

            // Act
            var result = MonsterBase.Create(name, health, attack, defense, specialAttack, specialDefense, speed, type1, type2, abilities, attacks, canBeMale, canBeFemale);

            // Assert
            Assert.Equal(name, result.Name);
            Assert.Equal(health, result.BaseHealth);
            Assert.Equal(attack, result.BaseAttack);
            Assert.Equal(defense, result.BaseDefense);
            Assert.Equal(specialAttack, result.BaseSpecialAttack);
            Assert.Equal(specialDefense, result.BaseSpecialDefense);
            Assert.Equal(speed, result.BaseSpeed);
            Assert.Single(result.Abilities);
            Assert.Single(result.Attacks);
            Assert.True(result.CanBeMale);
            Assert.True(result.CanBeFemale);
        }

        /// <summary>
        /// Tests that an exception is thrown if the primary type is none.
        /// </summary>
        [Fact]
        public void CreateMonsterBase_NonePrimaryType_ThrowsException()
        {
            // Arrange
            const string name = "test";
            const int health = 100;
            const int attack = 101;
            const int defense = 102;
            const int specialAttack = 103;
            const int specialDefense = 104;
            const int speed = 105;
            const EType type1 = EType.None;
            const EType type2 = EType.Ice;
            List<Ability> abilities = new List<Ability>() { new Ability() };
            List<Attack> attacks = new List<Attack> { new Attack() };
            const bool canBeMale = true;
            const bool canBeFemale = true;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => MonsterBase.Create(name, health, attack, defense, specialAttack, specialDefense, speed, type1, type2, abilities, attacks, canBeMale, canBeFemale));
        }


        /// <summary>
        /// Tests that an exception is thrown if the name is empty.
        /// </summary>
        [Fact]
        public void CreateMonsterBase_EmptyName_ThrowsException()
        {
            // Arrange
            const string name = "";
            const int health = 100;
            const int attack = 101;
            const int defense = 102;
            const int specialAttack = 103;
            const int specialDefense = 104;
            const int speed = 105;
            const EType type1 = EType.Dark;
            const EType type2 = EType.Ice;
            List<Ability> abilities = new List<Ability>() { new Ability() };
            List<Attack> attacks = new List<Attack> { new Attack() };
            const bool canBeMale = true;
            const bool canBeFemale = true;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => MonsterBase.Create(name, health, attack, defense, specialAttack, specialDefense, speed, type1, type2, abilities, attacks, canBeMale, canBeFemale));
        }
    }
}
