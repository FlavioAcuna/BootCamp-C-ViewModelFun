using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        string newMessage = "Hola desde el ViewModel";
        return View("Index", newMessage);
    }
    [HttpGet("numbers")]
    public IActionResult IANumbers()
    {
        Random rand = new Random();
        int[] numeros = { rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100) };
        return View("Numbers", numeros);
    }
    [HttpGet("users")]
    public IActionResult IAusers()
    {
        List<User> listaUsuarios = new List<User>();
        listaUsuarios.Add(new User()
        {
            Nombre = "Flavio",
            Apellido = "Acuna"
        });
        listaUsuarios.Add(new User()
        {
            Nombre = "Rene",
            Apellido = "Ricky"
        });

        listaUsuarios.Add(new User()
        {
            Nombre = "Jerry"
        });

        listaUsuarios.Add(new User()
        {
            Nombre = "Felipe"
        });

        return View("users", listaUsuarios);
    }
    [HttpGet("user")]
    public IActionResult IAOneUser()
    {
        User oneUser = new User()
        {
            Nombre = "Flavio",
            Apellido = "Acuna"
        };


        return View("User",oneUser);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
