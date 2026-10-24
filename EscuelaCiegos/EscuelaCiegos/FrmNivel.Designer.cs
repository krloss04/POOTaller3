namespace EscuelaCiegos
{
	partial class FrmNivel
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvNiveles = new System.Windows.Forms.DataGridView();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbMateria = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnVolver = new System.Windows.Forms.Button();
			this.cmbNivel = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvNiveles
			// 
			this.dgvNiveles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNiveles.Location = new System.Drawing.Point(12, 132);
			this.dgvNiveles.Name = "dgvNiveles";
			this.dgvNiveles.ReadOnly = true;
			this.dgvNiveles.RowHeadersWidth = 51;
			this.dgvNiveles.RowTemplate.Height = 24;
			this.dgvNiveles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNiveles.Size = new System.Drawing.Size(776, 306);
			this.dgvNiveles.TabIndex = 12;
			this.dgvNiveles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNivel_CellContentClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(377, 77);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(116, 49);
			this.btnLimpiar.TabIndex = 16;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(255, 77);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(116, 49);
			this.btnEliminar.TabIndex = 15;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(133, 77);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(116, 49);
			this.btnEditar.TabIndex = 14;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(11, 77);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(116, 49);
			this.btnGuardar.TabIndex = 13;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Materia:";
			// 
			// cmbMateria
			// 
			this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMateria.FormattingEnabled = true;
			this.cmbMateria.Location = new System.Drawing.Point(72, 11);
			this.cmbMateria.Name = "cmbMateria";
			this.cmbMateria.Size = new System.Drawing.Size(299, 24);
			this.cmbMateria.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Nivel:";
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(672, 77);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(116, 49);
			this.btnVolver.TabIndex = 22;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// cmbNivel
			// 
			this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNivel.FormattingEnabled = true;
			this.cmbNivel.Location = new System.Drawing.Point(72, 46);
			this.cmbNivel.Name = "cmbNivel";
			this.cmbNivel.Size = new System.Drawing.Size(196, 24);
			this.cmbNivel.TabIndex = 23;
			// 
			// FrmNivel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmbNivel);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbMateria);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvNiveles);
			this.Name = "FrmNivel";
			this.Text = "INFORMACION NIVEL";
			((System.ComponentModel.ISupportInitialize)(this.dgvNiveles)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvNiveles;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbMateria;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.ComboBox cmbNivel;
	}
}