using ConversorDinheiro.API.Repository.Interfaces;
using Newtonsoft.Json;

namespace ConversorDinheiro.API.Repository
{
    public class Conversor : IConversor
    {
        public Models.Response.Conversor Convert(string from, string to, double amount, ref Utils _util)
        {
            using (HttpClient client = new HttpClient())
            {
                var json = client.GetStringAsync(_util.FormatURL(from, to, amount)).Result;

                return JsonConvert.DeserializeObject<Models.Response.Conversor>(json);
            }
        }
    }
}
