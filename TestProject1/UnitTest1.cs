using ClassLibrary1;
using Moq;

namespace TestProject1
{
    public class Tests
    {
        private MarryChristmasForTest? _marryChristmasForTest;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToDayIsNotMarryChristmas()
        {
            _marryChristmasForTest = new MarryChristmasForTest();
            var expected = "Today is not Marry Christmas";
            var result = _marryChristmasForTest.MarryChristmasDay();
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ToDayIsMarryChristmas()
        {
            _marryChristmasForTest = new MarryChristmasForTest(new DateTime(2023, 12, 25));
            var expected = "Today is Marry Christmas";
            var result = _marryChristmasForTest.MarryChristmasDay();
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Today_Is_Xmas_Day()
        {
            //Arrange
            var date = new DateTime(2023, 12, 25);
            var expected = "Today is Marry Christmas";

            var happyXmasMock = new Mock<IHappyXmas>();
            happyXmasMock.Setup(x => x.XmasDay(It.IsAny<DateTime>()));

            var happyXmas = new HappyXmas(happyXmasMock.Object);

            //Act
            var result = happyXmas.XmasDay(date);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Today_Is_Not_Xmas_Day()
        {
            //Arrange
            var date = DateTime.Now;
            var expected = "Today is not Marry Christmas";

            var happyXmasMock = new Mock<IHappyXmas>();
            happyXmasMock.Setup(x => x.XmasDay(It.IsAny<DateTime>()));

            var happyXmas = new HappyXmas(happyXmasMock.Object);

            //Act
            var result = happyXmas.XmasDay(date);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }

    public class MarryChristmasForTest : MarryChristmas
    {
        private readonly DateTime _dateTime;

        public MarryChristmasForTest() { }

        public MarryChristmasForTest(DateTime dateTime) 
        {
            _dateTime = dateTime;
        }

        protected override DateTime GetDate()
        {
            return _dateTime;
        }
    }
}