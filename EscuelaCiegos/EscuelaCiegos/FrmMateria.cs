using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EscuelaCiegos.Modelo;

namespace EscuelaCiegos
{
	public partial class FrmMateria : Form
	{
		private int CodMateriaSeleccionada = 0; // Variable para almacenar el código de la materia seleccionada
		public FrmMateria()
		{
			InitializeComponent();
			CargarMaterias(); // Cargar las materias al iniciar el formulario
		}

		// METODOS

		private void CargarMaterias() // Método para cargar las materias desde la base de datos
		{
			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				var lista = from m in db.Materia // Consulta LINQ para obtener las materias
							select new
							{
								m.CodMateria,
								m.NombreMateria
							};
				dgvMaterias.DataSource = lista.ToList(); // Asignar la lista de materias al DataGridView
			}
		}
		private void LimpiarCampos()
		{
			txtNombreMateria.Clear();
			CodMateriaSeleccionada = 0;
			txtNombreMateria.Focus();
		}

		// DGV

		private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento que se dispara al hacer clic en una celda del DataGridView
		{
			if (e.RowIndex >= 0) // Verificar que se haya hecho clic en una fila válida
			{
				DataGridViewRow row = dgvMaterias.Rows[e.RowIndex];
				CodMateriaSeleccionada = Convert.ToInt32(row.Cells["CodMateria"].Value);
				txtNombreMateria.Text = row.Cells["NombreMateria"].Value.ToString();
			}
		}

		// BOTONES

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				var nuevaMateria = new Materia() // Crear una nuevo objeto Materia
				{
					NombreMateria = txtNombreMateria.Text
				};

				db.Materia.Add(nuevaMateria); // Agregar la nueva materia a la base de datos
				db.SaveChanges(); // Guardar los cambios en la base de datos
			}

			MessageBox.Show("Materia guardada correctamente.");
			CargarMaterias();
			LimpiarCampos();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (CodMateriaSeleccionada == 0) // Verificar si se ha seleccionado una materia antes de intentar editarla
			{
				MessageBox.Show("Por favor, seleccione una materia de la tabla.");
				return;
			}

			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				int id = CodMateriaSeleccionada;
				var materiaAEditar = db.Materia.FirstOrDefault(m => m.CodMateria == id); // Buscar la materia a editar en la base de datos

				if (materiaAEditar != null) // Verificar si se encontró la materia a editar
				{
					materiaAEditar.NombreMateria = txtNombreMateria.Text; // Actualizar el nombre de la materia
					db.SaveChanges(); // Guardar los cambios en la base de datos
				}
			}

			MessageBox.Show("Materia modificada correctamente.");
			CargarMaterias();
			LimpiarCampos();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (CodMateriaSeleccionada == 0) // Verificar si se ha seleccionado una materia antes de intentar eliminarla
			{
				MessageBox.Show("Por favor, seleccione una materia de la tabla.");
				return;
			}

			try
			{
				using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
				{
					int id = CodMateriaSeleccionada;
					var materiaAEliminar = db.Materia.FirstOrDefault(m => m.CodMateria == id); // Buscar la materia a eliminar en la base de datos

					if (materiaAEliminar != null) // Verificar si se encontró la materia a eliminar
					{
						db.Materia.Remove(materiaAEliminar); // Eliminar la materia de la base de datos
						db.SaveChanges(); // Guardar los cambios en la base de datos
					}
				}

				MessageBox.Show("Materia eliminada correctamente.");
				CargarMaterias();
				LimpiarCampos();
			}
			catch (Exception) // Si la materia esta asociada a un nivel no se borrara
			{
				MessageBox.Show("No se puede eliminar esta materia porque está asociada a uno o más niveles.", "Error de restricción");
			}
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}