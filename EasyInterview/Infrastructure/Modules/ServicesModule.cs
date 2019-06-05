using Autofac;
using Services.Interfaces;
using Services.Services;

namespace Infrastructure.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AccountService>().As<IAccountService>();
            builder.RegisterType<LibraryService>().As<ILibraryService>();
            builder.RegisterType<InterviewService>().As<IInterviewService>();
            builder.RegisterType<ProblemService>().As<IProblemService>();
            builder.RegisterType<TagService>().As<ITagService>();
            builder.RegisterType<TestService>().As<ITestService>();
        }
    }
}
