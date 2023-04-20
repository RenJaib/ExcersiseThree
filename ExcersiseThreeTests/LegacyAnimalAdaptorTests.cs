using ExcersiseThree;
using SomeLagacyLib;

namespace ExcersiseThreeTests
{
    public class LegacyAnimalAdaptorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var pikachu = new Pikachu("pikach00");
            var legacyAnimalAdaptor = new LegacyAnimalAdaptor(pikachu);

            //Act
            var result = legacyAnimalAdaptor.Speak();

            //Assert
            Assert.AreEqual("pikach00 says Pika-choo!", result);

        }
    }
}