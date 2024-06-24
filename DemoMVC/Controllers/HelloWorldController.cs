using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HelloWorldController 
    {
        public string Index()
        {
            return "ciao";
        }

        public string Search(string name)
        {
            return $"Hello, {name}";
        }
    }
}
