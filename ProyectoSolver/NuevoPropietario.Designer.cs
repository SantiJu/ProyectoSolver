
namespace ProyectoSolver
{
    partial class NuevoPropietario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNom = new System.Windows.Forms.TextBox();
            this.AddApe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddTel1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // AddNom
            // 
            this.AddNom.Location = new System.Drawing.Point(169, 33);
            this.AddNom.Name = "AddNom";
            this.AddNom.Size = new System.Drawing.Size(292, 26);
            this.AddNom.TabIndex = 3;
            // 
            // AddApe
            // 
            this.AddApe.Location = new System.Drawing.Point(169, 98);
            this.AddApe.Name = "AddApe";
            this.AddApe.Size = new System.Drawing.Size(291, 26);
            this.AddApe.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTel1
            // 
            this.AddTel1.Location = new System.Drawing.Point(172, 160);
            this.AddTel1.Mask = "(999)000-0000";
            this.AddTel1.Name = "AddTel1";
            this.AddTel1.Size = new System.Drawing.Size(288, 26);
            this.AddTel1.TabIndex = 7;
            // 
            // NuevoPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 253);
            this.Controls.Add(this.AddTel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddApe);
            this.Controls.Add(this.AddNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoPropietario";
            this.Load += new System.EventHandler(this.NuevoPropietario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddNom;
        private System.Windows.Forms.TextBox AddApe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox AddTel1;
    }
}