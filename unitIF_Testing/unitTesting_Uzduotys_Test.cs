using unitTesting_uzduotys;

namespace unitIF_Testing
{
    [TestClass]
    public class unitTesting_Uzduotys_Test
    {
        [TestMethod]
        public void UserNumberBiger_When_One_Hundren()
        {
            // Arrange - pasiruosti
            int number = 105;
            string expected = "Skaicius yra didesnis uz 100";

            // Act - testuoti
            string actual = Program.UserNumber(number);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrNumberIsSmallerWhenOneHundren()
        {
            // Arrange - pasiruosti
            int number = 99;
            string expected = "Skaicius yra mazesnis uz 100";

            // Act - testuoti
            string actual = Program.UserNumber(number);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckOrPasswordCorrect()
        {
            // Arrange - pasiruosti
            string password = "Robertas";
            string expected = "Sekmingai prisijungete";

            // Act - testuoti
            string actual = Program.CheckPassword(password);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckInCorrect()
        {
            // Arrange - pasiruosti
            string password = "asdgrr32sd";
            string expected = "Slaptazodis neteisingas, prasome bandyti dar karta..";

            // Act - testuoti
            string actual = Program.CheckPassword(password);

            // Assert - tikrinam ka gavom
            Assert.AreEqual(expected, actual);
        }
    }
}