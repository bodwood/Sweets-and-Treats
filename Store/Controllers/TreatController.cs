using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Store.Models;

namespace Store.Controllers
{
  public class TreatsController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly StoreContext _db;

    public TreatsController(UserManager<ApplicationUser> userManager, StoreContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details()
    {
      return View();
    }

    public ActionResult Edit()
    {
      return View();
    }

    [HttpPost]
    public ActionResult EditTreat()
    {
      return RedirectToAction("Details");
    }

    public ActionResult Delete()
    {
      return View();
    }

    [HttpPost]
    public ActionResult DeleteTreat()
    {
      return RedirectToAction("Index");
    }
  }
}