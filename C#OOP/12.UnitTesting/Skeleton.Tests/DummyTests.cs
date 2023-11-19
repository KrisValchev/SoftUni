using Newtonsoft.Json.Bson;
using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void When_Attacking_ItShould_LoseHealth()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 10);
            //Act
            dummy.TakeAttack(1);
            //Assert
            Assert.AreEqual(9,dummy.Health);
        }
        [Test]
        public void When_Attacked_AndHealth_Below0_ItShould_Throw_Exception()
        {
            //Arrange and Act
            Dummy dummy = new Dummy(0,10);
            //Assert
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
        }
        [Test]
        public void When_DummyIsDead_Should_Give_XP()
        {
            //Arrange and Act
            Dummy dummy = new Dummy(0, 10);
            //Assert
            Assert.AreEqual(10, dummy.GiveExperience());
        }
        [Test]
        public void When_DummyIsNotDead_ShouldNot_Give_XP()
        {
            Dummy dummy = new Dummy(1, 10);
            //Assert
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}