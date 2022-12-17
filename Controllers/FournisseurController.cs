using iStock.Data;
using iStock.Models;
using Microsoft.AspNetCore.Mvc;

namespace iStock.Controllers;

    public class FournisseurController : Controller
    {
    public readonly ApplicationDbContext _db;

    public FournisseurController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()   
        {
        IEnumerable<Fournisseur> OBJfournisseurs = _db.Fournisseurs;
        return View(OBJfournisseurs);
        }




    // GET - CREATE
    public IActionResult CreateF()
    {
        return View();
    }

	// POST - CREATE
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult CreateF(Fournisseur obj)
	{
		if (ModelState.IsValid)
		{

			_db.Fournisseurs.Add(obj);
			_db.SaveChanges();
			TempData["success"] = "The Fournisseur has been added successfully";
			return RedirectToAction("Index");

		}
		return View(obj);

	}
	// GET - EDIT
	public IActionResult EditF(int? Id)
	
	{
		if (Id == null || Id == 0)
		{
			return NotFound();
		}
		var obj = _db.Fournisseurs.Find(Id);
		
		if(obj==null)
		{
			return NotFound();
		}

		return View(obj);

	}

	// POST - EDIT
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult EditF(Fournisseur obj)
	{
		if (ModelState.IsValid)
		{

			_db.Fournisseurs.Update(obj);
			_db.SaveChanges();
			TempData["success"] = "The Fournisseur has been edited successfully";
			return RedirectToAction("Index");

		}
		return View(obj);

	}








	// GET - DELETE
	public IActionResult DeleteF(int? Id)

	{
		if (Id == null || Id == 0)
		{
			return NotFound();
		}
		var obj = _db.Fournisseurs.Find(Id);

		if (obj == null)
		{
			return NotFound();
		}

		return View(obj);

	}

	// POST - delete
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult DeleteFP(int? Id)
	{
		var obj = _db.Fournisseurs.Find(Id);
		if (obj ==null )
		{
			return NotFound();
		}


		_db.Fournisseurs.Remove(obj);
			_db.SaveChanges();
		TempData["success"] = "The Fournisseur has been deleted successfully";
		return RedirectToAction("Index");

	

	}






}






