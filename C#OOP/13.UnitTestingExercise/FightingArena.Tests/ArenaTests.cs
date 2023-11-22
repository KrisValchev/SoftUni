namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ArenaTests
    {
        Arena arena;
        [SetUp]
        public void SetValue()
        {
           arena = new Arena();
        }
        [Test]
        public void Constructor_Is_Working_Correctly()
        {
           Assert.IsNotNull(arena);
            Assert.IsNotNull(arena.Warriors);
        }
        [Test]
        public void ArenaCountShouldWorkCorrectly()
        {
            Warrior warrior = new Warrior("Gosho", 10, 100);
            arena.Enroll(warrior);
            Assert.AreEqual(1, arena.Warriors.Count);
        }
        [Test]
        public void EnrollingWarrior_ShouldWorkCorrectly()
        {
            Warrior warrior = new Warrior("Gosho", 10, 100);
            Warrior actualWarrior = warrior;
            arena.Enroll(warrior);
            Assert.AreEqual(actualWarrior.Name, arena.Warriors.Single().Name);
        }
        [Test]
        public void EnrollingAlreadyExistingWarrior_ShouldThrowException()
        {
            Warrior warrior = new Warrior("Gosho", 10, 100);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(()=>arena.Enroll(warrior));
        }
        [Test]
        public void WhenFighting_AndAttackerIsNull_ShouldThrowException()
        {
            Warrior attacker = new Warrior("Gosho", 10, 100);
            Warrior defender = new Warrior("Pesho", 20, 100);

            arena.Enroll(defender);
            Assert.Throws<InvalidOperationException>(()=>arena.Fight(attacker.Name,defender.Name), $"There is no fighter with name {attacker.Name} enrolled for the fights!");
        }
        [Test]
        public void WhenFighting_AndDefenderIsNull_ShouldThrowException()
        {
            Warrior attacker = new Warrior("Gosho", 10, 100);
            Warrior defender = new Warrior("Pesho", 20, 100);

            arena.Enroll(attacker);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker.Name, defender.Name), $"There is no fighter with name {defender.Name} enrolled for the fights!");
        }
        [Test]
        public void FightMethodShouldWorkCorrectly()
        {
            Warrior attacker = new("Gosho", 15, 100);
            Warrior defender = new("Pesho", 5, 50);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            int expectedAttackerHp = 95;
            int expectedDefenderHp = 35;

            arena.Fight(attacker.Name, defender.Name);

            Assert.AreEqual(expectedAttackerHp, attacker.HP);
            Assert.AreEqual(expectedDefenderHp, defender.HP);
        }
    }
}
