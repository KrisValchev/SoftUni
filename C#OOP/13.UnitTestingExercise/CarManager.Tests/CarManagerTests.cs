namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;
        [SetUp]
        public void SetUp()
        {
            car = new Car("Japan", "Subaru", 11, 99);
        }
        [Test]
        public void When_Instantiating_NewCar_Should_Work()
        {
            Assert.AreEqual("Japan", car.Make);
            Assert.AreEqual("Subaru", car.Model);
            Assert.AreEqual(11, car.FuelConsumption);
            Assert.AreEqual(99, car.FuelCapacity);
        }
        [Test]
        public void When_Instantiating_NewCar_FuelAmount_ShouldBe_Zero()
        {
            Assert.AreEqual(0, car.FuelAmount);
        }
        [TestCase(null)]
        [TestCase("")]
        public void When_Make_Is_NullOrEmpty_ShouldThrowArgumentException(string make)
        {
           ArgumentException exception= Assert.Throws < ArgumentException>(()=>new Car(make,"Subaru",11,99));
            Assert.AreEqual("Make cannot be null or empty!", exception.Message);
        }
        [TestCase(null)]
        [TestCase("")]
        public void When_Model_Is_NullOrEmpty_ShouldThrowArgumentException(string model)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Japan", model, 11, 99));
            Assert.AreEqual("Model cannot be null or empty!", exception.Message);
        }
        [TestCase(0)]
        [TestCase(-3)]
        public void When_FuelConsumption_Is_ZeroOrLess_ShouldThrowArgumentException(double fuelConsumption)
        {
            ;
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Japan", "Subaru",fuelConsumption, 99));
            Assert.AreEqual("Fuel consumption cannot be zero or negative!", exception.Message);
        }
        [TestCase(0)]
        [TestCase(-3)]
        public void When_FuelCapacity_Is_NegativeOrZero_ShouldThrowArgumentException(double fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Japan", "Subaru", 11, fuelCapacity));
            Assert.AreEqual("Fuel capacity cannot be zero or negative!", exception.Message);
        }
        [Test]
        public void When_FuelAmount_Is_Negative_ShouldThrowArgumentException()
        {
            Assert.Throws<InvalidOperationException>(()
            => car.Drive(12), "Fuel amount cannot be negative!");
        }
        [Test]
        public void When_RefuelingACar_WithFuel_ShouldWork()
        {
            car.Refuel(10);
            Assert.AreEqual(10, car.FuelAmount);
        }
        [TestCase(0)]
        [TestCase(-10)]
        public void When_RefuelingACar_WithZeroOrNegativeFuel_ShouldThrowException(double fuelToRefuel)
        {

            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel), "Fuel amount cannot be zero or negative!");
        }
        [Test]
        public void When_RefuelingACar_AndFuelAmountIsMoreThanFuelCapacity_ShouldMakeFuelAmountEqualToFuelCapacity()
        {

            car.Refuel(1000);

            Assert.AreEqual(car.FuelAmount, car.FuelCapacity);
        }
        [Test]
        public void When_DrivingWithNeededFuelMoreThanWeHave_Should_ThrowException()
        {
            double distance = 10;

            Assert.Throws<InvalidOperationException>(() => car.Drive(distance), "You don't have enough fuel to drive!");
        }
        [Test]
        public void When_DrivingDistanceWithLessNeededFuelThanWeHave_Should_Work()
        {
            double distance = 10;
            car.Refuel(80);
            car.Drive(distance);
            Assert.AreEqual(78.9, car.FuelAmount);
        }
    }
}