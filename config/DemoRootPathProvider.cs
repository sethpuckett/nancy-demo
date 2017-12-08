using System.IO;
using Nancy;

namespace nancy_demo.config
{
  public class DemoRootPathProvider : IRootPathProvider
  {
    public string GetRootPath()
    {
        return Directory.GetCurrentDirectory();
    }
  }
}