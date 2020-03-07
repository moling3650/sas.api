using sas.Domain.CustomerAggregate;

namespace sas.Domain.Events
{
    public class CustomerCreatedDomainEvent : IDomainEvent
    {
        public Customer Customer { get; private set; }

        public CustomerCreatedDomainEvent(Customer customer)
        {
            this.Customer = customer;
        }
    }
}
