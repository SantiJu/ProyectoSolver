
namespace ProyectoSolver
{
    partial class TablaGen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TablaPri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataSet1 = new ProyectoSolver.DataSet1();
            this.propiedadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propiedadesTableAdapter = new ProyectoSolver.DataSet1TableAdapters.PropiedadesTableAdapter();
            this.dataSet11 = new ProyectoSolver.DataSet1();
            this.propietarios1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propietarios1TableAdapter = new ProyectoSolver.DataSet1TableAdapters.Propietarios1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propietarios1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Añadir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(124, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(229, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TablaPri
            // 
            this.TablaPri.AllowUserToAddRows = false;
            this.TablaPri.AllowUserToDeleteRows = false;
            this.TablaPri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPri.Location = new System.Drawing.Point(12, 70);
            this.TablaPri.Name = "TablaPri";
            this.TablaPri.RowHeadersWidth = 62;
            this.TablaPri.RowTemplate.Height = 28;
            this.TablaPri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaPri.Size = new System.Drawing.Size(769, 368);
            this.TablaPri.TabIndex = 6;
            this.TablaPri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPrin_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ver por";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(515, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Propietarios";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(647, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Propiedades";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propiedadesBindingSource
            // 
            this.propiedadesBindingSource.DataMember = "Propiedades";
            this.propiedadesBindingSource.DataSource = this.dataSet1;
            // 
            // propiedadesTableAdapter
            // 
            this.propiedadesTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propietarios1BindingSource
            // 
            this.propietarios1BindingSource.DataMember = "Propietarios1";
            this.propietarios1BindingSource.DataSource = this.dataSet1;
            // 
            // propietarios1TableAdapter
            // 
            this.propietarios1TableAdapter.ClearBeforeFill = true;
            // 
            // TablaGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaPri);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "TablaGen";
            this.Text = "Tabla Inmobiliaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propiedadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propietarios1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource propiedadesBindingSource;
        private DataSet1TableAdapters.PropiedadesTableAdapter propiedadesTableAdapter;
        private System.Windows.Forms.DataGridView TablaPri;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.BindingSource propietarios1BindingSource;
        private DataSet1TableAdapters.Propietarios1TableAdapter propietarios1TableAdapter;
    }
}

