using ConversorDinheiro.API.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConversorDinheiro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversorController : ControllerBase
    {
        private readonly IConversor _IConversor;
        private Utils _util;

        public ConversorController(IConversor iConversor)
        {
            _IConversor = iConversor;
            _util = new Utils();
        }

        /// <summary>
        /// Convert money to one currency to another
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        [HttpGet("Conversor/{from}/{to}/{amount}")]
        public Models.Response.Conversor Conversor(string from, string to, double amount)
        {
            return _IConversor.Convert(from, to, amount, ref _util);
        }
    }
}