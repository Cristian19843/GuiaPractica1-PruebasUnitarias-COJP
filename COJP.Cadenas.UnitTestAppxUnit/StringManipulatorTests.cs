using Xunit;
using COJP.Cadenas;

namespace COJP.Cadenas.UnitTestAppxUnit
{
    public class StringManipulatorTests
    {
        #region Pruebas para ReverseString (Fact)

        [Fact]
        public void ReverseString_SimpleWord_ReturnsReversed()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "hola";
            string expected = "aloh";

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_Palindrome_ReturnsSameWord()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "reconocer";
            string expected = "reconocer";

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_PhraseWithSpaces_ReturnsReversedPhrase()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "Hola Mundo";
            string expected = "odnuM aloH";

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_SingleCharacter_ReturnsSameCharacter()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "A";
            string expected = "A";

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = string.Empty;
            string expected = string.Empty;

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_NullInput_ThrowsArgumentNullException()
        {
            // Arrange
            var manipulator = new StringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.ReverseString(null!));
        }

        #endregion

        #region Pruebas para RemoveSpaces (Fact)

        [Fact]
        public void RemoveSpaces_SingleSpaceBetweenWords_ReturnsCombinedString()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "Hola Mundo";
            string expected = "HolaMundo";

            // Act
            string actual = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_MultipleSpaces_ReturnsStringWithoutSpaces()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "  Pruebas   unitarias   con   xUnit  ";
            string expected = "PruebasunitariasconxUnit";

            // Act
            string actual = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_StringWithoutSpaces_ReturnsOriginalString()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "CSharp";
            string expected = "CSharp";

            // Act
            string actual = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_OnlySpaces_ReturnsEmptyString()
        {
            // Arrange
            var manipulator = new StringManipulator();
            string input = "     ";
            string expected = string.Empty;

            // Act
            string actual = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RemoveSpaces_NullInput_ThrowsArgumentNullException()
        {
            // Arrange
            var manipulator = new StringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.RemoveSpaces(null!));
        }

        #endregion

        #region Pruebas Parametrizadas (Theory & InlineData)

        [Theory]
        [InlineData("abc", "cba")]
        [InlineData("12345", "54321")]
        [InlineData("oso", "oso")]
        [InlineData("Visual Studio", "oidutS lausiV")]
        public void ReverseString_Theory_ReturnsExpected(string input, string expected)
        {
            // Arrange
            var manipulator = new StringManipulator();

            // Act
            string actual = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a b c", "abc")]
        [InlineData(" 1 2 3 ", "123")]
        [InlineData("Ingenieria de Software", "IngenieriadeSoftware")]
        [InlineData("xUnit Test", "xUnitTest")]
        public void RemoveSpaces_Theory_ReturnsExpected(string input, string expected)
        {
            // Arrange
            var manipulator = new StringManipulator();

            // Act
            string actual = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
