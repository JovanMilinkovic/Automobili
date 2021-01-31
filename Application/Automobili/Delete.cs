using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.Automobili
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
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

                        throw new Exception("Could not find activity");

                    this.context.Remove(automobil);

                    var success = await this.context.SaveChangesAsync() > 0;

                    if (success) return Unit.Value;
                    
                    throw new Exception("Problem saving changes");
                }
            }
    }
}