namespace digiClock
{
    partial class digiClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(digiClock));
            this.lblclock = new System.Windows.Forms.Label();
            this.rdb24 = new System.Windows.Forms.RadioButton();
            this.rdb12 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblclock
            // 
            this.lblclock.Font = new System.Drawing.Font("Times New Roman", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclock.ForeColor = System.Drawing.Color.White;
            this.lblclock.Location = new System.Drawing.Point(-26, 76);
            this.lblclock.Name = "lblclock";
            this.lblclock.Size = new System.Drawing.Size(1244, 237);
            this.lblclock.TabIndex = 0;
            this.lblclock.Text = "00:00:00 AM";
            this.lblclock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdb24
            // 
            this.rdb24.AutoSize = true;
            this.rdb24.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb24.ForeColor = System.Drawing.Color.White;
            this.rdb24.Location = new System.Drawing.Point(447, 35);
            this.rdb24.Name = "rdb24";
            this.rdb24.Size = new System.Drawing.Size(135, 38);
            this.rdb24.TabIndex = 1;
            this.rdb24.TabStop = true;
            this.rdb24.Text = "24 Hrs";
            this.rdb24.UseVisualStyleBackColor = true;
            // 
            // rdb12
            // 
            this.rdb12.AutoSize = true;
            this.rdb12.BackColor = System.Drawing.Color.Black;
            this.rdb12.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold);
            this.rdb12.ForeColor = System.Drawing.Color.White;
            this.rdb12.Location = new System.Drawing.Point(599, 35);
            this.rdb12.Name = "rdb12";
            this.rdb12.Size = new System.Drawing.Size(135, 38);
            this.rdb12.TabIndex = 2;
            this.rdb12.TabStop = true;
            this.rdb12.Text = "12 Hrs";
            this.rdb12.UseVisualStyleBackColor = false;
            // 
            // digiClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1198, 351);
            this.Controls.Add(this.rdb12);
            this.Controls.Add(this.rdb24);
            this.Controls.Add(this.lblclock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "digiClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigiClock";
            this.Load += new System.EventHandler(this.digiClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblclock;
        private System.Windows.Forms.RadioButton rdb24;
        private System.Windows.Forms.RadioButton rdb12;
    }
}

