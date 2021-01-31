using System;
using System.Collections.Generic;

namespace Domain
{
    public class Automobil
    {
        public Guid Id { get; set; }
        public String model { get; set; }
        public String cena { get; set; }
        public String slika { get; set; }
        public ICollection<SveOAutomobilu> SveOAutomobilima { get; set; }
    }
}
