namespace PracticaBitsYBytes
{
    partial class Form1
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
            this.cmd_Procesar = new System.Windows.Forms.Button();
            this.cmd_AjustarF = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtFechaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sensor2 = new System.Windows.Forms.PictureBox();
            this.nivel = new System.Windows.Forms.PictureBox();
            this.direccion = new System.Windows.Forms.PictureBox();
            this.sensor1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.sensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_Procesar
            // 
            this.cmd_Procesar.Location = new System.Drawing.Point(216, 66);
            this.cmd_Procesar.Name = "cmd_Procesar";
            this.cmd_Procesar.Size = new System.Drawing.Size(75, 23);
            this.cmd_Procesar.TabIndex = 0;
            this.cmd_Procesar.Text = "Procesar";
            this.cmd_Procesar.UseVisualStyleBackColor = true;
            this.cmd_Procesar.Click += new System.EventHandler(this.cmd_Procesar_Click);
            // 
            // cmd_AjustarF
            // 
            this.cmd_AjustarF.Location = new System.Drawing.Point(100, 334);
            this.cmd_AjustarF.Name = "cmd_AjustarF";
            this.cmd_AjustarF.Size = new System.Drawing.Size(103, 23);
            this.cmd_AjustarF.TabIndex = 1;
            this.cmd_AjustarF.Text = "Ajuste de fecha";
            this.cmd_AjustarF.UseVisualStyleBackColor = true;
            this.cmd_AjustarF.Click += new System.EventHandler(this.cmd_AjustarF_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(83, 68);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 2;
            // 
            // txtFechaA
            // 
            this.txtFechaA.Location = new System.Drawing.Point(68, 363);
            this.txtFechaA.Name = "txtFechaA";
            this.txtFechaA.Size = new System.Drawing.Size(160, 20);
            this.txtFechaA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(25, 271);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(87, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de lectura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sensores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nivel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // sensor2
            // 
            this.sensor2.ErrorImage = null;
            this.sensor2.Image = global::PracticaBitsYBytes.Properties.Resources.luz_led__3_;
            this.sensor2.InitialImage = null;
            this.sensor2.Location = new System.Drawing.Point(68, 155);
            this.sensor2.Name = "sensor2";
            this.sensor2.Size = new System.Drawing.Size(61, 50);
            this.sensor2.TabIndex = 11;
            this.sensor2.TabStop = false;
            // 
            // nivel
            // 
            this.nivel.Image = global::PracticaBitsYBytes.Properties.Resources.bateria__4_;
            this.nivel.Location = new System.Drawing.Point(156, 138);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(62, 67);
            this.nivel.TabIndex = 12;
            this.nivel.TabStop = false;
            // 
            // direccion
            // 
            this.direccion.Image = global::PracticaBitsYBytes.Properties.Resources.brujula;
            this.direccion.Location = new System.Drawing.Point(230, 138);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(61, 67);
            this.direccion.TabIndex = 13;
            this.direccion.TabStop = false;
            // 
            // sensor1
            // 
            this.sensor1.Image = global::PracticaBitsYBytes.Properties.Resources.luz_led__3_;
            this.sensor1.Location = new System.Drawing.Point(0, 155);
            this.sensor1.Name = "sensor1";
            this.sensor1.Size = new System.Drawing.Size(62, 50);
            this.sensor1.TabIndex = 14;
            this.sensor1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 308);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 467);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sensor1);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.sensor2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaA);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.cmd_AjustarF);
            this.Controls.Add(this.cmd_Procesar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Procesar;
        private System.Windows.Forms.Button cmd_AjustarF;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtFechaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox sensor2;
        private System.Windows.Forms.PictureBox nivel;
        private System.Windows.Forms.PictureBox direccion;
        private System.Windows.Forms.PictureBox sensor1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

