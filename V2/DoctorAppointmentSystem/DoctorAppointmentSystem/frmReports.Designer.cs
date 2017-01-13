namespace DoctorAppointmentSystem
{
    partial class frmReports
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
            this.btnDrCosts = new System.Windows.Forms.Button();
            this.btnDrReport = new System.Windows.Forms.Button();
            this.btnAllReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrCosts
            // 
            this.btnDrCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrCosts.Location = new System.Drawing.Point(341, 73);
            this.btnDrCosts.Name = "btnDrCosts";
            this.btnDrCosts.Size = new System.Drawing.Size(119, 67);
            this.btnDrCosts.TabIndex = 11;
            this.btnDrCosts.Text = "Calculate Doctor Costs";
            this.btnDrCosts.UseVisualStyleBackColor = true;
            // 
            // btnDrReport
            // 
            this.btnDrReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrReport.Location = new System.Drawing.Point(177, 73);
            this.btnDrReport.Name = "btnDrReport";
            this.btnDrReport.Size = new System.Drawing.Size(135, 67);
            this.btnDrReport.TabIndex = 10;
            this.btnDrReport.Text = "Booked Appointments for Specific Doctor";
            this.btnDrReport.UseVisualStyleBackColor = true;
            // 
            // btnAllReport
            // 
            this.btnAllReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllReport.Location = new System.Drawing.Point(22, 73);
            this.btnAllReport.Name = "btnAllReport";
            this.btnAllReport.Size = new System.Drawing.Size(128, 67);
            this.btnAllReport.TabIndex = 9;
            this.btnAllReport.Text = "All Booked Appointments";
            this.btnAllReport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDrCosts);
            this.Controls.Add(this.btnDrReport);
            this.Controls.Add(this.btnAllReport);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrCosts;
        private System.Windows.Forms.Button btnDrReport;
        private System.Windows.Forms.Button btnAllReport;
        private System.Windows.Forms.Button button1;
    }
}