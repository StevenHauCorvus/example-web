namespace Final_MK.I
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.topBar = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbTicket = new System.Windows.Forms.GroupBox();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.cboRemoveID = new System.Windows.Forms.ComboBox();
            this.btnRemoveTicketID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbRemove = new System.Windows.Forms.GroupBox();
            this.btnGBRemove = new System.Windows.Forms.Button();
            this.txtAdministratorPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbAdminVerification = new System.Windows.Forms.GroupBox();
            this.btnAdminVerification = new System.Windows.Forms.Button();
            this.lblAdminError = new System.Windows.Forms.Label();
            this.btnAdminSearch = new System.Windows.Forms.Button();
            this.loginScreen = new System.Windows.Forms.GroupBox();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.lblErrorUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.topBar.SuspendLayout();
            this.gbTicket.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbRemove.SuspendLayout();
            this.gbAdminVerification.SuspendLayout();
            this.loginScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(15, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(138, 16);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome Steven Hau";
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Transparent;
            this.topBar.Controls.Add(this.button2);
            this.topBar.Controls.Add(this.btnLogout);
            this.topBar.Controls.Add(this.button1);
            this.topBar.Controls.Add(this.label8);
            this.topBar.Controls.Add(this.btnCreateTicket);
            this.topBar.Controls.Add(this.button3);
            this.topBar.ForeColor = System.Drawing.Color.Black;
            this.topBar.Location = new System.Drawing.Point(2, 44);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(186, 325);
            this.topBar.TabIndex = 10;
            this.topBar.TabStop = false;
            this.topBar.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(18, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "Live Demo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.Location = new System.Drawing.Point(10, 253);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 38);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(18, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Close Ticket";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(126, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTicket.ForeColor = System.Drawing.Color.Black;
            this.btnCreateTicket.Location = new System.Drawing.Point(18, 29);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(152, 36);
            this.btnCreateTicket.TabIndex = 0;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateTicket.UseVisualStyleBackColor = false;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(18, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 36);
            this.button3.TabIndex = 23;
            this.button3.Text = "Check Status";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbTicket
            // 
            this.gbTicket.BackColor = System.Drawing.Color.Transparent;
            this.gbTicket.Controls.Add(this.btnPrintTicket);
            this.gbTicket.Controls.Add(this.txtEmail);
            this.gbTicket.Controls.Add(this.label6);
            this.gbTicket.Controls.Add(this.cboCourse);
            this.gbTicket.Controls.Add(this.label5);
            this.gbTicket.Controls.Add(this.txtLastName);
            this.gbTicket.Controls.Add(this.label4);
            this.gbTicket.Controls.Add(this.txtFirstName);
            this.gbTicket.Controls.Add(this.label3);
            this.gbTicket.Controls.Add(this.txtStudentID);
            this.gbTicket.Controls.Add(this.lblWelcome);
            this.gbTicket.Location = new System.Drawing.Point(423, 131);
            this.gbTicket.Name = "gbTicket";
            this.gbTicket.Size = new System.Drawing.Size(529, 351);
            this.gbTicket.TabIndex = 11;
            this.gbTicket.TabStop = false;
            this.gbTicket.Visible = false;
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrintTicket.ForeColor = System.Drawing.Color.White;
            this.btnPrintTicket.Location = new System.Drawing.Point(179, 296);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(133, 30);
            this.btnPrintTicket.TabIndex = 19;
            this.btnPrintTicket.Text = "Create Ticket";
            this.btnPrintTicket.UseVisualStyleBackColor = false;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(34, 135);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(405, 155);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "Details...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(206, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Departments:";
            // 
            // cboCourse
            // 
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(299, 106);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(140, 24);
            this.cboCourse.TabIndex = 16;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subject";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLastName.Location = new System.Drawing.Point(84, 106);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(107, 22);
            this.txtLastName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(253, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFirstName.Location = new System.Drawing.Point(306, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(133, 22);
            this.txtFirstName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Employee ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtStudentID.Location = new System.Drawing.Point(105, 67);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(133, 22);
            this.txtStudentID.TabIndex = 10;
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.White;
            this.rtbOutput.Location = new System.Drawing.Point(6, 149);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(572, 248);
            this.rtbOutput.TabIndex = 12;
            this.rtbOutput.Text = "";
            // 
            // cboRemoveID
            // 
            this.cboRemoveID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRemoveID.FormattingEnabled = true;
            this.cboRemoveID.Location = new System.Drawing.Point(71, 86);
            this.cboRemoveID.Name = "cboRemoveID";
            this.cboRemoveID.Size = new System.Drawing.Size(140, 24);
            this.cboRemoveID.TabIndex = 20;
            // 
            // btnRemoveTicketID
            // 
            this.btnRemoveTicketID.Location = new System.Drawing.Point(87, 49);
            this.btnRemoveTicketID.Name = "btnRemoveTicketID";
            this.btnRemoveTicketID.Size = new System.Drawing.Size(111, 31);
            this.btnRemoveTicketID.TabIndex = 21;
            this.btnRemoveTicketID.Text = "Close Ticket";
            this.btnRemoveTicketID.UseVisualStyleBackColor = true;
            this.btnRemoveTicketID.Click += new System.EventHandler(this.btnRemoveTicketID_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Remove ID";
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.Transparent;
            this.gbStatus.Controls.Add(this.gbRemove);
            this.gbStatus.Controls.Add(this.rtbOutput);
            this.gbStatus.Location = new System.Drawing.Point(399, 148);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(584, 403);
            this.gbStatus.TabIndex = 23;
            this.gbStatus.TabStop = false;
            this.gbStatus.Visible = false;
            // 
            // gbRemove
            // 
            this.gbRemove.BackColor = System.Drawing.Color.Transparent;
            this.gbRemove.Controls.Add(this.btnGBRemove);
            this.gbRemove.Controls.Add(this.btnRemoveTicketID);
            this.gbRemove.Controls.Add(this.cboRemoveID);
            this.gbRemove.Controls.Add(this.label7);
            this.gbRemove.Location = new System.Drawing.Point(147, 19);
            this.gbRemove.Name = "gbRemove";
            this.gbRemove.Size = new System.Drawing.Size(279, 119);
            this.gbRemove.TabIndex = 25;
            this.gbRemove.TabStop = false;
            this.gbRemove.Visible = false;
            // 
            // btnGBRemove
            // 
            this.btnGBRemove.BackColor = System.Drawing.Color.Red;
            this.btnGBRemove.Location = new System.Drawing.Point(235, 21);
            this.btnGBRemove.Name = "btnGBRemove";
            this.btnGBRemove.Size = new System.Drawing.Size(38, 23);
            this.btnGBRemove.TabIndex = 29;
            this.btnGBRemove.Text = "X";
            this.btnGBRemove.UseVisualStyleBackColor = false;
            this.btnGBRemove.Click += new System.EventHandler(this.btnGBRemove_Click);
            // 
            // txtAdministratorPassword
            // 
            this.txtAdministratorPassword.Location = new System.Drawing.Point(53, 50);
            this.txtAdministratorPassword.Name = "txtAdministratorPassword";
            this.txtAdministratorPassword.Size = new System.Drawing.Size(100, 22);
            this.txtAdministratorPassword.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(39, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Password Required";
            // 
            // gbAdminVerification
            // 
            this.gbAdminVerification.BackColor = System.Drawing.Color.Transparent;
            this.gbAdminVerification.Controls.Add(this.btnAdminVerification);
            this.gbAdminVerification.Controls.Add(this.lblAdminError);
            this.gbAdminVerification.Controls.Add(this.btnAdminSearch);
            this.gbAdminVerification.Controls.Add(this.label9);
            this.gbAdminVerification.Controls.Add(this.txtAdministratorPassword);
            this.gbAdminVerification.Location = new System.Drawing.Point(1049, 2);
            this.gbAdminVerification.Name = "gbAdminVerification";
            this.gbAdminVerification.Size = new System.Drawing.Size(259, 113);
            this.gbAdminVerification.TabIndex = 27;
            this.gbAdminVerification.TabStop = false;
            this.gbAdminVerification.Visible = false;
            // 
            // btnAdminVerification
            // 
            this.btnAdminVerification.BackColor = System.Drawing.Color.Red;
            this.btnAdminVerification.Location = new System.Drawing.Point(202, 10);
            this.btnAdminVerification.Name = "btnAdminVerification";
            this.btnAdminVerification.Size = new System.Drawing.Size(38, 23);
            this.btnAdminVerification.TabIndex = 28;
            this.btnAdminVerification.Text = "X";
            this.btnAdminVerification.UseVisualStyleBackColor = false;
            this.btnAdminVerification.Click += new System.EventHandler(this.btnAdminVerification_Click);
            // 
            // lblAdminError
            // 
            this.lblAdminError.AutoSize = true;
            this.lblAdminError.ForeColor = System.Drawing.Color.Red;
            this.lblAdminError.Location = new System.Drawing.Point(162, 53);
            this.lblAdminError.Name = "lblAdminError";
            this.lblAdminError.Size = new System.Drawing.Size(36, 16);
            this.lblAdminError.TabIndex = 23;
            this.lblAdminError.Text = "Error";
            this.lblAdminError.Visible = false;
            // 
            // btnAdminSearch
            // 
            this.btnAdminSearch.Location = new System.Drawing.Point(58, 78);
            this.btnAdminSearch.Name = "btnAdminSearch";
            this.btnAdminSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSearch.TabIndex = 27;
            this.btnAdminSearch.Text = "Enter";
            this.btnAdminSearch.UseVisualStyleBackColor = true;
            this.btnAdminSearch.Click += new System.EventHandler(this.btnAdminSearch_Click);
            this.btnAdminSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdministratorPassword_KeyDown);
            // 
            // loginScreen
            // 
            this.loginScreen.BackColor = System.Drawing.Color.White;
            this.loginScreen.Controls.Add(this.lblErrorPass);
            this.loginScreen.Controls.Add(this.lblErrorUser);
            this.loginScreen.Controls.Add(this.label1);
            this.loginScreen.Controls.Add(this.txtPassword);
            this.loginScreen.Controls.Add(this.pictureBox2);
            this.loginScreen.Controls.Add(this.pictureBox1);
            this.loginScreen.Controls.Add(this.Username);
            this.loginScreen.Controls.Add(this.btnLogin);
            this.loginScreen.Controls.Add(this.txtUserName);
            this.loginScreen.Location = new System.Drawing.Point(-9, 2);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(1481, 805);
            this.loginScreen.TabIndex = 8;
            this.loginScreen.TabStop = false;
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPass.Location = new System.Drawing.Point(997, 345);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(0, 16);
            this.lblErrorPass.TabIndex = 31;
            // 
            // lblErrorUser
            // 
            this.lblErrorUser.AutoSize = true;
            this.lblErrorUser.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUser.Location = new System.Drawing.Point(997, 267);
            this.lblErrorUser.Name = "lblErrorUser";
            this.lblErrorUser.Size = new System.Drawing.Size(0, 16);
            this.lblErrorUser.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(892, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(897, 369);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(328, 24);
            this.txtPassword.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Final_MK.I.Properties.Resources.Resize_typing;
            this.pictureBox2.Location = new System.Drawing.Point(0, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(811, 607);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Final_MK.I.Properties.Resources.blue_block;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1000, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 81);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Gray;
            this.Username.Location = new System.Drawing.Point(892, 260);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(106, 28);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(892, 403);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(333, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(897, 291);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(328, 24);
            this.txtUserName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Final_MK.I.Properties.Resources.baby_blue_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 605);
            this.Controls.Add(this.loginScreen);
            this.Controls.Add(this.gbAdminVerification);
            this.Controls.Add(this.gbTicket);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.gbStatus);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topBar.ResumeLayout(false);
            this.gbTicket.ResumeLayout(false);
            this.gbTicket.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbRemove.ResumeLayout(false);
            this.gbRemove.PerformLayout();
            this.gbAdminVerification.ResumeLayout(false);
            this.gbAdminVerification.PerformLayout();
            this.loginScreen.ResumeLayout(false);
            this.loginScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox topBar;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.GroupBox gbTicket;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.ComboBox cboRemoveID;
        private System.Windows.Forms.Button btnRemoveTicketID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdministratorPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbAdminVerification;
        private System.Windows.Forms.Button btnAdminSearch;
        private System.Windows.Forms.Label lblAdminError;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox loginScreen;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAdminVerification;
        private System.Windows.Forms.Button btnGBRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorUser;
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.Button button2;
    }
}

