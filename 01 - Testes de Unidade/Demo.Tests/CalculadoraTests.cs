using Xunit;
namespace Demo.Tests
{
    class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornaValorSoma()
        {
            //Arrange 
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            //Assert
            Assert.Equal(expected: 4, actual: resultado);
        }
    }
}
