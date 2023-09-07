

using UnitTestingExercises;

namespace UnitTestingExercises_unitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Addiction()
        {
            // Arrange - pasiruosti
            double number = 10;
            double number2 = 7;
            double expected = 17;

            // Act - testuoti
            double actual = Program.Addition(number, number2);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Substraction()
        {
            // Arrange - pasiruosti
            double number = 10;
            double number2 = 7;
            double expected = 3;

            // Act - testuoti
            double actual = Program.Substraction(number, number2);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            // Arrange - pasiruosti
            double number = 10;
            double number2 = 7;
            double expected = 70;

            // Act - testuoti
            double actual = Program.Multiplication(number, number2);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Division()
        {
            // Arrange - pasiruosti
            double number = 25;
            double number2 = 5;
            double expected = 5;

            // Act - testuoti
            double actual = Program.Division(number, number2);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_RaiseDegree()
        {
            // Arrange - pasiruosti
            double number = 12;
            double number2 = 2;
            double expected = 144;

            // Act - testuoti
            double actual = Program.RaiseDegree(number, number2);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PullRoot()
        {
            // Arrange - pasiruosti
            double number = 900;
            double expected = 30;

            // Act - testuoti
            double actual = Program.PullRoot(number);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }
    }
}