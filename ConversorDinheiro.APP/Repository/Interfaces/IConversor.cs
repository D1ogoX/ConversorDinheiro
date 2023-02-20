namespace ConversorDinheiro.APP.Repository.Interfaces
{
    public interface IConversor
    {
        public Models.Conversor Convert(string from, string to, double amount);
    }
}
