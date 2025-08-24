using NUnit.Framework;
[TestFixture]
public class HolaMundoTests
{
    [Test]
    public void TestObtenerMensaje()
    {
        // Arrange
        var holaMundo = new HolaMundo();
        // Act
        var resultado = holaMundo.GetGreeting();
        // Assert
        Assert.AreEqual("Hello My World", resultado);
    }
}