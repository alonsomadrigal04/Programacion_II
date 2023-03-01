namespace Semafoto
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
            this.verdePB = new System.Windows.Forms.PictureBox();
            this.amarilloPB = new System.Windows.Forms.PictureBox();
            this.rojoPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.permitirCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.verdePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amarilloPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // verdePB
            // 
            this.verdePB.AccessibleName = "verdePB";
            this.verdePB.BackColor = System.Drawing.Color.Black;
            this.verdePB.Location = new System.Drawing.Point(391, 176);
            this.verdePB.Name = "verdePB";
            this.verdePB.Size = new System.Drawing.Size(106, 99);
            this.verdePB.TabIndex = 0;
            this.verdePB.TabStop = false;
            // 
            // amarilloPB
            // 
            this.amarilloPB.AccessibleName = "amarilloPB";
            this.amarilloPB.BackColor = System.Drawing.Color.Black;
            this.amarilloPB.Location = new System.Drawing.Point(204, 176);
            this.amarilloPB.Name = "amarilloPB";
            this.amarilloPB.Size = new System.Drawing.Size(106, 99);
            this.amarilloPB.TabIndex = 1;
            this.amarilloPB.TabStop = false;
            // 
            // rojoPB
            // 
            this.rojoPB.AccessibleName = "rojoPB";
            this.rojoPB.BackColor = System.Drawing.Color.Red;
            this.rojoPB.Location = new System.Drawing.Point(25, 176);
            this.rojoPB.Name = "rojoPB";
            this.rojoPB.Size = new System.Drawing.Size(106, 99);
            this.rojoPB.TabIndex = 2;
            this.rojoPB.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cambiar Fase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "mensajeL";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(134, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mi primera aplicación en Windows From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // permitirCB
            // 
            this.permitirCB.AccessibleName = "permitirCB";
            this.permitirCB.AutoSize = true;
            this.permitirCB.Location = new System.Drawing.Point(137, 325);
            this.permitirCB.Name = "permitirCB";
            this.permitirCB.Size = new System.Drawing.Size(242, 20);
            this.permitirCB.TabIndex = 5;
            this.permitirCB.Text = "Habilitado para poder cambiar fase";
            this.permitirCB.UseVisualStyleBackColor = true;
            this.permitirCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.permitirCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rojoPB);
            this.Controls.Add(this.amarilloPB);
            this.Controls.Add(this.verdePB);
            this.Name = "Form1";
            this.Text = "Semáforo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verdePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amarilloPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox verdePB;
        private System.Windows.Forms.PictureBox amarilloPB;
        private System.Windows.Forms.PictureBox rojoPB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox permitirCB;
    }
}

