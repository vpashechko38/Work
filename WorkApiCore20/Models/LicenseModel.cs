using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkApiCore20.Models
{
    public class LicenseModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string KeyLicense { get; set; }
        public DateTime LifeTime { get; set; }
    }
}
