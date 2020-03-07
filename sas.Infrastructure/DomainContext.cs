using DotNetCore.CAP;
using MediatR;
using Microsoft.EntityFrameworkCore;
using sas.Infrastructure.Core;

namespace sas.Infrastructure
{
    public class DomainContext : EFContext
    {
        public DomainContext(DbContextOptions options, IMediator mediator, ICapPublisher capBus) : base(options, mediator, capBus)
        {
        }
    }
}
