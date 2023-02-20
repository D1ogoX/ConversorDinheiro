﻿using System.Text.Json.Serialization;

namespace ConversorDinheiro.API.Models.Response
{
    public class Base
    {
        [JsonPropertyName("error")]
        public int error { get; set; }

        [JsonPropertyName("error_message")]
        public string error_message { get; set; }
    }
}
