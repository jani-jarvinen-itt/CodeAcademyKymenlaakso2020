using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureCosmosDbDemo
{
    public class OmaLuokka
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string Nimi { get; set; }

        public int Luku { get; set; }

        public DateTime Kellonaika { get; set; }
    }
}
