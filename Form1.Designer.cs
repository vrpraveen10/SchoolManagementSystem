
namespace SchoolManagementDBMS
{
    partial class Form1
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
            this.lblProcessing = new System.Windows.Forms.Label();
            this.btnShowTeacher = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Location = new System.Drawing.Point(13, 280);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(46, 17);
            this.lblProcessing.TabIndex = 0;
            this.lblProcessing.Text = "label1";
            // 
            // btnShowTeacher
            // 
            this.btnShowTeacher.Location = new System.Drawing.Point(38, 34);
            this.btnShowTeacher.Name = "btnShowTeacher";
            this.btnShowTeacher.Size = new System.Drawing.Size(127, 38);
            this.btnShowTeacher.TabIndex = 1;
            this.btnShowTeacher.Text = "Show Teacher";
            this.btnShowTeacher.UseVisualStyleBackColor = true;
            this.btnShowTeacher.Click += new System.EventHandler(this.btnShowTeacher_Click);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(437, 34);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(127, 38);
            this.btnCreateStudent.TabIndex = 2;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.Location = new System.Drawing.Point(171, 34);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(127, 38);
            this.btnCreateTeacher.TabIndex = 3;
            this.btnCreateTeacher.Text = "Create Teacher";
            this.btnCreateTeacher.UseVisualStyleBackColor = true;
            this.btnCreateTeacher.Click += new System.EventHandler(this.btnCreateTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(304, 34);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(127, 38);
            this.btnDeleteTeacher.TabIndex = 4;
            this.btnDeleteTeacher.Text = "Delete Teacher";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(569, 34);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(127, 38);
            this.btnExam.TabIndex = 5;
            this.btnExam.Text = "Create Exam";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(332, 204);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(99, 26);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "Average";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Physics, Social Or English";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnCreateTeacher);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.btnShowTeacher);
            this.Controls.Add(this.lblProcessing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Button btnShowTeacher;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

