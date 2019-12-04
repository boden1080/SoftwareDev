namespace MeetingScheduler
{
    partial class Form3
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
            this.labelPHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrefCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.ExcluCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SubmitParticipant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPHeading
            // 
            this.labelPHeading.AutoSize = true;
            this.labelPHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPHeading.Location = new System.Drawing.Point(12, 9);
            this.labelPHeading.Name = "labelPHeading";
            this.labelPHeading.Size = new System.Drawing.Size(174, 25);
            this.labelPHeading.TabIndex = 2;
            this.labelPHeading.Text = "Participant Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Preference Dates";
            // 
            // PrefCalendar1
            // 
            this.PrefCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.PrefCalendar1.Location = new System.Drawing.Point(17, 115);
            this.PrefCalendar1.Name = "PrefCalendar1";
            this.PrefCalendar1.TabIndex = 6;
            this.PrefCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.PrefCalendar1_DateSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add Exclusion Dates";
            // 
            // ExcluCalendar1
            // 
            this.ExcluCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.ExcluCalendar1.Location = new System.Drawing.Point(449, 115);
            this.ExcluCalendar1.Name = "ExcluCalendar1";
            this.ExcluCalendar1.TabIndex = 8;
            this.ExcluCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.ExcluCalendar1_DateSelected);
            // 
            // SubmitParticipant
            // 
            this.SubmitParticipant.Location = new System.Drawing.Point(526, 439);
            this.SubmitParticipant.Name = "SubmitParticipant";
            this.SubmitParticipant.Size = new System.Drawing.Size(150, 35);
            this.SubmitParticipant.TabIndex = 9;
            this.SubmitParticipant.Text = "Submit";
            this.SubmitParticipant.UseVisualStyleBackColor = true;
            this.SubmitParticipant.Click += new System.EventHandler(this.SubmitParticipant_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 486);
            this.Controls.Add(this.SubmitParticipant);
            this.Controls.Add(this.ExcluCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrefCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPHeading);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar PrefCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar ExcluCalendar1;
        private System.Windows.Forms.Button SubmitParticipant;
    }
}