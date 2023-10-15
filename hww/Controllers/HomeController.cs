using hww.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace hww.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        return View(DbContext._products);
    }

    public ViewResult Contact()
    {
        return View();
    }


    public ViewResult About()
    {
        return View();
    }

}
