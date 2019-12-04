namespace MeetingScheduler
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
            this.labelHeading = new System.Windows.Forms.Label();
            this.buttonMeeting = new System.Windows.Forms.Button();
            this.buttonPreferences = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(12, 9);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(192, 25);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Meeting Scheduler";
            // 
            // buttonMeeting
            // 
            this.buttonMeeting.Location = new System.Drawing.Point(84, 134);
            this.buttonMeeting.Name = "buttonMeeting";
            this.buttonMeeting.Size = new System.Drawing.Size(179, 161);
            this.buttonMeeting.TabIndex = 1;
            this.buttonMeeting.Text = "Meeting Setup";
            this.buttonMeeting.UseVisualStyleBackColor = true;
            this.buttonMeeting.Click += new System.EventHandler(this.buttonMeeting_Click);
            // 
            // buttonPreferences
            // 
            this.buttonPreferences.Location = new System.Drawing.Point(462, 134);
            this.buttonPreferences.Name = "buttonPreferences";
            this.buttonPreferences.Size = new System.Drawing.Size(179, 161);
            this.buttonPreferences.TabIndex = 2;
            this.buttonPreferences.Text = "Participant Access";
            this.buttonPreferences.UseVisualStyleBackColor = true;
            this.buttonPreferences.Click += new System.EventHandler(this.buttonPreferences_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 393);
            this.Controls.Add(this.buttonPreferences);
            this.Controls.Add(this.buttonMeeting);
            this.Controls.Add(this.labelHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button buttonMeeting;
        private System.Windows.Forms.Button buttonPreferences;
    }
}

