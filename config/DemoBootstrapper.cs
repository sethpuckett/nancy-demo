using Nancy;
using Nancy.Configuration;
using Nancy.Conventions;

namespace nancy_demo.config
{
  public class DemoBootstrapper : DefaultNancyBootstrapper
  {
    protected override void ConfigureConventions(NancyConventions conventions)
    {
        base.ConfigureConventions(conventions);
        
        conventions.StaticContentsConventions.Add(
            StaticContentConventionBuilder.AddDirectory("wwwroot")
        );
    }

    public override void Configure(INancyEnvironment environment)
    {
        environment.Tracing(enabled: false, displayErrorTraces: true);
        
    }
  }
}