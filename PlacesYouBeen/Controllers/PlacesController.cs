using Microsoft.AspNetCore.Mvc;
using PlacesWB.Models;
using System.Collections.Generic;

namespace PlacesWB.Models
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Places> allPlaces = Places.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View("New");
    }

    [HttpPost("/places")]
    public ActionResult Create(string name, string description, string timestamp)
    {
      Places entry = new Places(name, description, timestamp);
      return RedirectToAction("Index");
    }

     [HttpGet("/places/{id}")]
     public ActionResult Show(int id)
     {
       Places foundPlace = Places.Find(id);
       return View("Show", foundPlace);
     }

  }
}