using Microsoft.AspNetCore.Mvc;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaSeries = BD.ListarSeries();
        return View();
    }

    public List<Actores> ListaActores(int IdSerie){
        return BD.ListarActores(IdSerie);
    }

    public List<Temporadas> ListaTemp(int IdSerie){
        return BD.ListarTemp(IdSerie);
    }

    public String SacarSinopsis(int IdSerie){
        return BD.Sinopsis(IdSerie);
    }
}
