using System;
using System.Collections.Generic;

namespace Domain
{
    public class Oprema
    {
        public Guid Id { get; set; }
        public string Vrsta { get; set; }
        public ICollection<SveOAutomobilu> SveOAutomobilima { get; set; }
    }
}