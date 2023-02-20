using ConversorDinheiro.API.Models.Response;

namespace ConversorDinheiro.API.Repository.Interfaces
{
    public interface IConversor
    {
        public Models.Response.Conversor Convert(string from, string to, double amount, ref Utils _util);
    }
}
