namespace EscuelaCiegos
{
	partial class FrmEstudiante
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
			this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
			this.btnVolver = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCarnet = new System.Windows.Forms.TextBox();
			this.txtPrimerApellido = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSegundoApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.cmbNivel = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEstudiantes
			// 
			this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEstudiantes.Location = new System.Drawing.Point(12, 181);
			this.dgvEstudiantes.Name = "dgvEstudiantes";
			this.dgvEstudiantes.ReadOnly = true;
			this.dgvEstudiantes.RowHeadersWidth = 51;
			this.dgvEstudiantes.RowTemplate.Height = 24;
			this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEstudiantes.Size = new System.Drawing.Size(776, 314);
			this.dgvEstudiantes.TabIndex = 11;
			this.dgvEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellContentClick);
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(672, 126);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(116, 49);
			this.btnVolver.TabIndex = 16;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(378, 126);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(116, 49);
			this.btnLimpiar.TabIndex = 15;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(256, 126);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(116, 49);
			this.btnEliminar.TabIndex = 14;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(134, 126);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(116, 49);
			this.btnEditar.TabIndex = 13;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(12, 126);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(116, 49);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "Nombre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Carnet:";
			// 
			// txtCarnet
			// 
			this.txtCarnet.Location = new System.Drawing.Point(83, 12);
			this.txtCarnet.Name = "txtCarnet";
			this.txtCarnet.Size = new System.Drawing.Size(198, 22);
			this.txtCarnet.TabIndex = 25;
			// 
			// txtPrimerApellido
			// 
			this.txtPrimerApellido.Location = new System.Drawing.Point(387, 11);
			this.txtPrimerApellido.Name = "txtPrimerApellido";
			this.txtPrimerApellido.Size = new System.Drawing.Size(198, 22);
			this.txtPrimerApellido.TabIndex = 29;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(295, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 28;
			this.label3.Text = "2do Apellido:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(295, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 16);
			this.label4.TabIndex = 27;
			this.label4.Text = "1er Apellido:";
			// 
			// txtSegundoApellido
			// 
			this.txtSegundoApellido.Location = new System.Drawing.Point(387, 43);
			this.txtSegundoApellido.Name = "txtSegundoApellido";
			this.txtSegundoApellido.Size = new System.Drawing.Size(198, 22);
			this.txtSegundoApellido.TabIndex = 30;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(83, 46);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(198, 22);
			this.txtNombre.TabIndex = 31;
			// 
			// cmbNivel
			// 
			this.cmbNivel.FormattingEnabled = true;
			this.cmbNivel.Location = new System.Drawing.Point(83, 86);
			this.cmbNivel.Name = "cmbNivel";
			this.cmbNivel.Size = new System.Drawing.Size(198, 24);
			this.cmbNivel.TabIndex = 32;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 16);
			this.label5.TabIndex = 33;
			this.label5.Text = "Nivel:";
			// 
			// FrmEstudiante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 507);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbNivel);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtSegundoApellido);
			this.Controls.Add(this.txtPrimerApellido);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCarnet);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvEstudiantes);
			this.Name = "FrmEstudiante";
			this.Text = "INFORMACION ESTUDIANTE";
			((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dgvEstudiantes;
		private System.Windows.Forms.Button btnVolver;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCarnet;
		private System.Windows.Forms.TextBox txtPrimerApellido;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSegundoApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.ComboBox cmbNivel;
		private System.Windows.Forms.Label label5;
	}
}