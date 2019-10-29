using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechWebApi.Models
{
    public class Vehicle: GeicoBaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("ownername")]
        public string OwnerName { get; set; }
        [JsonProperty("number")]
        public string Number { get; set; }
    }
}
