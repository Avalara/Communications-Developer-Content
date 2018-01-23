namespace EZGeoCSharpSample
{
    partial class AFCGeoDemoClient
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
            this.pbxAvalaraLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerifyAddress = new System.Windows.Forms.Button();
            this.chkSpecialTaxDistrict = new System.Windows.Forms.CheckBox();
            this.chkCassCertify = new System.Windows.Forms.CheckBox();
            this.txtCityStateZip = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtServerTime = new System.Windows.Forms.TextBox();
            this.btnGetServerTime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGeocodedCounty = new System.Windows.Forms.TextBox();
            this.txtGeocodedPostalCode = new System.Windows.Forms.TextBox();
            this.txtGeocodedStreet = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGeocodedState = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGeocodedCity = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCassPostalCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCassState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCassCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCassStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJurisdictionCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtJurisdictionName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFIPSCode = new System.Windows.Forms.TextBox();
            this.txtFeatureID = new System.Windows.Forms.TextBox();
            this.chkUnincorporated = new System.Windows.Forms.CheckBox();
            this.chkGeocodedSTD = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvalaraLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxAvalaraLogo
            // 
            this.pbxAvalaraLogo.Image = global::EZGeoCSharpSample.Properties.Resources.AvalaraLogo;
            this.pbxAvalaraLogo.Location = new System.Drawing.Point(15, 20);
            this.pbxAvalaraLogo.Name = "pbxAvalaraLogo";
            this.pbxAvalaraLogo.Size = new System.Drawing.Size(317, 87);
            this.pbxAvalaraLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvalaraLogo.TabIndex = 0;
            this.pbxAvalaraLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Login (required)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(89, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(144, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Click += new System.EventHandler(this.SelectAllText);
            this.txtPassword.TextChanged += new System.EventHandler(this.CredentialsTextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(89, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 20);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Click += new System.EventHandler(this.SelectAllText);
            this.txtUserName.TextChanged += new System.EventHandler(this.CredentialsTextChanged);
            this.txtUserName.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerifyAddress);
            this.groupBox2.Controls.Add(this.chkSpecialTaxDistrict);
            this.groupBox2.Controls.Add(this.chkCassCertify);
            this.groupBox2.Controls.Add(this.txtCityStateZip);
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Location = new System.Drawing.Point(11, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Address";
            // 
            // btnVerifyAddress
            // 
            this.btnVerifyAddress.Enabled = false;
            this.btnVerifyAddress.Location = new System.Drawing.Point(190, 95);
            this.btnVerifyAddress.Name = "btnVerifyAddress";
            this.btnVerifyAddress.Size = new System.Drawing.Size(117, 23);
            this.btnVerifyAddress.TabIndex = 4;
            this.btnVerifyAddress.Text = "Verify Address";
            this.btnVerifyAddress.UseVisualStyleBackColor = true;
            this.btnVerifyAddress.Click += new System.EventHandler(this.btnVerifyAddress_Click);
            // 
            // chkSpecialTaxDistrict
            // 
            this.chkSpecialTaxDistrict.AutoSize = true;
            this.chkSpecialTaxDistrict.Location = new System.Drawing.Point(190, 72);
            this.chkSpecialTaxDistrict.Name = "chkSpecialTaxDistrict";
            this.chkSpecialTaxDistrict.Size = new System.Drawing.Size(117, 17);
            this.chkSpecialTaxDistrict.TabIndex = 5;
            this.chkSpecialTaxDistrict.Text = "Special Tax District";
            this.chkSpecialTaxDistrict.UseVisualStyleBackColor = true;
            // 
            // chkCassCertify
            // 
            this.chkCassCertify.AutoSize = true;
            this.chkCassCertify.Location = new System.Drawing.Point(7, 72);
            this.chkCassCertify.Name = "chkCassCertify";
            this.chkCassCertify.Size = new System.Drawing.Size(81, 17);
            this.chkCassCertify.TabIndex = 4;
            this.chkCassCertify.Text = "Cass Certify";
            this.chkCassCertify.UseVisualStyleBackColor = true;
            // 
            // txtCityStateZip
            // 
            this.txtCityStateZip.Location = new System.Drawing.Point(7, 46);
            this.txtCityStateZip.Name = "txtCityStateZip";
            this.txtCityStateZip.Size = new System.Drawing.Size(300, 20);
            this.txtCityStateZip.TabIndex = 1;
            this.txtCityStateZip.Text = "Overland Park, KS 66212";
            this.txtCityStateZip.Click += new System.EventHandler(this.SelectAllText);
            this.txtCityStateZip.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(7, 20);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(300, 20);
            this.txtStreet.TabIndex = 0;
            this.txtStreet.Text = "8675 W 96th St, Ste 220";
            this.txtStreet.Click += new System.EventHandler(this.SelectAllText);
            this.txtStreet.Enter += new System.EventHandler(this.SelectAllText);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtServerTime);
            this.groupBox3.Controls.Add(this.btnGetServerTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Time";
            // 
            // txtServerTime
            // 
            this.txtServerTime.Location = new System.Drawing.Point(131, 80);
            this.txtServerTime.Name = "txtServerTime";
            this.txtServerTime.ReadOnly = true;
            this.txtServerTime.Size = new System.Drawing.Size(176, 20);
            this.txtServerTime.TabIndex = 7;
            // 
            // btnGetServerTime
            // 
            this.btnGetServerTime.Enabled = false;
            this.btnGetServerTime.Location = new System.Drawing.Point(7, 80);
            this.btnGetServerTime.Name = "btnGetServerTime";
            this.btnGetServerTime.Size = new System.Drawing.Size(117, 23);
            this.btnGetServerTime.TabIndex = 6;
            this.btnGetServerTime.Text = "getServerTime";
            this.btnGetServerTime.UseVisualStyleBackColor = true;
            this.btnGetServerTime.Click += new System.EventHandler(this.btnGetServerTime_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Use getServerTime to check service connectivity.\n\nIf your user name or password i" +
    "s incorrect, service requests will fail.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtGeocodedCounty);
            this.groupBox4.Controls.Add(this.txtGeocodedPostalCode);
            this.groupBox4.Controls.Add(this.txtGeocodedStreet);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtGeocodedState);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtScore);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtGeocodedCity);
            this.groupBox4.Location = new System.Drawing.Point(351, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 166);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Geocoded Address";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(9, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "County";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGeocodedCounty
            // 
            this.txtGeocodedCounty.Location = new System.Drawing.Point(65, 107);
            this.txtGeocodedCounty.Name = "txtGeocodedCounty";
            this.txtGeocodedCounty.ReadOnly = true;
            this.txtGeocodedCounty.Size = new System.Drawing.Size(239, 20);
            this.txtGeocodedCounty.TabIndex = 17;
            // 
            // txtGeocodedPostalCode
            // 
            this.txtGeocodedPostalCode.Location = new System.Drawing.Point(194, 136);
            this.txtGeocodedPostalCode.Name = "txtGeocodedPostalCode";
            this.txtGeocodedPostalCode.ReadOnly = true;
            this.txtGeocodedPostalCode.Size = new System.Drawing.Size(110, 20);
            this.txtGeocodedPostalCode.TabIndex = 15;
            // 
            // txtGeocodedStreet
            // 
            this.txtGeocodedStreet.Location = new System.Drawing.Point(65, 55);
            this.txtGeocodedStreet.Name = "txtGeocodedStreet";
            this.txtGeocodedStreet.ReadOnly = true;
            this.txtGeocodedStreet.Size = new System.Drawing.Size(239, 20);
            this.txtGeocodedStreet.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(9, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Score";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(124, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Postal Code";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(14, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 26);
            this.label12.TabIndex = 8;
            this.label12.Text = "Street";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGeocodedState
            // 
            this.txtGeocodedState.Location = new System.Drawing.Point(65, 136);
            this.txtGeocodedState.Name = "txtGeocodedState";
            this.txtGeocodedState.ReadOnly = true;
            this.txtGeocodedState.Size = new System.Drawing.Size(28, 20);
            this.txtGeocodedState.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(24, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "City";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(65, 29);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(122, 20);
            this.txtScore.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(24, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "State";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGeocodedCity
            // 
            this.txtGeocodedCity.Location = new System.Drawing.Point(65, 81);
            this.txtGeocodedCity.Name = "txtGeocodedCity";
            this.txtGeocodedCity.ReadOnly = true;
            this.txtGeocodedCity.Size = new System.Drawing.Size(239, 20);
            this.txtGeocodedCity.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCassPostalCode);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtCassState);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtCassCity);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtCassStreet);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(351, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 120);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cass Address";
            // 
            // txtCassPostalCode
            // 
            this.txtCassPostalCode.Location = new System.Drawing.Point(207, 87);
            this.txtCassPostalCode.Name = "txtCassPostalCode";
            this.txtCassPostalCode.ReadOnly = true;
            this.txtCassPostalCode.Size = new System.Drawing.Size(97, 20);
            this.txtCassPostalCode.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(137, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Postal Code";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCassState
            // 
            this.txtCassState.Location = new System.Drawing.Point(79, 84);
            this.txtCassState.Name = "txtCassState";
            this.txtCassState.ReadOnly = true;
            this.txtCassState.Size = new System.Drawing.Size(28, 20);
            this.txtCassState.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(38, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "State";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCassCity
            // 
            this.txtCassCity.Location = new System.Drawing.Point(79, 58);
            this.txtCassCity.Name = "txtCassCity";
            this.txtCassCity.ReadOnly = true;
            this.txtCassCity.Size = new System.Drawing.Size(226, 20);
            this.txtCassCity.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(38, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "City";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCassStreet
            // 
            this.txtCassStreet.Location = new System.Drawing.Point(79, 32);
            this.txtCassStreet.Name = "txtCassStreet";
            this.txtCassStreet.ReadOnly = true;
            this.txtCassStreet.Size = new System.Drawing.Size(226, 20);
            this.txtCassStreet.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Street";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(8, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Copyright 2017 Avalara Inc.";
            // 
            // txtJurisdictionCode
            // 
            this.txtJurisdictionCode.Location = new System.Drawing.Point(102, 29);
            this.txtJurisdictionCode.Name = "txtJurisdictionCode";
            this.txtJurisdictionCode.ReadOnly = true;
            this.txtJurisdictionCode.Size = new System.Drawing.Size(203, 20);
            this.txtJurisdictionCode.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(9, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Jurisdiction Code";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(3, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Jurisdiction Name";
            // 
            // txtJurisdictionName
            // 
            this.txtJurisdictionName.Location = new System.Drawing.Point(102, 55);
            this.txtJurisdictionName.Name = "txtJurisdictionName";
            this.txtJurisdictionName.ReadOnly = true;
            this.txtJurisdictionName.Size = new System.Drawing.Size(203, 20);
            this.txtJurisdictionName.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(32, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "FIPS Code";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(32, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "Feature ID";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFIPSCode
            // 
            this.txtFIPSCode.Location = new System.Drawing.Point(102, 81);
            this.txtFIPSCode.Name = "txtFIPSCode";
            this.txtFIPSCode.ReadOnly = true;
            this.txtFIPSCode.Size = new System.Drawing.Size(122, 20);
            this.txtFIPSCode.TabIndex = 24;
            // 
            // txtFeatureID
            // 
            this.txtFeatureID.Location = new System.Drawing.Point(102, 107);
            this.txtFeatureID.Name = "txtFeatureID";
            this.txtFeatureID.ReadOnly = true;
            this.txtFeatureID.Size = new System.Drawing.Size(122, 20);
            this.txtFeatureID.TabIndex = 25;
            // 
            // chkUnincorporated
            // 
            this.chkUnincorporated.AutoSize = true;
            this.chkUnincorporated.Enabled = false;
            this.chkUnincorporated.Location = new System.Drawing.Point(12, 139);
            this.chkUnincorporated.Name = "chkUnincorporated";
            this.chkUnincorporated.Size = new System.Drawing.Size(99, 17);
            this.chkUnincorporated.TabIndex = 28;
            this.chkUnincorporated.Text = "Unincorporated";
            this.chkUnincorporated.UseVisualStyleBackColor = true;
            // 
            // chkGeocodedSTD
            // 
            this.chkGeocodedSTD.AutoSize = true;
            this.chkGeocodedSTD.Enabled = false;
            this.chkGeocodedSTD.Location = new System.Drawing.Point(188, 135);
            this.chkGeocodedSTD.Name = "chkGeocodedSTD";
            this.chkGeocodedSTD.Size = new System.Drawing.Size(117, 17);
            this.chkGeocodedSTD.TabIndex = 29;
            this.chkGeocodedSTD.Text = "Special Tax District";
            this.chkGeocodedSTD.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtJurisdictionCode);
            this.groupBox6.Controls.Add(this.chkGeocodedSTD);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.chkUnincorporated);
            this.groupBox6.Controls.Add(this.txtJurisdictionName);
            this.groupBox6.Controls.Add(this.txtFIPSCode);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtFeatureID);
            this.groupBox6.Location = new System.Drawing.Point(351, 335);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(315, 166);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tax Jurisdiction Information";
            // 
            // AFCGeoDemoClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(683, 529);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbxAvalaraLogo);
            this.Name = "AFCGeoDemoClient";
            this.Text = "AFCGeoSaaS Demo Client";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvalaraLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAvalaraLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerifyAddress;
        private System.Windows.Forms.CheckBox chkSpecialTaxDistrict;
        private System.Windows.Forms.CheckBox chkCassCertify;
        private System.Windows.Forms.TextBox txtCityStateZip;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtServerTime;
        private System.Windows.Forms.Button btnGetServerTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCassPostalCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCassState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCassCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCassStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGeocodedCounty;
        private System.Windows.Forms.TextBox txtGeocodedPostalCode;
        private System.Windows.Forms.TextBox txtGeocodedStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGeocodedState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGeocodedCity;
        private System.Windows.Forms.TextBox txtJurisdictionCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtJurisdictionName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFeatureID;
        private System.Windows.Forms.TextBox txtFIPSCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkGeocodedSTD;
        private System.Windows.Forms.CheckBox chkUnincorporated;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

