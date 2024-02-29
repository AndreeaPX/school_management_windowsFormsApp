
namespace ProiectPAW_Catalog_elevi
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDetaliiContact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewNote = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbvc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMedie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNote)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGridView
            // 
            this.StudentGridView.AllowUserToAddRows = false;
            this.StudentGridView.AllowUserToDeleteRows = false;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(13, 100);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.ReadOnly = true;
            this.StudentGridView.RowHeadersWidth = 51;
            this.StudentGridView.RowTemplate.Height = 24;
            this.StudentGridView.Size = new System.Drawing.Size(587, 61);
            this.StudentGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bine ati venit!";
            // 
            // buttonDetaliiContact
            // 
            this.buttonDetaliiContact.Image = ((System.Drawing.Image)(resources.GetObject("buttonDetaliiContact.Image")));
            this.buttonDetaliiContact.Location = new System.Drawing.Point(413, 12);
            this.buttonDetaliiContact.Name = "buttonDetaliiContact";
            this.buttonDetaliiContact.Size = new System.Drawing.Size(72, 51);
            this.buttonDetaliiContact.TabIndex = 3;
            this.buttonDetaliiContact.UseVisualStyleBackColor = true;
            this.buttonDetaliiContact.Click += new System.EventHandler(this.buttonDetaliiContact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 34);
            this.label2.TabIndex = 5;
            // 
            // dataGridViewNote
            // 
            this.dataGridViewNote.AllowUserToAddRows = false;
            this.dataGridViewNote.AllowUserToDeleteRows = false;
            this.dataGridViewNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNote.Location = new System.Drawing.Point(13, 192);
            this.dataGridViewNote.Name = "dataGridViewNote";
            this.dataGridViewNote.ReadOnly = true;
            this.dataGridViewNote.RowHeadersWidth = 51;
            this.dataGridViewNote.RowTemplate.Height = 24;
            this.dataGridViewNote.Size = new System.Drawing.Size(608, 195);
            this.dataGridViewNote.TabIndex = 6;
            this.dataGridViewNote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNote_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(490, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "labelName";
            // 
            // tbvc
            // 
            this.tbvc.Location = new System.Drawing.Point(12, 415);
            this.tbvc.Multiline = true;
            this.tbvc.Name = "tbvc";
            this.tbvc.Size = new System.Drawing.Size(167, 40);
            this.tbvc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(238, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Media acestei materii";
            // 
            // textBoxMedie
            // 
            this.textBoxMedie.Location = new System.Drawing.Point(494, 419);
            this.textBoxMedie.Multiline = true;
            this.textBoxMedie.Name = "textBoxMedie";
            this.textBoxMedie.Size = new System.Drawing.Size(100, 36);
            this.textBoxMedie.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(238, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numar total absente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelClass.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelClass.Location = new System.Drawing.Point(491, 43);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(106, 20);
            this.labelClass.TabIndex = 13;
            this.labelClass.Text = "ClassLabel";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 518);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMedie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbvc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDetaliiContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentGridView);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDetaliiContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMedie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelClass;
    }
}