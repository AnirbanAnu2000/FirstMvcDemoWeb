using Autofac;
using Autofac.Core;
using FirstDemo.Web.Models;

public class WebModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<TestClass>().As<ITestClass>().InstancePerLifetimeScope();

        builder.RegisterType<IndexModel>().AsSelf();

        base.Load(builder);
    }
}