namespace DoctorAppointmentSystem
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPFname = new System.Windows.Forms.Label();
            this.lblPSname = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.btnNewApp = new System.Windows.Forms.Button();
            this.cboDr = new System.Windows.Forms.ComboBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.imgTick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTick)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fill in the fields beow to create a new appointment.";
            // 
            // lblPFname
            // 
            this.lblPFname.AutoSize = true;
            this.lblPFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFname.Location = new System.Drawing.Point(96, 74);
            this.lblPFname.Name = "lblPFname";
            this.lblPFname.Size = new System.Drawing.Size(80, 18);
            this.lblPFname.TabIndex = 24;
            this.lblPFname.Text = "Forename:";
            // 
            // lblPSname
            // 
            this.lblPSname.AutoSize = true;
            this.lblPSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSname.Location = new System.Drawing.Point(104, 113);
            this.lblPSname.Name = "lblPSname";
            this.lblPSname.Size = new System.Drawing.Size(72, 18);
            this.lblPSname.TabIndex = 25;
            this.lblPSname.Text = "Surname:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.Location = new System.Drawing.Point(118, 152);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(58, 18);
            this.lblDoctor.TabIndex = 26;
            this.lblDoctor.Text = "Doctor:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(133, 191);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Time:";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(182, 71);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(186, 24);
            this.txtFname.TabIndex = 29;
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(182, 110);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(186, 24);
            this.txtSname.TabIndex = 30;
            // 
            // btnNewApp
            // 
            this.btnNewApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewApp.Location = new System.Drawing.Point(382, 286);
            this.btnNewApp.Name = "btnNewApp";
            this.btnNewApp.Size = new System.Drawing.Size(75, 41);
            this.btnNewApp.TabIndex = 34;
            this.btnNewApp.Text = "Create";
            this.btnNewApp.UseVisualStyleBackColor = true;
            this.btnNewApp.Click += new System.EventHandler(this.btnNewApp_Click);
            // 
            // cboDr
            // 
            this.cboDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDr.FormattingEnabled = true;
            this.cboDr.Items.AddRange(new object[] {
            "Dr Jones",
            "Dr Patel"});
            this.cboDr.Location = new System.Drawing.Point(182, 149);
            this.cboDr.Name = "cboDr";
            this.cboDr.Size = new System.Drawing.Size(186, 26);
            this.cboDr.TabIndex = 35;
            // 
            // cboTime
            // 
            this.cboTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30"});
            this.cboTime.Location = new System.Drawing.Point(182, 227);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(186, 26);
            this.cboTime.TabIndex = 37;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(183, 187);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 24);
            this.dtpDate.TabIndex = 38;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(167, 299);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(139, 17);
            this.lblUpdate.TabIndex = 90;
            this.lblUpdate.Text = "Appointment created";
            this.lblUpdate.Visible = false;
            // 
            // imgTick
            // 
            this.imgTick.Image = ((System.Drawing.Image)(resources.GetObject("imgTick.Image")));
            this.imgTick.Location = new System.Drawing.Point(312, 283);
            this.imgTick.Name = "imgTick";
            this.imgTick.Size = new System.Drawing.Size(48, 48);
            this.imgTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTick.TabIndex = 89;
            this.imgTick.TabStop = false;
            this.imgTick.Visible = false;
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 371);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.imgTick);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.cboDr);
            this.Controls.Add(this.btnNewApp);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblPSname);
            this.Controls.Add(this.lblPFname);
            this.Controls.Add(this.label1);
            this.Name = "frmAppointment";
            this.Text = "New Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.imgTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPFname;
        private System.Windows.Forms.Label lblPSname;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Button btnNewApp;
        private System.Windows.Forms.ComboBox cboDr;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.PictureBox imgTick;
    }
}