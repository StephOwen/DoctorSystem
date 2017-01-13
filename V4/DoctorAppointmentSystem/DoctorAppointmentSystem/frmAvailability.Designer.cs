namespace DoctorAppointmentSystem
{
    partial class frmAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvailability));
            this.label2 = new System.Windows.Forms.Label();
            this.lblSFname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.cboAv = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.imgTick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTick)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "To change your availability please fill in the fields below.";
            // 
            // lblSFname
            // 
            this.lblSFname.AutoSize = true;
            this.lblSFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFname.Location = new System.Drawing.Point(113, 83);
            this.lblSFname.Name = "lblSFname";
            this.lblSFname.Size = new System.Drawing.Size(43, 18);
            this.lblSFname.TabIndex = 83;
            this.lblSFname.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 85;
            this.label3.Text = "Availability:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(162, 79);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 24);
            this.dtpDate.TabIndex = 86;
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
            this.cboTime.Location = new System.Drawing.Point(161, 119);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(186, 26);
            this.cboTime.TabIndex = 87;
            // 
            // cboAv
            // 
            this.cboAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAv.FormattingEnabled = true;
            this.cboAv.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cboAv.Location = new System.Drawing.Point(162, 161);
            this.cboAv.Name = "cboAv";
            this.cboAv.Size = new System.Drawing.Size(74, 26);
            this.cboAv.TabIndex = 88;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(415, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 43);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(160, 232);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(133, 17);
            this.lblUpdate.TabIndex = 92;
            this.lblUpdate.Text = "Availability changed";
            this.lblUpdate.Visible = false;
            // 
            // imgTick
            // 
            this.imgTick.Image = ((System.Drawing.Image)(resources.GetObject("imgTick.Image")));
            this.imgTick.Location = new System.Drawing.Point(299, 212);
            this.imgTick.Name = "imgTick";
            this.imgTick.Size = new System.Drawing.Size(48, 48);
            this.imgTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTick.TabIndex = 91;
            this.imgTick.TabStop = false;
            this.imgTick.Visible = false;
            // 
            // frmAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 282);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.imgTick);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboAv);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSFname);
            this.Controls.Add(this.label2);
            this.Name = "frmAvailability";
            this.Text = "Availability";
            ((System.ComponentModel.ISupportInitialize)(this.imgTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.ComboBox cboAv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.PictureBox imgTick;
    }
}