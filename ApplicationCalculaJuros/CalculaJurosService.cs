using EntitiesCalculaJuros;
using System;

namespace ApplicationCalculaJuros
{
    public class CalculaJurosService : ICalculaJurosService
    {
        /// <summary>
        /// Realiza cálculo de juros compostos de um porcento
        /// </summary>
        /// <param name="valores">Valores de entrada, valor inicial e meses</param>
        /// <returns>ResultadoValores</returns>
        public ResultadoValores CalcularUmPorcentoMeses(Valores valores)
        {
            return new ResultadoValores()
            {
                //Valor Final = Valor Inicial * (1 + juros) ^ Tempo
                Resultado = Math.Truncate(
                    Convert.ToDecimal((double)valores.ValorInicial * Math.Pow(1 + (double)valores.Juros, valores.Meses)) * 100
                ) / 100,
                ResultadoNaoTruncado = Convert.ToDecimal((double)valores.ValorInicial * Math.Pow(1 + (double)valores.Juros, valores.Meses)),
                Meses = valores.Meses,
                ValorInicial = valores.ValorInicial
            };
        }
    }
}
