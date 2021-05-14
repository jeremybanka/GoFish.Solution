using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GoFish.Models;

namespace GoFish.Controllers
{
  public class PlayController : Controller
  {

    [HttpGet("/play")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/play/new")]
    public ActionResult Create(string name, string codeword)
    {
      Player p = new(name, codeword);
      Lobby.AddPlayer(p);
      return RedirectToRoute($"/play");
    }

    [HttpGet("/play/{codeword}")]
    public ActionResult Seat(string codeword)
    {
      Player player = Lobby.GetAll().Find(p => p.Codeword == codeword);
      return View(player);
    }

  }
}