using ConversorDinheiro.APP.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ConversorDinheiro.APP.Repository
{
    public class Conversor : IConversor
    {

        public Models.Conversor Convert(string from, string to, double amount)
        {
            try
            {
                using (HttpClient _client = new HttpClient())
                {
                    //Get URL from config
                    string url = System.Configuration.ConfigurationManager.AppSettings.Get("URL") + $"/{from}/{to}/{amount}";

                    var response = _client.GetStringAsync(url).Result;

                    return JsonConvert.DeserializeObject<Models.Conversor>(response);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
