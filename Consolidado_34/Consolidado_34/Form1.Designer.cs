namespace Consolidado_34
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
            this.btnAplicacion1 = new System.Windows.Forms.Button();
            this.btnAplicacion2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAplicacion3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAplicacion1
            // 
            this.btnAplicacion1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAplicacion1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAplicacion1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicacion1.Location = new System.Drawing.Point(111, 95);
            this.btnAplicacion1.Name = "btnAplicacion1";
            this.btnAplicacion1.Size = new System.Drawing.Size(131, 44);
            this.btnAplicacion1.TabIndex = 0;
            this.btnAplicacion1.Text = "Daniel Vinasco";
            this.btnAplicacion1.UseVisualStyleBackColor = false;
            this.btnAplicacion1.Click += new System.EventHandler(this.btnAplicacion1_Click);
            // 
            // btnAplicacion2
            // 
            this.btnAplicacion2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAplicacion2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicacion2.Location = new System.Drawing.Point(111, 158);
            this.btnAplicacion2.Name = "btnAplicacion2";
            this.btnAplicacion2.Size = new System.Drawing.Size(170, 44);
            this.btnAplicacion2.TabIndex = 1;
            this.btnAplicacion2.Text = "Yuliana Echeverry";
            this.btnAplicacion2.UseVisualStyleBackColor = false;
            this.btnAplicacion2.Click += new System.EventHandler(this.btnAplicacion2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAplicacion3
            // 
            this.btnAplicacion3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAplicacion3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicacion3.Location = new System.Drawing.Point(111, 233);
            this.btnAplicacion3.Name = "btnAplicacion3";
            this.btnAplicacion3.Size = new System.Drawing.Size(170, 39);
            this.btnAplicacion3.TabIndex = 3;
            this.btnAplicacion3.Text = "Jessica Lozano";
            this.btnAplicacion3.UseVisualStyleBackColor = false;
            this.btnAplicacion3.Click += new System.EventHandler(this.btnAplicacion3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAplicacion3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAplicacion2);
            this.Controls.Add(this.btnAplicacion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAplicacion1;
        private System.Windows.Forms.Button btnAplicacion2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAplicacion3;
    }
}

