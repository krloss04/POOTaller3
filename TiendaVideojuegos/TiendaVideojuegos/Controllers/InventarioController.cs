using Microsoft.AspNetCore.Mvc;
using TiendaVideojuegos.Models;

namespace TiendaVideojuegos.Controllers
{
	public class InventarioController : Controller
	{
		// Lista estática para mantener los datos simulados en memoria durante la ejecución
		private static List<Videojuego> _inventario = new List<Videojuego>
		{
			new Videojuego { IdProducto = 1, Nombre = "The Legend of Zelda", Plataforma = "Nintendo Switch", Precio = 59.99m, Stock = 15, FechaIngreso = new DateTime(2023, 5, 12) },
			new Videojuego { IdProducto = 2, Nombre = "God of War Ragnarok", Plataforma = "PlayStation 5", Precio = 69.99m, Stock = 10, FechaIngreso = new DateTime(2022, 11, 9) },
			new Videojuego { IdProducto = 3, Nombre = "Halo Infinite", Plataforma = "Xbox Series X", Precio = 39.99m, Stock = 8, FechaIngreso = new DateTime(2021, 12, 8) },
			new Videojuego { IdProducto = 4, Nombre = "Cyberpunk 2077", Plataforma = "PC", Precio = 49.99m, Stock = 20, FechaIngreso = new DateTime(2020, 12, 10) },
			new Videojuego { IdProducto = 5, Nombre = "Super Mario Bros", Plataforma = "Nintendo Switch", Precio = 59.99m, Stock = 25, FechaIngreso = new DateTime(2023, 10, 20) }
		};

		// Acción Index ordenada
		public IActionResult Index()
		{
			var inventarioOrdenado = _inventario.OrderBy(v => v.IdProducto).ToList();
			return View(inventarioOrdenado);
		}

		// Acción Detalles
		public IActionResult Details(int id)
		{
			var juego = _inventario.FirstOrDefault(v => v.IdProducto == id);
			if (juego == null) return NotFound();
			return View(juego);
		}

		// Acción Crear (GET)
		public IActionResult Create()
		{
			return View();
		}

		// Acción Crear (POST)
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Videojuego videojuego)
		{
			if (ModelState.IsValid)
			{
				_inventario.Add(videojuego);
				return RedirectToAction(nameof(Index));
			}
			return View(videojuego);
		}

		// Acción Editar (GET)
		public IActionResult Edit(int id)
		{
			var juego = _inventario.FirstOrDefault(v => v.IdProducto == id);
			if (juego == null) return NotFound();
			return View(juego);
		}

		// Acción Editar (POST)
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, Videojuego videojuego)
		{
			if (id != videojuego.IdProducto) return NotFound();

			if (ModelState.IsValid)
			{
				var existente = _inventario.FirstOrDefault(v => v.IdProducto == id);
				if (existente != null)
				{
					existente.Nombre = videojuego.Nombre;
					existente.Plataforma = videojuego.Plataforma;
					existente.Precio = videojuego.Precio;
					existente.Stock = videojuego.Stock;
					existente.FechaIngreso = videojuego.FechaIngreso;
				}
				return RedirectToAction(nameof(Index));
			}
			return View(videojuego);
		}

		// Acción Eliminar (GET)
		public IActionResult Delete(int id)
		{
			var juego = _inventario.FirstOrDefault(v => v.IdProducto == id);
			if (juego == null) return NotFound();
			return View(juego);
		}

		// Acción Eliminar (POST)
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public IActionResult DeleteConfirmed(int id)
		{
			var juego = _inventario.FirstOrDefault(v => v.IdProducto == id);
			if (juego != null)
			{
				_inventario.Remove(juego);
			}
			return RedirectToAction(nameof(Index));
		}
	}
}