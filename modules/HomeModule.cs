using Nancy;

namespace nancy_demo.modules
{
  public class User
  {}

  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get("/about", _ => "Hello!");

    }
  }
}