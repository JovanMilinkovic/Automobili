using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.Automobili
{
    public class Update
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public String model { get; set; }
            public String cena { get; set; }
            public String slika { get; set; }
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
                var automobil = await this.context.Automobili.FindAsync(request.Id);

                if (automobil == null)
                    throw new Exception("Could not find automobil");

                automobil.model = request.model ?? automobil.model;

                automobil.cena = request.cena ?? automobil.cena;

                automobil.slika = request.slika ?? automobil.slika;

                var success = await this.context.SaveChangesAsync() > 0;

                if(success) return Unit.Value;

                throw new System.Exception("Problem saving changes");
            }
        }
    }
}