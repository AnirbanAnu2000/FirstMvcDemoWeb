using Autofac;
using FirstDemo.Base.DbContexts;

public class BaseModule : Module
{
    private readonly string _connectionString;
    private readonly string _assemblyName;

    public BaseModule(string connectionString, string assemblyName)
    {
        _connectionString = connectionString;
        _assemblyName = assemblyName;
    }

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<BaseDbContext>().AsSelf()
            .WithParameter("connectionString", _connectionString)
            .WithParameter("assemblyName", _assemblyName);
        
        base.Load(builder);
    }
}