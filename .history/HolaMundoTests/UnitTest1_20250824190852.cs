using NUnit.Framework;

namespace HolaMundoTests
{
    [TestFixture]
    public class HolaMundoTests
    {
        [Test]
        public void GetMessage_DevuelveHelloMyWorld()
        {
            // Arrange - Preparar
            var holaMundo = new HolaMundo();
            // Act - Actuar
            var resultado = holaMundo.GetMessage();
            // Assert - Afirmar
            Assert.Tyhat(resultado, Is.EqualTo("Hello My World"));
        }
    }
}