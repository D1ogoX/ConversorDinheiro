using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConversorDinheiro.APP.Models
{
    public class Conversor : Base
    {
        [JsonPropertyName("amount")]
        public double amount { get; set; }
    }
}
