using sas.Domain.Events;

namespace sas.Domain.CustomerAggregate
{
    public class Customer : Entity<long>, IAggregateRoot
    {
        public string PhoneNo { get; private set; }
        public Address Address { get; private set; }


        protected Customer() { }

        public Customer(string PhoneNo, Address address)
        {
            this.PhoneNo = PhoneNo;
            this.Address = address;

            this.AddDomainEvent(new CustomerCreatedDomainEvent(this));
        }
    }
}
