using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscuelaCiegos.Modelo;

namespace EscuelaCiegos
{
	public partial class FrmEstudiante : Form
	{
		private string carnetSeleccionado = ""; // Variable para almacenar el carnet del estudiante seleccionado
		public FrmEstudiante()
		{
			InitializeComponent();
			CargarEstudiantes(); // Cargar los estudiantes al iniciar el formulario
			CargarNiveles(); // Cargar los niveles al iniciar el formulario
		}

		// METODOS

		private void CargarEstudiantes() // Método para cargar los estudiantes desde la base de datos
		{
			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				var lista = from e in db.Estudiante // Consulta LINQ para obtener los estudiantes y sus niveles
							select new
							{
								e.Carnet,
								e.Nombre,
								e.PrimerApellido,
								e.SegundoApellido,
								e.CodNivel,
								NombreNivel = e.Nivel.NombreNivel
							};
				dgvEstudiantes.DataSource = lista.ToList(); // Asignar la lista de estudiantes al DataGridView

				if (dgvEstudiantes.Columns["CodNivel"] != null)
				{
					dgvEstudiantes.Columns["CodNivel"].Visible = false; // Ocultamos la columna del código de nivel
				}
			}
		}

		private void CargarNiveles() // Método para cargar los niveles desde la base de datos
		{
			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				var nivelesUnicos = db.Nivel // Consulta LINQ para obtener los niveles únicos
							.OrderBy(n => n.CodNivel)
							.ToList()
							.GroupBy(n => n.NombreNivel)
							.Select(g => g.First())
							.ToList();

				cmbNivel.DataSource = nivelesUnicos; // Asignar la lista de niveles al ComboBox
				cmbNivel.DisplayMember = "NombreNivel";
				cmbNivel.ValueMember = "CodNivel";
			}
		}

		private void LimpiarCampos()
		{
			txtCarnet.Clear();
			txtNombre.Clear();
			txtPrimerApellido.Clear();
			txtSegundoApellido.Clear();
			carnetSeleccionado = "";
			if (cmbNivel.Items.Count > 0) cmbNivel.SelectedIndex = 0; // Seleccionamos el primer nivel en el ComboBox
			txtCarnet.Focus();
		}

		// DGV

		private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento que se dispara al hacer clic en una celda del DataGridView
		{
			if (e.RowIndex >= 0) // Verificar que se haya hecho clic en una fila válida
			{
				DataGridViewRow row = dgvEstudiantes.Rows[e.RowIndex];
				carnetSeleccionado = row.Cells["Carnet"].Value.ToString();
				txtCarnet.Text = carnetSeleccionado;
				txtNombre.Text = row.Cells["Nombre"].Value.ToString();
				txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value.ToString();
				txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value.ToString();
				cmbNivel.SelectedValue = row.Cells["CodNivel"].Value;
			}
		}


		// BOTONES

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				var nuevoEstudiante = new Estudiante // Crear un nuevo objeto Estudiante
				{
					Carnet = txtCarnet.Text,
					Nombre = txtNombre.Text,
					PrimerApellido = txtPrimerApellido.Text,
					SegundoApellido = txtSegundoApellido.Text,
					CodNivel = Convert.ToInt32(cmbNivel.SelectedValue)
				};

				db.Estudiante.Add(nuevoEstudiante); // Agregar el nuevo estudiante a la base de datos
				db.SaveChanges(); // Guardar los cambios en la base de datos
			}

			MessageBox.Show("Estudiante guardado correctamente.");
			CargarEstudiantes();
			LimpiarCampos();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(carnetSeleccionado)) // Verificar si se ha seleccionado un estudiante
			{
				MessageBox.Show("Por favor, seleccione un estudiante de la tabla.");
				return;
			}

			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				string carnet = carnetSeleccionado;
				var estudianteAEditar = db.Estudiante.FirstOrDefault(es => es.Carnet == carnet); // Buscar el estudiante en la base de datos por su carnet

				if (estudianteAEditar != null) // Verificar si se encontró el estudiante
				{
					estudianteAEditar.Nombre = txtNombre.Text;
					estudianteAEditar.PrimerApellido = txtPrimerApellido.Text;
					estudianteAEditar.SegundoApellido = txtSegundoApellido.Text;
					estudianteAEditar.CodNivel = Convert.ToInt32(cmbNivel.SelectedValue);
					db.SaveChanges(); // Guardar los cambios en la base de datos
				}
			}

			MessageBox.Show("Estudiante modificado correctamente.");
			CargarEstudiantes();
			LimpiarCampos();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(carnetSeleccionado)) // Verificar si se ha seleccionado un estudiante
			{
				MessageBox.Show("Por favor, seleccione un estudiante de la tabla.");
				return;
			}

			using (var db = new EscuelaCiegosDBEntities1()) // Crear una instancia del contexto de la base de datos
			{
				string carnet = carnetSeleccionado;
				var estudianteAEliminar = db.Estudiante.FirstOrDefault(es => es.Carnet == carnet); // Buscar el estudiante en la base de datos por su carnet

				if (estudianteAEliminar != null) // Verificar si se encontró el estudiante
				{
					db.Estudiante.Remove(estudianteAEliminar);
					db.SaveChanges(); // Guardar los cambios en la base de datos
				}
			}

			MessageBox.Show("Estudiante eliminado correctamente.");
			CargarEstudiantes();
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
