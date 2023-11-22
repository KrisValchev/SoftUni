namespace FightingArena.Tests
{
    using Newtonsoft.Json.Bson;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        Warrior warrior;
        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Gosho",10,100);
        }
        [Test]
        public void Constructor_Is_Working_Properly()
        {
            Assert.AreEqual("Gosho", warrior.Name);
            Assert.AreEqual(10, warrior.Damage);
            Assert.AreEqual(100, warrior.HP);
        }
        [TestCase(null)]
        [TestCase(" ")]
        [TestCase("")]
        public void When_Name_IsNullOrWhiteSpace_ShouldThrowException(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 10, 100));
        }
        [TestCase(0)]
        [TestCase(-1)]
        public void When_Damage_IsZeroOrLess_ShouldThrowException(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Gosho", damage, 100));
        }
        [TestCase(-1)]
        public void When_HP_IsNegative_ShouldThrowException(int HP)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Gosho", 10, HP));
        }
        [Test]
        public void When_AttackingAndHP_OfWarriorThatAttacks_IsBelowMinAttackHP_ShouldThrowException()
        {
            warrior = new Warrior("Gosho", 10, 10);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("pesho",10,100)));
        }
        [Test]
        public void When_AttackingAndHP_OfWarriorThatIsBeingAttacked_IsBelowMinAttackHP_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("pesho", 10, 10)));
        }
        [Test]
        public void WhenAttacking_HPOfAttackerIsLessThan_TheEnemyDamage_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("pesho", 110, 100)));
        }
        [Test]
        public void WhenAttacking_HPOfAttacker_ShouldDecrease()
        {
            warrior.Attack(new Warrior("pesho", 100, 100));
            Assert.AreEqual(0, warrior.HP);
        }
        [Test]
        public void WhenAttacking_HPOfTheOneBeingAttack_IsLessThanTheDamageOfTheAttacker_ShouldBecomeZero()
        {

            warrior = new Warrior("Gosho", 110, 100);
            Warrior warrior1 = new Warrior("pesho", 100, 100);
            warrior.Attack(warrior1);
            Assert.AreEqual(0, warrior1.HP);
        }
        [Test]  
        public void WhenAttacking_HPOfTheOneBeingAttack_IsMoreOrEqualToTheAttackerDamage_ShouldBecomeZero()
        {
            warrior = new Warrior("Gosho", 10, 100);
            Warrior warrior1 = new Warrior("pesho", 100, 100);
            warrior.Attack(warrior1);
            Assert.AreEqual(90, warrior1.HP);
        }

    }
}