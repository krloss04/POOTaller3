namespace EscuelaCiegos
{
	partial class FrmMenu
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
			this.btnEstudiantes = new System.Windows.Forms.Button();
			this.btnNiveles = new System.Windows.Forms.Button();
			this.btnMaterias = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEstudiantes
			// 
			this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEstudiantes.Location = new System.Drawing.Point(531, 161);
			this.btnEstudiantes.Name = "btnEstudiantes";
			this.btnEstudiantes.Size = new System.Drawing.Size(212, 153);
			this.btnEstudiantes.TabIndex = 2;
			this.btnEstudiantes.Text = "Estudiantes";
			this.btnEstudiantes.UseVisualStyleBackColor = true;
			this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
			// 
			// btnNiveles
			// 
			this.btnNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNiveles.Location = new System.Drawing.Point(289, 161);
			this.btnNiveles.Name = "btnNiveles";
			this.btnNiveles.Size = new System.Drawing.Size(212, 153);
			this.btnNiveles.TabIndex = 3;
			this.btnNiveles.Text = "Niveles";
			this.btnNiveles.UseVisualStyleBackColor = true;
			this.btnNiveles.Click += new System.EventHandler(this.btnNiveles_Click);
			// 
			// btnMaterias
			// 
			this.btnMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaterias.Location = new System.Drawing.Point(46, 161);
			this.btnMaterias.Name = "btnMaterias";
			this.btnMaterias.Size = new System.Drawing.Size(212, 153);
			this.btnMaterias.TabIndex = 4;
			this.btnMaterias.Text = "Materias";
			this.btnMaterias.UseVisualStyleBackColor = true;
			this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(474, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Base de Datos Escuela de Ciegos";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(602, 392);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(186, 46);
			this.button1.TabIndex = 6;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMaterias);
			this.Controls.Add(this.btnNiveles);
			this.Controls.Add(this.btnEstudiantes);
			this.Name = "FrmMenu";
			this.Text = "FrmMenu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEstudiantes;
		private System.Windows.Forms.Button btnNiveles;
		private System.Windows.Forms.Button btnMaterias;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}