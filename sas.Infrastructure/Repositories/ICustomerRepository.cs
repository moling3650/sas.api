using sas.Domain.CustomerAggregate;
using sas.Infrastructure.Core;

namespace sas.Infrastructure.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, long>
    {
    }
}
