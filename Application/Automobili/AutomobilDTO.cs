using System;
using System.Collections.Generic;

namespace Application.Automobili
{
    public class AutomobilDTO
    {
        public Guid Id { get; set; }
        public String model { get; set; }
        public String cena { get; set; }
        public string slika { get; set; }
        public ICollection<SveOAutomobilimaDTO> SveOAutomobilima { get; set; }
    }
}