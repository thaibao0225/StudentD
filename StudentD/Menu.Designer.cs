namespace StudentD
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btStudent = new System.Windows.Forms.Button();
            this.btLecturer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStudent
            // 
            this.btStudent.Location = new System.Drawing.Point(137, 130);
            this.btStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btStudent.Name = "btStudent";
            this.btStudent.Size = new System.Drawing.Size(139, 79);
            this.btStudent.TabIndex = 0;
            this.btStudent.Text = "Student";
            this.btStudent.UseVisualStyleBackColor = true;
            this.btStudent.Click += new System.EventHandler(this.btStudent_Click);
            // 
            // btLecturer
            // 
            this.btLecturer.Location = new System.Drawing.Point(362, 130);
            this.btLecturer.Margin = new System.Windows.Forms.Padding(6);
            this.btLecturer.Name = "btLecturer";
            this.btLecturer.Size = new System.Drawing.Size(139, 79);
            this.btLecturer.TabIndex = 0;
            this.btLecturer.Text = "Lecturer";
            this.btLecturer.UseVisualStyleBackColor = true;
            this.btLecturer.Click += new System.EventHandler(this.btLecturer_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 337);
            this.Controls.Add(this.btLecturer);
            this.Controls.Add(this.btStudent);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStudent;
        private System.Windows.Forms.Button btLecturer;
    }
}

