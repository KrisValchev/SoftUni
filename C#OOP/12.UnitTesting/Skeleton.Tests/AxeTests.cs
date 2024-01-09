using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void When_Attacking_Dummy_Durability_Of_Weapon_Is_Decreased_By_1()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(100, 50);
            axe.Attack(dummy);
            Assert.AreEqual(9, axe.DurabilityPoints);
        }
        [Test]
        public void When_Attacking_Dummy_Weapon_Breaks()
        {
            Axe axe = new Axe(10,0);
            Dummy dummy = new Dummy(100, 50);

            //Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}