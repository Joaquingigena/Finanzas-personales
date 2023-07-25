namespace Presentacion
{
    partial class frmAgregarMovimiento
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
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbIngreso = new System.Windows.Forms.RadioButton();
            this.rdbGasto = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblMovimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMovimiento.Location = new System.Drawing.Point(207, 24);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(75, 25);
            this.lblMovimiento.TabIndex = 0;
            this.lblMovimiento.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGasto);
            this.groupBox1.Controls.Add(this.rdbIngreso);
            this.groupBox1.Location = new System.Drawing.Point(137, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 65);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdbIngreso
            // 
            this.rdbIngreso.AutoSize = true;
            this.rdbIngreso.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIngreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbIngreso.Location = new System.Drawing.Point(24, 20);
            this.rdbIngreso.Name = "rdbIngreso";
            this.rdbIngreso.Size = new System.Drawing.Size(86, 23);
            this.rdbIngreso.TabIndex = 0;
            this.rdbIngreso.TabStop = true;
            this.rdbIngreso.Text = "Ingreso";
            this.rdbIngreso.UseVisualStyleBackColor = true;
            // 
            // rdbGasto
            // 
            this.rdbGasto.AutoSize = true;
            this.rdbGasto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGasto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbGasto.Location = new System.Drawing.Point(174, 20);
            this.rdbGasto.Name = "rdbGasto";
            this.rdbGasto.Size = new System.Drawing.Size(73, 23);
            this.rdbGasto.TabIndex = 1;
            this.rdbGasto.TabStop = true;
            this.rdbGasto.Text = "Gasto";
            this.rdbGasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbGasto.UseVisualStyleBackColor = true;
            // 
            // frmAgregarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(576, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMovimiento);
            this.Name = "frmAgregarMovimiento";
            this.Text = "Agregar movimiento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbGasto;
        private System.Windows.Forms.RadioButton rdbIngreso;
    }
}