namespace DoctorAppointmentSystem
{
    partial class frmArrival
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArrival));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.imgCross = new System.Windows.Forms.PictureBox();
            this.lblNoApp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.imgTick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTick)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Patient Forename:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Patient Surname:";
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(150, 57);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(143, 24);
            this.txtFname.TabIndex = 47;
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(150, 89);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(143, 24);
            this.txtSname.TabIndex = 48;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(313, 107);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 40);
            this.btnCheck.TabIndex = 49;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(60, 155);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 18);
            this.lblInfo.TabIndex = 50;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(176, 212);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 40);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(12, 173);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(398, 18);
            this.lblRegister.TabIndex = 52;
            this.lblRegister.Text = "Appointment at 11:00. Please click submit to register arrival.";
            this.lblRegister.Visible = false;
            // 
            // imgCross
            // 
            this.imgCross.Image = ((System.Drawing.Image)(resources.GetObject("imgCross.Image")));
            this.imgCross.Location = new System.Drawing.Point(26, 155);
            this.imgCross.Name = "imgCross";
            this.imgCross.Size = new System.Drawing.Size(50, 50);
            this.imgCross.TabIndex = 53;
            this.imgCross.TabStop = false;
            this.imgCross.Visible = false;
            // 
            // lblNoApp
            // 
            this.lblNoApp.AutoSize = true;
            this.lblNoApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoApp.Location = new System.Drawing.Point(83, 173);
            this.lblNoApp.Name = "lblNoApp";
            this.lblNoApp.Size = new System.Drawing.Size(329, 18);
            this.lblNoApp.TabIndex = 54;
            this.lblNoApp.Text = "This patient does not have an appointment today.";
            this.lblNoApp.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Date of Birth:";
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(150, 122);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(143, 24);
            this.txtDOB.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Please enter the following details.";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(176, 173);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(117, 18);
            this.lblArrival.TabIndex = 58;
            this.lblArrival.Text = "Arrival registered";
            this.lblArrival.Visible = false;
            // 
            // imgTick
            // 
            this.imgTick.Image = ((System.Drawing.Image)(resources.GetObject("imgTick.Image")));
            this.imgTick.Location = new System.Drawing.Point(122, 155);
            this.imgTick.Name = "imgTick";
            this.imgTick.Size = new System.Drawing.Size(48, 48);
            this.imgTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTick.TabIndex = 92;
            this.imgTick.TabStop = false;
            this.imgTick.Visible = false;
            // 
            // frmArrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 279);
            this.Controls.Add(this.imgTick);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNoApp);
            this.Controls.Add(this.imgCross);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "frmArrival";
            this.Text = "frmArrival";
            ((System.ComponentModel.ISupportInitialize)(this.imgCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.PictureBox imgCross;
        private System.Windows.Forms.Label lblNoApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.PictureBox imgTick;
    }
}