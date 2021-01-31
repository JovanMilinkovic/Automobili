using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Automobili
{
    public class List
    {
        public class Query : IRequest<List<AutomobilDTO>> { }

        public class Handler : IRequestHandler<Query, List<AutomobilDTO>>
        {
            private readonly DataContext context;
            private readonly IMapper mapica;
            public Handler(DataContext context, IMapper mapica)
            {
                this.mapica = mapica;
                this.context = context;
            }

            public async Task<List<AutomobilDTO>> Handle(Query request, CancellationToken cancellationToken)
            {

                var automobili = await this.context.Automobili
                    .Include(x => x.SveOAutomobilima)
                    .ThenInclude(x => x.Kubikaza)
                    .Include(x => x.SveOAutomobilima)
                    .ThenInclude(x => x.Karoserija)
                    .Include(x => x.SveOAutomobilima)
                    .ThenInclude(x => x.Kwks)
                    .Include(x => x.SveOAutomobilima)
                    .ThenInclude(x => x.Pogon)
                    .Include(x => x.SveOAutomobilima)
                    .ThenInclude(x => x.Oprema)
                    .ToListAsync();

                return mapica.Map<List<Automobil>,List<AutomobilDTO>>(automobili);
            }
        }
    }
}