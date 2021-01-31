using System;

namespace Domain
{
    public class SveOAutomobilu
    {
        public Guid AutomobilId { get; set; }
        public Automobil Automobil { get; set; }
        public Guid KaroserijaId { get; set; }
        public Karoserija Karoserija { get; set; }
        public Guid KubikazaId { get; set; }
        public Kubikaza Kubikaza { get; set; }
        public Guid KwksId { get; set; }
        public Kwks Kwks { get; set; }
        public Guid PogonId { get; set; }
        public Pogon Pogon { get; set; }
        public Guid OpremaId { get; set; }
        public Oprema Oprema { get; set; }
    }
}