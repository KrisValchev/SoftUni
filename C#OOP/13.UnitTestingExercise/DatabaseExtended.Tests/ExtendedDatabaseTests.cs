namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using NUnit.Framework.Constraints;
    using NUnit.Framework.Interfaces;
    using System;
    using System.Linq;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        Database db;
        [SetUp]
        public void SetValuesToConstructorToDatabase()
        {
            Person[] people = new Person[] { new Person(1, "Gosho"), new Person(2, "Misho") };
            db = new Database(people);
        }
        [Test]
        public void PersonConstructorWorksCorrectly()
        {
            Person person = new Person(12, "Gosho");
            Assert.AreEqual(12, person.Id);
            Assert.AreEqual("Gosho", "Gosho");
        }
        [Test]
        public void When_CreatingDB_CountShouldBeCorrect()
        {
            Assert.AreEqual(2, db.Count);
        }
        [Test]
        public void When_CreatingDB_LengthIsMoreThan16()
        {
            Person[] persons =
       {
            new Person(1, "Pesho"),
            new Person(2, "Gosho"),
            new Person(3, "Ivan_Ivan"),
            new Person(4, "Pesho_ivanov"),
            new Person(5, "Gosho_Naskov"),
            new Person(6, "Pesh-Peshov"),
            new Person(7, "Ivan_Kaloqnov"),
            new Person(8, "Ivan_Draganchov"),
            new Person(9, "Asen"),
            new Person(10, "Jivko"),
            new Person(11, "Toshko"),
            new Person(12, "Moshko"),
            new Person(13, "Foshko"),
            new Person(14, "Loshko"),
            new Person(15, "Roshko"),
            new Person(16, "Boshko"),
            new Person(17, "Kokoshko")
        };
            Assert.Throws<ArgumentException>(() => new Database(persons), "Provided data length should be in range [0..16]!");
        }
        [Test]
        public void When_AddingElement_WhenCreatingDB_AndArrayLengthIsMoreThan16_ShouldThrowInvalidOperationException()
        {
            Person[] persons =
       {
            new Person(1, "Pesho"),
            new Person(2, "Gosho"),
            new Person(3, "Ivan_Ivan"),
            new Person(4, "Pesho_ivanov"),
            new Person(5, "Gosho_Naskov"),
            new Person(6, "Pesh-Peshov"),
            new Person(7, "Ivan_Kaloqnov"),
            new Person(8, "Ivan_Draganchov"),
            new Person(9, "Asen"),
            new Person(10, "Jivko"),
            new Person(11, "Toshko"),
            new Person(12, "Moshko"),
            new Person(13, "Foshko"),
         
        };
            db = new Database(persons);
            db.Add(new Person(14, "Loshko"));
            db.Add(new Person(15, "Roshko"));
            db.Add(new Person(16, "Boshko"));
            Assert.Throws<InvalidOperationException>(() =>db.Add(new Person(17, "Kokoshko")) , "Array's capacity must be exactly 16 integers!");
        }
        [Test]
        public void When_AddingPeopleWithTheSameUsername_ShouldThrowException()
        {
            Person[] persons =
            {
                new Person(1, "Pesho"),
                new Person(2, "Pesho"),
            };
            Assert.Throws<InvalidOperationException>(() => new Database(persons), "There is already user with this username!");
        }
        [Test]
        public void When_AddingPeopleWithTheSameID_ShouldThrowException()
        {
            Person[] persons =
            {
                new Person(1, "Pesho"),
                new Person(1, "Gosho"),
            };
            Assert.Throws<InvalidOperationException>(() => new Database(persons), "No user is present by this username!");
        }
        [Test]
        public void When_AddingPeople_CountShouldIncrease()
        {
            db = new Database();
            db.Add(new Person(17, "Kokoshko"));
            Assert.AreEqual(1, db.Count);
        }
        //--------------------------------------When removing
        [Test]
        public void When_RemovingElementAndDecreasingCount_Should_Work()
        {
            db.Remove();
            Assert.AreEqual(1, db.Count);
        }
        [Test]
        public void When_RemovingElementAndThereAreNoElementsInTheArray_ShouldThrowInvalidOperationException()
        {
            Database db = new Database();

            Assert.Throws<InvalidOperationException>(() => db.Remove());
        }
        //----------------------------------------------------Finding by Name
        [TestCase("")]
        [TestCase(null)]
        public void When_FindingByUserName_IsNullOrEmpty_ShouldThrowException(string name)
        {

            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(name));
        }
        [Test]
        public void When_FindingByUserName_ShouldWorkCorrectly()
        {
            string person = db.FindByUsername("Gosho").UserName;
            Assert.AreEqual("Gosho",person);
        }
        [Test]
        public void When_FindingByUserName_ThePersonsArrayIsEmpty_ShouldThrowException()
        {
            db=new Database();
            string name = "Gosho";
            Assert.Throws<InvalidOperationException>(() => db.FindByUsername(name));
        }
        //------------------------------------Finding by ID
        [Test]
        public void When_FindingByID_ShouldWorkCorrectly()
        {
            string person = db.FindById(1).UserName;
            Assert.AreEqual("Gosho",person );
        }
        [Test]
        public void When_FindingByID_IDIsLessThanZero_ShouldThrowException()
        {
           
            Assert.Throws<ArgumentOutOfRangeException>(()=> db.FindById(-1));
        }
        [Test]
        public void When_FindingByID_AndThereIsNoSuchPerson_ShouldThrowExceptiion()
        {

            Assert.Throws<InvalidOperationException>(() => db.FindById(3));
        }
    }
}