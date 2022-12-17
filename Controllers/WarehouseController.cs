using iStock.Data;
using iStock.Models;
using Microsoft.AspNetCore.Mvc;

namespace iStock.Controllers;

public class WarehouseController : Controller
{
    public readonly ApplicationDbContext _db;

    public WarehouseController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult IndexW()
    {
        IEnumerable<Warehouse> OBJWarehouses = _db.Warehouses;
        return View(OBJWarehouses);
    }







	// GET - CREATE
	public IActionResult CreateW()
	{
		return View();
	}

	// POST - CREATE
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult CreateW(Warehouse obj)
	{
		if (ModelState.IsValid)
		{

			_db.Warehouses.Add(obj);
			_db.SaveChanges();
			TempData["success"] = "The Warehouse has been added successfully";
			return RedirectToAction("IndexW");

		}
		return View(obj);

	}
	// GET - EDIT
	public IActionResult EditW(int? Id)

	{
		if (Id == null || Id == 0)
		{
			return NotFound();
		}
		var obj = _db.Warehouses.Find(Id);

		if (obj == null)
		{
			return NotFound();
		}

		return View(obj);

	}

	// POST - EDIT
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult EditW(Warehouse obj)
	{
		if (ModelState.IsValid)
		{

			_db.Warehouses.Update(obj);
			_db.SaveChanges();
			TempData["success"] = "The Warehouse has been edited successfully";
			return RedirectToAction("IndexW");

		}
		return View(obj);

	}








	// GET - DELETE
	public IActionResult DeleteW(int? Id)

	{
		if (Id == null || Id == 0)
		{
			return NotFound();
		}
		var obj = _db.Warehouses.Find(Id);

		if (obj == null)
		{
			return NotFound();
		}

		return View(obj);

	}

	// POST - delete
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult DeleteWP(int? Id)
	{
		var obj = _db.Warehouses.Find(Id);
		if (obj == null)
		{
			return NotFound();
		}


		_db.Warehouses.Remove(obj);
		_db.SaveChanges();
		TempData["success"] = "The Warehouse has been deleted successfully";
		return RedirectToAction("IndexW");



	}


































}

