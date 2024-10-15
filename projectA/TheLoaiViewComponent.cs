using Microsoft.AspNetCore.Mvc;
using projectA.Data;
using System;

public class TheLoaiViewComponent: ViewComponent
{
	private readonly ApplicationDbContext _db;
	public TheLoaiViewComponent(ApplicationDbContext db)
	{  _db = db; }
	public IViewComponentResult Invoke()
	{  
		var theloai = _db.TheLoai.ToList();
		return View();
	}
}
