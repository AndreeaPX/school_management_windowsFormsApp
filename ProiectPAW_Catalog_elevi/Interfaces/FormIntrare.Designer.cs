
namespace ProiectPAW_Catalog_elevi
{
    partial class FormIntrare
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
            this.buttonElev = new System.Windows.Forms.Button();
            this.buttonProfesor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colegiul National \'Alexandru Ioan Cuza\'";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alegeti optiunea de conectare";
            // 
            // buttonElev
            // 
            this.buttonElev.Location = new System.Drawing.Point(234, 290);
            this.buttonElev.Name = "buttonElev";
            this.buttonElev.Size = new System.Drawing.Size(83, 38);
            this.buttonElev.TabIndex = 2;
            this.buttonElev.Text = "Elev";
            this.buttonElev.UseVisualStyleBackColor = true;
            this.buttonElev.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonProfesor
            // 
            this.buttonProfesor.Location = new System.Drawing.Point(479, 290);
            this.buttonProfesor.Name = "buttonProfesor";
            this.buttonProfesor.Size = new System.Drawing.Size(90, 38);
            this.buttonProfesor.TabIndex = 3;
            this.buttonProfesor.Text = "Profesor";
            this.buttonProfesor.UseVisualStyleBackColor = true;
            this.buttonProfesor.Click += new System.EventHandler(this.buttonProfesor_Click);
            // 
            // FormIntrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProfesor);
            this.Controls.Add(this.buttonElev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormIntrare";
            this.Text = "FormIntrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonElev;
        private System.Windows.Forms.Button buttonProfesor;
    }
}