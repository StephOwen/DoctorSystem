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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatients
            // 
            this.btnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Location = new System.Drawing.Point(110, 225);
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
            this.btnApp.Location = new System.Drawing.Point(110, 298);
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
            this.btnReports.Location = new System.Drawing.Point(264, 225);
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
            this.btnAv.Location = new System.Drawing.Point(264, 298);
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
            this.btnConsultation.Location = new System.Drawing.Point(264, 369);
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
            this.btnArrival.Location = new System.Drawing.Point(110, 369);
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
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(27, 186);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(444, 15);
            this.lblError.TabIndex = 81;
            this.lblError.Text = "Incorrect username or password has been entered. Please try again.";
            this.lblError.Visible = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 435);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnArrival);
            this.Controls.Add(this.btnConsultation);
            this.Controls.Add(this.btnAv);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.btnPatients);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}