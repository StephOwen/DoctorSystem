namespace DoctorAppointmentSystem
{
    partial class frmHome
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
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAv = new System.Windows.Forms.Button();
            this.btnConsultation = new System.Windows.Forms.Button();
            this.btnArrival = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEditPat = new System.Windows.Forms.Button();
            this.btnAddPat = new System.Windows.Forms.Button();
            this.btnViewPat = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.btnAppEdit = new System.Windows.Forms.Button();
            this.btnDrCosts = new System.Windows.Forms.Button();
            this.btnPatel = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnJones = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatients
            // 
            this.btnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Location = new System.Drawing.Point(30, 15);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(112, 49);
            this.btnPatients.TabIndex = 0;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Visible = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnApp
            // 
            this.btnApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApp.Location = new System.Drawing.Point(30, 88);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(112, 49);
            this.btnApp.TabIndex = 1;
            this.btnApp.Text = "Appointments";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Visible = false;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(184, 19);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(112, 49);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Visible = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAv
            // 
            this.btnAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAv.Location = new System.Drawing.Point(184, 88);
            this.btnAv.Name = "btnAv";
            this.btnAv.Size = new System.Drawing.Size(112, 49);
            this.btnAv.TabIndex = 3;
            this.btnAv.Text = "Doctor Availability";
            this.btnAv.UseVisualStyleBackColor = true;
            this.btnAv.Visible = false;
            this.btnAv.Click += new System.EventHandler(this.btnAv_Click);
            // 
            // btnConsultation
            // 
            this.btnConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultation.Location = new System.Drawing.Point(184, 159);
            this.btnConsultation.Name = "btnConsultation";
            this.btnConsultation.Size = new System.Drawing.Size(112, 49);
            this.btnConsultation.TabIndex = 4;
            this.btnConsultation.Text = "Consultation";
            this.btnConsultation.UseVisualStyleBackColor = true;
            this.btnConsultation.Visible = false;
            this.btnConsultation.Click += new System.EventHandler(this.btnConsultation_Click);
            // 
            // btnArrival
            // 
            this.btnArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrival.Location = new System.Drawing.Point(30, 159);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Size = new System.Drawing.Size(112, 49);
            this.btnArrival.TabIndex = 5;
            this.btnArrival.Text = "Register Arrival";
            this.btnArrival.UseVisualStyleBackColor = true;
            this.btnArrival.Visible = false;
            this.btnArrival.Click += new System.EventHandler(this.btnArrival_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogOut);
            this.groupBox1.Controls.Add(this.btnLogIn);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.lblLogIn);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Location = new System.Drawing.Point(110, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 136);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please enter your username and password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(183, 94);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(71, 35);
            this.btnLogIn.TabIndex = 10;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(94, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 24);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(94, 27);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(160, 24);
            this.txtUser.TabIndex = 8;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(100, 30);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(0, 18);
            this.lblLogIn.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(13, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(13, 30);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(81, 18);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Username:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(27, 173);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(444, 15);
            this.lblError.TabIndex = 81;
            this.lblError.Text = "Incorrect username or password has been entered. Please try again.";
            this.lblError.Visible = false;
            // 
            // btnEditPat
            // 
            this.btnEditPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPat.Location = new System.Drawing.Point(30, 88);
            this.btnEditPat.Name = "btnEditPat";
            this.btnEditPat.Size = new System.Drawing.Size(112, 49);
            this.btnEditPat.TabIndex = 83;
            this.btnEditPat.Text = "Edit Patient";
            this.btnEditPat.UseVisualStyleBackColor = true;
            this.btnEditPat.Visible = false;
            this.btnEditPat.Click += new System.EventHandler(this.btnEditPat_Click);
            // 
            // btnAddPat
            // 
            this.btnAddPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPat.Location = new System.Drawing.Point(184, 19);
            this.btnAddPat.Name = "btnAddPat";
            this.btnAddPat.Size = new System.Drawing.Size(112, 49);
            this.btnAddPat.TabIndex = 82;
            this.btnAddPat.Text = "Add Patient";
            this.btnAddPat.UseVisualStyleBackColor = true;
            this.btnAddPat.Visible = false;
            this.btnAddPat.Click += new System.EventHandler(this.btnAddPat_Click);
            // 
            // btnViewPat
            // 
            this.btnViewPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPat.Location = new System.Drawing.Point(30, 15);
            this.btnViewPat.Name = "btnViewPat";
            this.btnViewPat.Size = new System.Drawing.Size(112, 49);
            this.btnViewPat.TabIndex = 84;
            this.btnViewPat.Text = "View Patient";
            this.btnViewPat.UseVisualStyleBackColor = true;
            this.btnViewPat.Visible = false;
            this.btnViewPat.Click += new System.EventHandler(this.btnViewPat_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 371);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 35);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(30, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 49);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "Cancel Appointment";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApp.Location = new System.Drawing.Point(184, 19);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(112, 49);
            this.btnAddApp.TabIndex = 86;
            this.btnAddApp.Text = "Create Appointment";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Visible = false;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnAppEdit
            // 
            this.btnAppEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppEdit.Location = new System.Drawing.Point(30, 88);
            this.btnAppEdit.Name = "btnAppEdit";
            this.btnAppEdit.Size = new System.Drawing.Size(112, 49);
            this.btnAppEdit.TabIndex = 87;
            this.btnAppEdit.Text = "Edit Appointment";
            this.btnAppEdit.UseVisualStyleBackColor = true;
            this.btnAppEdit.Visible = false;
            this.btnAppEdit.Click += new System.EventHandler(this.btnAppEdit_Click);
            // 
            // btnDrCosts
            // 
            this.btnDrCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrCosts.Location = new System.Drawing.Point(184, 89);
            this.btnDrCosts.Name = "btnDrCosts";
            this.btnDrCosts.Size = new System.Drawing.Size(123, 49);
            this.btnDrCosts.TabIndex = 90;
            this.btnDrCosts.Text = "Doctor Costs";
            this.btnDrCosts.UseVisualStyleBackColor = true;
            this.btnDrCosts.Visible = false;
            this.btnDrCosts.Click += new System.EventHandler(this.btnDrCosts_Click);
            // 
            // btnPatel
            // 
            this.btnPatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatel.Location = new System.Drawing.Point(19, 15);
            this.btnPatel.Name = "btnPatel";
            this.btnPatel.Size = new System.Drawing.Size(123, 51);
            this.btnPatel.TabIndex = 89;
            this.btnPatel.Text = "Appointments for Doctor Patel";
            this.btnPatel.UseVisualStyleBackColor = true;
            this.btnPatel.Visible = false;
            this.btnPatel.Click += new System.EventHandler(this.btnPatel_Click);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(19, 88);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(123, 51);
            this.btnAll.TabIndex = 88;
            this.btnAll.Text = "All Appointments";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Visible = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnJones
            // 
            this.btnJones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJones.Location = new System.Drawing.Point(174, 19);
            this.btnJones.Name = "btnJones";
            this.btnJones.Size = new System.Drawing.Size(133, 51);
            this.btnJones.TabIndex = 91;
            this.btnJones.Text = "Appointments for Doctor Jones";
            this.btnJones.UseVisualStyleBackColor = true;
            this.btnJones.Visible = false;
            this.btnJones.Click += new System.EventHandler(this.btnJones_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(183, 95);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(71, 35);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnDrCosts);
            this.gbButtons.Controls.Add(this.btnJones);
            this.gbButtons.Controls.Add(this.btnAppEdit);
            this.gbButtons.Controls.Add(this.btnAddApp);
            this.gbButtons.Controls.Add(this.btnPatel);
            this.gbButtons.Controls.Add(this.btnCancel);
            this.gbButtons.Controls.Add(this.btnAll);
            this.gbButtons.Controls.Add(this.btnViewPat);
            this.gbButtons.Controls.Add(this.btnAddPat);
            this.gbButtons.Controls.Add(this.btnEditPat);
            this.gbButtons.Controls.Add(this.btnArrival);
            this.gbButtons.Controls.Add(this.btnConsultation);
            this.gbButtons.Controls.Add(this.btnAv);
            this.gbButtons.Controls.Add(this.btnReports);
            this.gbButtons.Controls.Add(this.btnApp);
            this.gbButtons.Controls.Add(this.btnPatients);
            this.gbButtons.Location = new System.Drawing.Point(93, 198);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(329, 221);
            this.gbButtons.TabIndex = 92;
            this.gbButtons.TabStop = false;
            this.gbButtons.Visible = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 435);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAv;
        private System.Windows.Forms.Button btnConsultation;
        private System.Windows.Forms.Button btnArrival;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnEditPat;
        private System.Windows.Forms.Button btnAddPat;
        private System.Windows.Forms.Button btnViewPat;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnAppEdit;
        private System.Windows.Forms.Button btnDrCosts;
        private System.Windows.Forms.Button btnPatel;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnJones;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox gbButtons;
    }
}