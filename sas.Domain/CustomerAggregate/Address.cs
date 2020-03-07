using System.Collections.Generic;

namespace sas.Domain.CustomerAggregate
{
    public class Address : ValueObject
    {
        public string Province { get; private set; }
        public string City { get; private set; }

        public Address() { }
        public Address(string province, string city)
        {
            Province = province;
            City = city;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.Province;
            yield return this.City;
        }
    }
}
