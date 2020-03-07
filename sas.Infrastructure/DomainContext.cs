using DotNetCore.CAP;
using MediatR;
using Microsoft.EntityFrameworkCore;
using sas.Domain.CustomerAggregate;
using sas.Infrastructure.Core;
using sas.Infrastructure.EntityConfigurations;

namespace sas.Infrastructure
{
    public class DomainContext : EFContext
    {
        public DomainContext(DbContextOptions options, IMediator mediator, ICapPublisher capBus) : base(options, mediator, capBus)
        {
        }

        public DbSet<Customer> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 注册领域模型与数据库的映射关系
            modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
