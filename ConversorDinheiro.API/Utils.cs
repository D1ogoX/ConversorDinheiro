namespace ConversorDinheiro.API
{
    public class Utils
    {
        private readonly IConfiguration _IConfiguration;

        public Utils()
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            _IConfiguration = builder.Build();
        }

        private string Url
        {
            get
            {
                return _IConfiguration.GetConnectionString("Conversor");
            }
        }

        private string APIKey
        {
            get
            {
                return _IConfiguration.GetConnectionString("APIKey");
            }
        }

        /// <summary>
        /// Get formated URL
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string FormatURL(string from, string to, double amount)
        {
            string _sAmount = amount.ToString().Replace(",", ".");

            return this.Url.ToLower().Replace("$from", from).Replace("$to", to).Replace("$amount", _sAmount).Replace("$key", this.APIKey);
        }
    }
}
