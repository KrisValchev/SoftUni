namespace Database.Tests
{
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        [Test]

        public void When_CreatingInstance_Should_Work()
        {
            Database db=new Database(1,2,3,4,5,6);
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6 }, db.Fetch());
        }
        [Test]
        public void When_CreatingDB_CountShouldBeCorrect()
        {
            Database db = new Database(1, 2, 3, 4, 5, 6);
            Assert.AreEqual(6, db.Count);
        }
        [Test]
        public void When_AddingElement_WhenCreatingDB_AndArrayLengthIsMoreThan16_ShouldThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17), "Array's capacity must be exactly 16 integers!");
        }
        [Test]
        public void DatabaseCountShouldWorkCorrectly()
        {
            Database db = new Database(1, 2);
            int expectedResult = 2;
            int actualResult = db.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddingElement_ShouldIncreaseCount()
        {
            Database db = new Database(1, 2, 3, 4, 5, 6);
            db.Add(7);
            db.Add(8);
            Assert.AreEqual(8, db.Count);
        }
        [Test]
        public void AddingElement_Should_Work()
        {
            int[] data = { 1, 2, 3, 4, 5, 6 };
            int[] actualData;
            Database db = new Database();
            foreach (var element in data)
            {
                db.Add(element);
            }
            Assert.AreEqual(data, db.Fetch());
        }
        [Test]
    
        public void When_AddingElement_AndArrayLengthIsMoreThan16_ShouldThrowInvalidOperationException()
        {
            Database db=new Database();
            for (int i = 0; i < 16; i++)
            {
                db.Add(i);
            }
            Assert.Throws<InvalidOperationException>(() => db.Add(17), "Array's capacity must be exactly 16 integers!");
        }
        [Test]
        public void When_RemovingElementAndDecreasingCount_Should_Work()
        {
            Database db = new Database(1, 2, 3, 4, 5, 6);
            db.Remove();
            Assert.AreEqual(5, db.Count);
        }
        [Test]
        public void DatabaseRemoveMethodShouldRemoveElementsCorrectly()
        {
            Database db = new Database(1, 2);
            int[] expectedResult = { };

            db.Remove();
            db.Remove();

            int[] actualResult = db.Fetch();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void When_RemovingElementAndThereAreNoElementsInTheArray_ShouldThrowInvalidOperationException()
        {
            Database db = new Database();
           
            Assert.Throws<InvalidOperationException>(()=>db.Remove());
        }
        [Test]
        public void DatabaseFetchMethod_ShouldReturnCorrectData()
        {
            int[] data = new int[] {1,2,3,4,5};
            Database db = new Database(data);
            Assert.AreEqual(data, db.Fetch());
        }
    }
}
