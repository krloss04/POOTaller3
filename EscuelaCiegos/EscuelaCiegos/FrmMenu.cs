using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaCiegos
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void btnMaterias_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmMateria frmMateria = new FrmMateria();
			frmMateria.ShowDialog();
			this.Show();
		}

		private void btnNiveles_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmNivel frmNivel = new FrmNivel();
			frmNivel.ShowDialog();
			this.Show();
		}

		private void btnEstudiantes_Click(object sender, EventArgs e)
		{
			this.Hide();
			FrmEstudiante frmEstudiante = new FrmEstudiante();
			frmEstudiante.ShowDialog();
			this.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
