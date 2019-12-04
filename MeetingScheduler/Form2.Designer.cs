namespace MeetingScheduler
{
    partial class Form2
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
            this.labelHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.room4Button = new System.Windows.Forms.Button();
            this.room3Button = new System.Windows.Forms.Button();
            this.room2Button = new System.Windows.Forms.Button();
            this.room1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTime5 = new System.Windows.Forms.Button();
            this.buttonTime4 = new System.Windows.Forms.Button();
            this.buttonTime3 = new System.Windows.Forms.Button();
            this.buttonTime2 = new System.Windows.Forms.Button();
            this.buttonTime1 = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(12, 9);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(151, 25);
            this.labelHeading.TabIndex = 1;
            this.labelHeading.Text = "Meeting Setup";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.room4Button);
            this.groupBox1.Controls.Add(this.room3Button);
            this.groupBox1.Controls.Add(this.room2Button);
            this.groupBox1.Controls.Add(this.room1Button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 325);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MeetingSettings";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(10, 134);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2019, 11, 19, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Date";
            // 
            // room4Button
            // 
            this.room4Button.Location = new System.Drawing.Point(228, 51);
            this.room4Button.Name = "room4Button";
            this.room4Button.Size = new System.Drawing.Size(64, 55);
            this.room4Button.TabIndex = 4;
            this.room4Button.Text = "Room4";
            this.room4Button.UseVisualStyleBackColor = true;
            this.room4Button.Click += new System.EventHandler(this.room4Button_Click);
            // 
            // room3Button
            // 
            this.room3Button.Location = new System.Drawing.Point(152, 51);
            this.room3Button.Name = "room3Button";
            this.room3Button.Size = new System.Drawing.Size(64, 55);
            this.room3Button.TabIndex = 3;
            this.room3Button.Text = "Room3";
            this.room3Button.UseVisualStyleBackColor = true;
            this.room3Button.Click += new System.EventHandler(this.room3Button_Click);
            // 
            // room2Button
            // 
            this.room2Button.Location = new System.Drawing.Point(80, 51);
            this.room2Button.Name = "room2Button";
            this.room2Button.Size = new System.Drawing.Size(64, 55);
            this.room2Button.TabIndex = 2;
            this.room2Button.Text = "Room2";
            this.room2Button.UseVisualStyleBackColor = true;
            this.room2Button.Click += new System.EventHandler(this.room2Button_Click);
            // 
            // room1Button
            // 
            this.room1Button.Location = new System.Drawing.Point(10, 51);
            this.room1Button.Name = "room1Button";
            this.room1Button.Size = new System.Drawing.Size(64, 55);
            this.room1Button.TabIndex = 1;
            this.room1Button.Text = "Room1";
            this.room1Button.UseVisualStyleBackColor = true;
            this.room1Button.Click += new System.EventHandler(this.room1Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Room";
            // 
            // buttonTime5
            // 
            this.buttonTime5.Location = new System.Drawing.Point(342, 156);
            this.buttonTime5.Name = "buttonTime5";
            this.buttonTime5.Size = new System.Drawing.Size(64, 55);
            this.buttonTime5.TabIndex = 14;
            this.buttonTime5.Text = "2-3";
            this.buttonTime5.UseVisualStyleBackColor = true;
            this.buttonTime5.Click += new System.EventHandler(this.buttonTime5_Click);
            // 
            // buttonTime4
            // 
            this.buttonTime4.Location = new System.Drawing.Point(552, 96);
            this.buttonTime4.Name = "buttonTime4";
            this.buttonTime4.Size = new System.Drawing.Size(64, 55);
            this.buttonTime4.TabIndex = 13;
            this.buttonTime4.Text = "1-2";
            this.buttonTime4.UseVisualStyleBackColor = true;
            this.buttonTime4.Click += new System.EventHandler(this.buttonTime4_Click);
            // 
            // buttonTime3
            // 
            this.buttonTime3.Location = new System.Drawing.Point(482, 96);
            this.buttonTime3.Name = "buttonTime3";
            this.buttonTime3.Size = new System.Drawing.Size(64, 55);
            this.buttonTime3.TabIndex = 12;
            this.buttonTime3.Text = "12-1";
            this.buttonTime3.UseVisualStyleBackColor = true;
            this.buttonTime3.Click += new System.EventHandler(this.buttonTime3_Click);
            // 
            // buttonTime2
            // 
            this.buttonTime2.Location = new System.Drawing.Point(412, 96);
            this.buttonTime2.Name = "buttonTime2";
            this.buttonTime2.Size = new System.Drawing.Size(64, 55);
            this.buttonTime2.TabIndex = 11;
            this.buttonTime2.Text = "11-12";
            this.buttonTime2.UseVisualStyleBackColor = true;
            this.buttonTime2.Click += new System.EventHandler(this.buttonTime2_Click);
            // 
            // buttonTime1
            // 
            this.buttonTime1.Location = new System.Drawing.Point(342, 96);
            this.buttonTime1.Name = "buttonTime1";
            this.buttonTime1.Size = new System.Drawing.Size(64, 55);
            this.buttonTime1.TabIndex = 10;
            this.buttonTime1.Text = "10-11";
            this.buttonTime1.UseVisualStyleBackColor = true;
            this.buttonTime1.Click += new System.EventHandler(this.buttonTime1_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSubmit.Location = new System.Drawing.Point(548, 323);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(139, 51);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Equipment";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(346, 235);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 386);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonTime5);
            this.Controls.Add(this.buttonTime4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTime3);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.buttonTime2);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonTime1);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button room4Button;
        private System.Windows.Forms.Button room3Button;
        private System.Windows.Forms.Button room2Button;
        private System.Windows.Forms.Button room1Button;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonTime5;
        private System.Windows.Forms.Button buttonTime4;
        private System.Windows.Forms.Button buttonTime3;
        private System.Windows.Forms.Button buttonTime2;
        private System.Windows.Forms.Button buttonTime1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}