namespace WinFormClient
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
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.tbAssTitle = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbExercise = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deadlinePick = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateAss = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(393, 125);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(200, 22);
            this.datePick.TabIndex = 0;
            // 
            // tbAssTitle
            // 
            this.tbAssTitle.Location = new System.Drawing.Point(201, 34);
            this.tbAssTitle.Name = "tbAssTitle";
            this.tbAssTitle.Size = new System.Drawing.Size(233, 22);
            this.tbAssTitle.TabIndex = 1;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(493, 77);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(100, 22);
            this.tbSubject.TabIndex = 2;
            // 
            // tbExercise
            // 
            this.tbExercise.Location = new System.Drawing.Point(42, 205);
            this.tbExercise.Multiline = true;
            this.tbExercise.Name = "tbExercise";
            this.tbExercise.Size = new System.Drawing.Size(551, 140);
            this.tbExercise.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assignment Title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exercise : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date : ";
            // 
            // deadlinePick
            // 
            this.deadlinePick.Location = new System.Drawing.Point(393, 162);
            this.deadlinePick.Name = "deadlinePick";
            this.deadlinePick.Size = new System.Drawing.Size(200, 22);
            this.deadlinePick.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Deadline : ";
            // 
            // btnCreateAss
            // 
            this.btnCreateAss.Location = new System.Drawing.Point(236, 387);
            this.btnCreateAss.Name = "btnCreateAss";
            this.btnCreateAss.Size = new System.Drawing.Size(168, 23);
            this.btnCreateAss.TabIndex = 10;
            this.btnCreateAss.Text = "Create Assignment";
            this.btnCreateAss.UseVisualStyleBackColor = true;
            this.btnCreateAss.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 446);
            this.Controls.Add(this.btnCreateAss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deadlinePick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbExercise);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbAssTitle);
            this.Controls.Add(this.datePick);
            this.Name = "Form1";
            this.Text = "Create Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.TextBox tbAssTitle;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbExercise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker deadlinePick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateAss;
    }
}

