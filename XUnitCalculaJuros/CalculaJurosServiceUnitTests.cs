using ApplicationCalculaJuros;
using EntitiesCalculaJuros;
using Xunit;

namespace XUnitCalculaJuros
{
    public class CalculaJurosServiceUnitTests
    {
        [Theory]
        [InlineData(100, 5)]
        public void CalcularJurosUmPorcento_100_5(decimal valorInicial, int meses)
        {
            var calculaJurosService = new CalculaJurosService();
            var result = calculaJurosService.CalcularUmPorcentoMeses(new Valores() { ValorInicial = valorInicial, Meses = meses });
            Assert.Equal(105.10M, result.Resultado);
        }

        [Theory]
        [InlineData(100000, 100)]
        public void CalcularJurosUmPorcento_100000_100(decimal valorInicial, int meses)
        {
            var calculaJurosService = new CalculaJurosService();
            var result = calculaJurosService.CalcularUmPorcentoMeses(new Valores() { ValorInicial = valorInicial, Meses = meses });
            Assert.Equal(270481.38M, result.Resultado);
        }
    }
}
