using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EscuelaCiegos.Modelo;

namespace EscuelaCiegos
{
	public partial class FrmNivel : Form
	{
		private int CodNivelSeleccionado = 0; // Variable para almacenar el código del nivel seleccionado

		public FrmNivel()
		{
			InitializeComponent();
			CargarNiveles(); // Cargar los niveles al iniciar el formulario
			CargarMaterias(); // Cargar las materias al iniciar el formulario
			CargarNivelesComboBox(); // Cargar las opciones fijas en el ComboBox de niveles
		}

		// METODOS

		private void CargarNiveles() // Método para cargar los niveles desde la base de datos
		{
			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				var lista = from m in db.Nivel // Consulta LINQ para obtener los niveles
							select new
							{
								m.CodNivel,
								m.CodMateria,
								NombreMateria = m.Materia.NombreMateria,
								m.NombreNivel
							};
				dgvNiveles.DataSource = lista.ToList(); // Asignar la lista de niveles al DataGridView

				if (dgvNiveles.Columns["CodNivel"] != null)
				{
					dgvNiveles.Columns["CodNivel"].Visible = false; // Ocultar la columna del código nivel
				}
			}
		}

		private void CargarMaterias()
		{
			using (var db = new EscuelaCiegosDBEntities1())
			{
				cmbMateria.DataSource = db.Materia.ToList();
				cmbMateria.DisplayMember = "NombreMateria"; // Lo que el usuario verá en la lista
				cmbMateria.ValueMember = "CodMateria"; // El ID interno que se guardará al seleccionarlo
			}
		}

		private void CargarNivelesComboBox()
		{
			cmbNivel.Items.Clear();
			cmbNivel.Items.Add("Nivel Basico");
			cmbNivel.Items.Add("Nivel Intermedio");
			cmbNivel.Items.Add("Nivel Avanzado");
		}

		private void LimpiarCampos()
		{
			CodNivelSeleccionado = 0;
			if (cmbMateria.Items.Count > 0) cmbMateria.SelectedIndex = 0;
			if (cmbNivel.Items.Count > 0) cmbNivel.SelectedIndex = -1;
			cmbMateria.Focus();
		}

		// DGV

		private void dgvNivel_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvNiveles.Rows[e.RowIndex];
				CodNivelSeleccionado = Convert.ToInt32(row.Cells["CodNivel"].Value); // Capturar el CodNivel oculto
				cmbNivel.Text = row.Cells["NombreNivel"].Value.ToString(); // Mostrar el nivel seleccionado en el ComboBox
				cmbMateria.SelectedValue = row.Cells["CodMateria"].Value; // Seleccionar la materia correspondiente
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (cmbNivel.SelectedIndex == -1)
			{
				MessageBox.Show("Por favor, seleccione un nivel.");
				return;
			}

			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				var nuevoNivel = new Nivel
				{
					NombreNivel = cmbNivel.Text, // Captura la opción seleccionada del ComboBox
					CodMateria = Convert.ToInt32(cmbMateria.SelectedValue)
				};

				db.Nivel.Add(nuevoNivel); // Agregar el nuevo nivel a la base de datos
				db.SaveChanges(); // Guardar los cambios en la base de datos
			}

			MessageBox.Show("Nivel guardado correctamente.");
			CargarNiveles();
			LimpiarCampos();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (CodNivelSeleccionado == 0) // Verificar si se ha seleccionado un nivel antes de intentar editarlo
			{
				MessageBox.Show("Por favor, seleccione un nivel de la tabla.");
				return;
			}

			if (cmbNivel.SelectedIndex == -1)
			{
				MessageBox.Show("Por favor, seleccione un nivel.");
				return;
			}

			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				int id = CodNivelSeleccionado;
				var nivelAEditar = db.Nivel.FirstOrDefault(n => n.CodNivel == id); // Buscar el nivel a editar en la base de datos

				if (nivelAEditar != null) // Verificar si se encontró el nivel a editar
				{
					nivelAEditar.NombreNivel = cmbNivel.Text;
					nivelAEditar.CodMateria = Convert.ToInt32(cmbMateria.SelectedValue); // Actualizar la materia asociada al nivel
					db.SaveChanges(); // Guardar los cambios en la base de datos
				}
			}

			MessageBox.Show("Nivel modificado correctamente.");
			CargarNiveles();
			LimpiarCampos();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (CodNivelSeleccionado == 0)
			{
				MessageBox.Show("Por favor, seleccione un nivel de la tabla.");
				return;
			}

			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				int id = CodNivelSeleccionado;
				var nivelAEliminar = db.Nivel.FirstOrDefault(n => n.CodNivel == id); // Buscar el nivel a eliminar en la base de datos

				if (nivelAEliminar != null) // Verificar si se encontró el nivel a eliminar
				{
					db.Nivel.Remove(nivelAEliminar); // Eliminar el nivel de la base de datos
					db.SaveChanges(); // Guardar los cambios en la base de datos
				}
			}

			MessageBox.Show("Nivel eliminado correctamente.");
			CargarNiveles();
			LimpiarCampos();
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
