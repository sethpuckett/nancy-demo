using System.Collections.Generic;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Security;
using nancy_demo.models;

namespace nancy_demo.modules
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      var users = new List<User> {
        new User { Id = 1, Username = "test1", Admin = false},
        new User { Id = 2, Username = "test2", Admin = true}
      };

      Get("/", _ => View["index"]);
      Get("/users", _ => View["users", users]);
      Get("/file", _ => Response.AsFile("content/big_file.zip"));
    }
  }
}