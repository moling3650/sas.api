using sas.Domain.CustomerAggregate;
using sas.Infrastructure.Core;

namespace sas.Infrastructure.Repositories
{
    public class CustomerRepository : Repository<Customer, long, DomainContext>, ICustomerRepository
    {
        public CustomerRepository(DomainContext context) : base(context)
        {
        }
    }
}
