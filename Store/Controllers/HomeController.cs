using Microsoft.AspNetCore.Mvc;
using Store.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Store.Controllers
{
  public class HomeController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly StoreContext _db;

    public HomeController(UserManager<ApplicationUser> userManager, StoreContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    //test index view
    //commit
  }
}