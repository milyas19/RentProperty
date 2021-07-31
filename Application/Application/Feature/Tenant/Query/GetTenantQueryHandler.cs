using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Feature.Tenant.Query
{
    public class GetTenantQueryHandler : IRequestHandler<GetTenantQuery, GetTenantDto>
    {
        public GetTenantQueryHandler()
        {

        }
        public Task<GetTenantDto> Handle(GetTenantQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class GetTenantQuery : IRequest<GetTenantDto>
    {

    }
}
