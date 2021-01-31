using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Automobili
{
    public class Details
    {
        public class Query : IRequest<AutomobilDTO>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, AutomobilDTO>
        {
            private readonly DataContext context;
            private readonly IMapper mapica;
            public Handler(DataContext context, IMapper mapica)
            {
                this.mapica = mapica;
                this.context = context;
            }

            public async Task<AutomobilDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                var automobil = await this.context.Automobili.FindAsync(request.Id);

                return mapica.Map<Automobil, AutomobilDTO>(automobil);
            }
        }
    }
}