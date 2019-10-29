using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechWebApi.Models
{
    public class GeicoBaseModel
    {
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public string StatusCode { get; set; }
    }
}
