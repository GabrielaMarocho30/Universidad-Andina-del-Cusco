
namespace CapaPresentacion
{
    partial class frmDocente
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
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.btnEnseñar = new System.Windows.Forms.Button();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(70, 26);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(156, 20);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(70, 65);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(156, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(121, 98);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(105, 20);
            this.txtFechaNacimiento.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(70, 137);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(156, 20);
            this.txtDni.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(70, 171);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(156, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(64, 250);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 5;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.Location = new System.Drawing.Point(145, 250);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(75, 23);
            this.btnDesaprobar.TabIndex = 6;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // btnEnseñar
            // 
            this.btnEnseñar.Location = new System.Drawing.Point(226, 250);
            this.btnEnseñar.Name = "btnEnseñar";
            this.btnEnseñar.Size = new System.Drawing.Size(75, 23);
            this.btnEnseñar.TabIndex = 7;
            this.btnEnseñar.Text = "Enseñar";
            this.btnEnseñar.UseVisualStyleBackColor = true;
            this.btnEnseñar.Click += new System.EventHandler(this.btnEnseñar_Click);
            // 
            // btnMatricular
            // 
            this.btnMatricular.Location = new System.Drawing.Point(307, 250);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(75, 23);
            this.btnMatricular.TabIndex = 8;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(70, 207);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(156, 20);
            this.txtProfesion.TabIndex = 9;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(327, 98);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 10;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(327, 135);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 11;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "DNI: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Edad : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Profesión : ";
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.btnEnseñar);
            this.Controls.Add(this.btnDesaprobar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "frmDocente";
            this.Text = "Trabajar con la clase docente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnDesaprobar;
        private System.Windows.Forms.Button btnEnseñar;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}