
namespace EjecucionClase_LeonardoLoza
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
            this.tbCantidad = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(34, 302);
            this.tbCantidad.Maximum = 15;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(190, 56);
            this.tbCantidad.TabIndex = 0;
            this.tbCantidad.Scroll += new System.EventHandler(this.tbCantidad_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "crear boton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("a Anti Corona", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(230, 302);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 14);
            this.lblCantidad.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "crear control";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 65);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

