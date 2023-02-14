namespace GM21057Guia9Ejercicio7
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridPromedios = new System.Windows.Forms.DataGridView();
            this.promedioEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPromedios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.dataGridPromedios);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridPromedios
            // 
            this.dataGridPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPromedios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.promedioEdad,
            this.promAltura,
            this.nombreComun});
            this.dataGridPromedios.Location = new System.Drawing.Point(6, 22);
            this.dataGridPromedios.Name = "dataGridPromedios";
            this.dataGridPromedios.RowTemplate.Height = 25;
            this.dataGridPromedios.Size = new System.Drawing.Size(344, 139);
            this.dataGridPromedios.TabIndex = 0;
            // 
            // promedioEdad
            // 
            this.promedioEdad.HeaderText = "Promedio de Edad";
            this.promedioEdad.Name = "promedioEdad";
            // 
            // promAltura
            // 
            this.promAltura.HeaderText = "Promedio de Altura (cm)";
            this.promAltura.Name = "promAltura";
            // 
            // nombreComun
            // 
            this.nombreComun.HeaderText = "Nombre mas comun";
            this.nombreComun.Name = "nombreComun";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(145, 167);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Regresar";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 214);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Resumen";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPromedios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridPromedios;
        private Button buttonSalir;
        private DataGridViewTextBoxColumn promedioEdad;
        private DataGridViewTextBoxColumn promAltura;
        private DataGridViewTextBoxColumn nombreComun;
    }
}