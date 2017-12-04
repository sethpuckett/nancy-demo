using Nancy;

namespace nancy_demo.modules
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get("/", _ => "Hello World!!!");
      Get("/about", _ => "Brought to you buy NancyFX");
    }
  }
}