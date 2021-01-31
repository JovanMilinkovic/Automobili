using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Automobili
{
    public class Create
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public String model { get; set; }
            public String cena { get; set; }
            public String slika { get; set; }
            public String[] Kubikaze { get; set; }
            public String[] Karoserije { get; set; }
            public String[] Kwkss { get; set; }
            public String[] Pogoni { get; set; }
            public String[] Opreme { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext context;
            public Handler(DataContext context)
            {
                this.context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var automobil = new Automobil
                {
                    Id = request.Id,
                    model = request.model,
                    cena = request.cena,
                    slika = request.slika
                };
                automobil.SveOAutomobilima = new List<SveOAutomobilu>();
                for(int i=0;i<request.Kubikaze.Count(); i++)
                {
                    automobil.SveOAutomobilima.Add(new SveOAutomobilu{
                        Kubikaza = new Kubikaza{
                            Vrsta = request.Kubikaze[i]
                        },
                        Karoserija = new Karoserija{
                            Vrsta = request.Karoserije[i]
                        },
                        Kwks = new Kwks{
                            Vrsta = request.Kwkss[i]
                        },
                        Pogon = new Pogon{
                            Vrsta = request.Pogoni[i]
                        },
                        Oprema = new Oprema{
                            Vrsta = request.Opreme[i]
                        }
                    });
                }
                this.context.Automobili.Add(automobil);
                var success = await this.context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}