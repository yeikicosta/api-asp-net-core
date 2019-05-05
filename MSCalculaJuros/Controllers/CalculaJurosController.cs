using ApplicationCalculaJuros;
using EntitiesCalculaJuros;
using Microsoft.AspNetCore.Mvc;

namespace MSCalculaJuros.Controllers
{
    /// <summary>
    /// Classe para cálculo de juros
    /// </summary>
    [Route("api")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosService _CalculaJurosService = null;
        /// <summary>
        /// Construtor recebendo instância de application
        /// </summary>
        /// <param name="calculaJurosService">Instância de application</param>
        public CalculaJurosController(ICalculaJurosService calculaJurosService)
        {
            _CalculaJurosService = calculaJurosService;
        }

        /// <summary>
        /// Realiza cálculo de juros compostos de um porcento 
        /// </summary>
        /// <param name="valorInicial">Valor inicial</param>
        /// <param name="meses">Tempo em meses</param>
        /// <returns>ResultadoValores</returns>
        [HttpGet("calculajuros")]
        public ResultadoValores CalcularUmPorcentoMeses([FromQuery]  decimal valorInicial, [FromQuery] int meses)
        {
            return _CalculaJurosService.CalcularUmPorcentoMeses(new Valores()
            {
                Meses = meses,
                ValorInicial = valorInicial
            });
        }

        /// <summary>
        /// Url de onde encontra-se o fonte no github
        /// </summary>
        /// <returns></returns>
        [HttpGet("showmethecode")]
        public string UrlGitHub()
        {
            return "https://github.com/yeikicosta/softplan.git";
        }

        
    }
}
