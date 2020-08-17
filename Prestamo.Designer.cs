namespace interfaz
{
    partial class ventanaPrestamo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrestamo));
            this.saludos = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datosPersonales = new System.Windows.Forms.Panel();
            this.lugar = new System.Windows.Forms.ComboBox();
            this.raza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datosPrestamos = new System.Windows.Forms.Panel();
            this.monto = new System.Windows.Forms.TextBox();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.datosPersonales.SuspendLayout();
            this.datosPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludos
            // 
            this.saludos.AutoSize = true;
            this.saludos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludos.ForeColor = System.Drawing.Color.OrangeRed;
            this.saludos.Location = new System.Drawing.Point(70, 45);
            this.saludos.Name = "saludos";
            this.saludos.Size = new System.Drawing.Size(141, 24);
            this.saludos.TabIndex = 0;
            this.saludos.Text = "BIENVENIDO,";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(613, 388);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 50);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(275, 286);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(124, 76);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "CONFIRMAR PRESTAMO";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(464, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalles de Prestamo";
            // 
            // datosPersonales
            // 
            this.datosPersonales.BackColor = System.Drawing.Color.DarkOrange;
            this.datosPersonales.Controls.Add(this.lugar);
            this.datosPersonales.Controls.Add(this.raza);
            this.datosPersonales.Controls.Add(this.label4);
            this.datosPersonales.Controls.Add(this.label3);
            this.datosPersonales.Location = new System.Drawing.Point(36, 147);
            this.datosPersonales.Name = "datosPersonales";
            this.datosPersonales.Size = new System.Drawing.Size(315, 133);
            this.datosPersonales.TabIndex = 5;
            // 
            // lugar
            // 
            this.lugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lugar.FormattingEnabled = true;
            this.lugar.Location = new System.Drawing.Point(185, 87);
            this.lugar.Name = "lugar";
            this.lugar.Size = new System.Drawing.Size(121, 21);
            this.lugar.TabIndex = 3;
            // 
            // raza
            // 
            this.raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raza.FormattingEnabled = true;
            this.raza.Location = new System.Drawing.Point(185, 21);
            this.raza.Name = "raza";
            this.raza.Size = new System.Drawing.Size(121, 21);
            this.raza.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "LUGAR DE ORIGEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(112, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "RAZA";
            // 
            // datosPrestamos
            // 
            this.datosPrestamos.BackColor = System.Drawing.Color.DarkOrange;
            this.datosPrestamos.Controls.Add(this.monto);
            this.datosPrestamos.Controls.Add(this.cuotas);
            this.datosPrestamos.Controls.Add(this.label6);
            this.datosPrestamos.Controls.Add(this.label5);
            this.datosPrestamos.Location = new System.Drawing.Point(414, 147);
            this.datosPrestamos.Name = "datosPrestamos";
            this.datosPrestamos.Size = new System.Drawing.Size(341, 133);
            this.datosPrestamos.TabIndex = 6;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(210, 21);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(121, 20);
            this.monto.TabIndex = 4;
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(210, 90);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(121, 21);
            this.cuotas.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(123, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "CUOTAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(1, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "MONTO DE PRESTAMO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ventanaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.datosPrestamos);
            this.Controls.Add(this.datosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.saludos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ventanaPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.ventanaPrestamo_Load);
            this.datosPersonales.ResumeLayout(false);
            this.datosPersonales.PerformLayout();
            this.datosPrestamos.ResumeLayout(false);
            this.datosPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel datosPersonales;
        private System.Windows.Forms.Panel datosPrestamos;
        private System.Windows.Forms.ComboBox lugar;
        private System.Windows.Forms.ComboBox raza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}