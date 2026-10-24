namespace TiendaVideojuegos.Models
{
	public class Videojuego
	{
		public int IdProducto { get; set; }
		public string Nombre { get; set; }
		public string Plataforma { get; set; }
		public decimal Precio { get; set; }
		public int Stock { get; set; }
		public DateTime FechaIngreso { get; set; }
	}
}
