using iStock.Data;
using iStock.Models;
using Microsoft.AspNetCore.Mvc;

namespace iStock.Controllers;

public class ProduitController : Controller           
{
	public readonly ApplicationDbContext _db;

	public ProduitController(ApplicationDbContext db)
	{
		_db = db;
	}
	public IActionResult IndexP()
	{
		IEnumerable<Produit> OBJProduits = _db.Produits;
		return View(OBJProduits);
	}




	// GET - CREATE
	public IActionResult CreateP()
	{
		return View();
	}

	// POST - CREATE
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult CreateP(Produit obj)
	{
		if (ModelState.IsValid)
		{

			_db.Produits.Add(obj);
			_db.SaveChanges();
			TempData["success"] = "The Produit has been added successfully";
			return RedirectToAction("IndexP");

		}
		return View(obj);

	}
	// GET - EDIT
	public IActionResult EditP(int? Id)    

	{
		if (Id == null || Id == 0)
		{
			return NotFound();
		}
		var obj = _db.Produits.Find(Id);

		if (obj == null)
		{
			return NotFound();
		}

		return View(obj);

	}

	// POST - EDIT
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult EditP(Produit obj)
	{
		if (ModelState.IsValid)
		{

			_db.Produits.Update(obj);
			_db.SaveChanges();
			TempData["success"] = "The Produit has been edited successfully";
			return RedirectToAction("IndexP");

		}
		return View(obj);

	}



	


	

	// GET - DELETE
	public IActionResult DeleteP(int? Id)

	{
		if (Id == null || Id == 0)
		{
			return NotFound();
		}
		var obj = _db.Produits.Find(Id);

		if (obj == null)
		{
			return NotFound();
		}

		return View(obj);

	}

	// POST - delete
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult DeletePP(int? Id)
	{
		var obj = _db.Produits.Find(Id);
		if (obj == null)
		{
			return NotFound();
		}


		_db.Produits.Remove(obj);
		_db.SaveChanges();
		TempData["success"] = "The Produit has been deleted successfully";
		return RedirectToAction("IndexP");

		

	}






}


