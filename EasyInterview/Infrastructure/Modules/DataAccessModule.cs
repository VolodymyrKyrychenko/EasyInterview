using Autofac;
using DataAccess.Context;
using DataAccess.Interfaces;
using DataAccess.Repository;
using DataAccess.UnitOfWork;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Modules
{
    public class DataAccessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .Register(context =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>()
                        .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=.s;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                    return new AppDbContext(optionsBuilder.Options);
                })
                .InstancePerLifetimeScope();

            builder.RegisterType<Repository<Candidate>>().As<IRepository<Candidate>>();
            builder.RegisterType<Repository<Company>>().As<IRepository<Company>>();
            builder.RegisterType<Repository<Employee>>().As<IRepository<Employee>>();
            builder.RegisterType<Repository<Problem>>().As<IRepository<Problem>>();
            builder.RegisterType<Repository<Interview>>().As<IRepository<Interview>>();
            builder.RegisterType<Repository<Library>>().As<IRepository<Library>>();
            builder.RegisterType<Repository<LibraryProblem>>().As<IRepository<LibraryProblem>>();
            builder.RegisterType<Repository<Tag>>().As<IRepository<Tag>>();
            builder.RegisterType<Repository<Test>>().As<IRepository<Test>>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
