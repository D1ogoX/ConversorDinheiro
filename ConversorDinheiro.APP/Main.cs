using ConversorDinheiro.APP.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDinheiro.APP
{
    public class Main
    {
        private readonly IConversor _IConversor;

        public Main(IConversor iConversor)
        {
            _IConversor = iConversor;
        }

        public void Start()
        {
            Console.WriteLine("App de conversão de dinheiro");

            Console.WriteLine("Introduza a moeda [DE] onde quer converter:");
            string from = Console.ReadLine();

            Console.WriteLine("Introduza a moeda [PARA] onde quer converter:");
            string to = Console.ReadLine();

            Console.WriteLine("Introduza o valor a converter:");
            string amount = Console.ReadLine();

            var _response = _IConversor.Convert(from, to, double.Parse(amount));

            //IF API return an error
            if (_response.error != 0)
            {
                Console.WriteLine("Error: " + _response.error_message);

                Console.ReadLine();

                return;
            }

            Console.WriteLine($"({amount}) [{from}] -> [{to}]: {_response.amount}");
            Console.ReadLine();
        }
    }
}
