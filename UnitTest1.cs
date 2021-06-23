using NUnit.Framework;
using ca_demoNS;

namespace ExampleTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConvertPhrase()
        {
            // Arrange
            string main_phrase = "The stray cat was way cool.";
            string expected = "T1e s2y c1t w1s w1y c1l.";
            Program.Example convert = new Program.Example(main_phrase);

            // Act
            convert.ConvertPhrase(main_phrase);

            // Assert
            string actual = convert.Phrase;
            Assert.AreEqual(expected, actual, "Phrase not coverted correctly");
        }
    }
}