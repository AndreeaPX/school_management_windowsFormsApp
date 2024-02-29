
namespace ProiectPAW_Catalog_elevi
{
    partial class CatalogElevi
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
            this.tbvc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelProf = new System.Windows.Forms.Label();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbvc
            // 
            this.tbvc.AutoSize = true;
            this.tbvc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbvc.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvc.ForeColor = System.Drawing.Color.DarkCyan;
            this.tbvc.Location = new System.Drawing.Point(13, 28);
            this.tbvc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbvc.Name = "tbvc";
            this.tbvc.Size = new System.Drawing.Size(153, 20);
            this.tbvc.TabIndex = 20;
            this.tbvc.Text = "Clasa selectata";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 362);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProf.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProf.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelProf.Location = new System.Drawing.Point(688, 28);
            this.labelProf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(83, 20);
            this.labelProf.TabIndex = 22;
            this.labelProf.Text = "Profesor";
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDisciplina.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisciplina.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelDisciplina.Location = new System.Drawing.Point(340, 28);
            this.labelDisciplina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(107, 20);
            this.labelDisciplina.TabIndex = 23;
            this.labelDisciplina.Text = "Disciplina";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pentru adaugare nota";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CatalogElevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbvc);
            this.Name = "CatalogElevi";
            this.Text = "CatalogElevi";
            this.Load += new System.EventHandler(this.CatalogElevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbvc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelProf;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}