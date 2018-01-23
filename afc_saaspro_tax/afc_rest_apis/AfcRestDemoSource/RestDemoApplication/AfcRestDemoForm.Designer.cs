﻿namespace Avalara.CommsPlatform.Api.RestDemoApplication
{
    partial class AfcRestDemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfcRestDemoForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sampleTabPage = new System.Windows.Forms.TabPage();
            this.processButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.performanceTabPage = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.urlStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.authenticationGroupBox = new System.Windows.Forms.GroupBox();
            this.profileIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.requestCountTextBox = new System.Windows.Forms.TextBox();
            this.invoiceCountTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lineItemCountTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maxTimeComboBox = new System.Windows.Forms.ComboBox();
            this.maxThreadsComboBox = new System.Windows.Forms.ComboBox();
            this.averageTimeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.taxCountTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.timeElapsedTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.averageResponseTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.slowestResponseTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.percentile25TextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.medianTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.percentile75TextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.fastestTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.responseTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.processingStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.chart = new Telerik.WinControls.UI.RadChartView();
            this.timer = new System.Windows.Forms.Timer();
            this.tabControl.SuspendLayout();
            this.sampleTabPage.SuspendLayout();
            this.performanceTabPage.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.authenticationGroupBox.SuspendLayout();
            this.responseTimeGroupBox.SuspendLayout();
            this.processingStatsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.sampleTabPage);
            this.tabControl.Controls.Add(this.performanceTabPage);
            this.tabControl.Location = new System.Drawing.Point(13, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(785, 605);
            this.tabControl.TabIndex = 0;
            // 
            // sampleTabPage
            // 
            this.sampleTabPage.Controls.Add(this.processButton);
            this.sampleTabPage.Controls.Add(this.label2);
            this.sampleTabPage.Controls.Add(this.label1);
            this.sampleTabPage.Controls.Add(this.responseTextBox);
            this.sampleTabPage.Controls.Add(this.requestTextBox);
            this.sampleTabPage.Controls.Add(this.label30);
            this.sampleTabPage.Location = new System.Drawing.Point(4, 22);
            this.sampleTabPage.Name = "sampleTabPage";
            this.sampleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sampleTabPage.Size = new System.Drawing.Size(777, 449);
            this.sampleTabPage.TabIndex = 0;
            this.sampleTabPage.Text = "Sample Request";
            this.sampleTabPage.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.processButton.Location = new System.Drawing.Point(690, 415);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Response";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Request";
            // 
            // responseTextBox
            // 
            this.responseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.responseTextBox.Location = new System.Drawing.Point(400, 35);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ReadOnly = true;
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responseTextBox.Size = new System.Drawing.Size(365, 365);
            this.responseTextBox.TabIndex = 1;
            // 
            // requestTextBox
            // 
            this.requestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestTextBox.Location = new System.Drawing.Point(15, 35);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.requestTextBox.Size = new System.Drawing.Size(365, 365);
            this.requestTextBox.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 415);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(300, 13);
            this.label30.TabIndex = 50;
            this.label30.Text = "Note: Sample request body is used for performance test processing.";
            // 
            // performanceTabPage
            // 
            this.performanceTabPage.Controls.Add(this.abortButton);
            this.performanceTabPage.Controls.Add(this.startButton);
            this.performanceTabPage.Controls.Add(this.processingStatsGroupBox);
            this.performanceTabPage.Controls.Add(this.responseTimeGroupBox);
            this.performanceTabPage.Controls.Add(this.maxThreadsComboBox);
            this.performanceTabPage.Controls.Add(this.maxTimeComboBox);
            this.performanceTabPage.Controls.Add(this.label12);
            this.performanceTabPage.Controls.Add(this.label11);
            this.performanceTabPage.Controls.Add(this.label10);
            this.performanceTabPage.Controls.Add(this.chartPanel);
            this.performanceTabPage.Location = new System.Drawing.Point(4, 22);
            this.performanceTabPage.Name = "performanceTabPage";
            this.performanceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.performanceTabPage.Size = new System.Drawing.Size(777, 449);
            this.performanceTabPage.TabIndex = 1;
            this.performanceTabPage.Text = "Performance";
            this.performanceTabPage.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.urlStatusLabel,
            this.versionStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 550);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(809, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "This is my status text";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoSize = false;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel.Text = "Ready";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // urlStatusLabel
            // 
            this.urlStatusLabel.AutoSize = false;
            this.urlStatusLabel.Name = "urlStatusLabel";
            this.urlStatusLabel.Size = new System.Drawing.Size(500, 17);
            this.urlStatusLabel.Text = "URL: ";
            this.urlStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionStatusLabel
            // 
            this.versionStatusLabel.Name = "versionStatusLabel";
            this.versionStatusLabel.Size = new System.Drawing.Size(143, 17);
            this.versionStatusLabel.Text = "Comms Platform Version:";
            // 
            // authenticationGroupBox
            // 
            this.authenticationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authenticationGroupBox.Controls.Add(this.profileIDTextBox);
            this.authenticationGroupBox.Controls.Add(this.label6);
            this.authenticationGroupBox.Controls.Add(this.clientIDTextBox);
            this.authenticationGroupBox.Controls.Add(this.label5);
            this.authenticationGroupBox.Controls.Add(this.passwordTextBox);
            this.authenticationGroupBox.Controls.Add(this.label4);
            this.authenticationGroupBox.Controls.Add(this.usernameTextBox);
            this.authenticationGroupBox.Controls.Add(this.label3);
            this.authenticationGroupBox.Location = new System.Drawing.Point(13, 13);
            this.authenticationGroupBox.Name = "authenticationGroupBox";
            this.authenticationGroupBox.Size = new System.Drawing.Size(785, 46);
            this.authenticationGroupBox.TabIndex = 2;
            this.authenticationGroupBox.TabStop = false;
            this.authenticationGroupBox.Text = "Authentication";
            // 
            // profileIDTextBox
            // 
            this.profileIDTextBox.Location = new System.Drawing.Point(647, 17);
            this.profileIDTextBox.Name = "profileIDTextBox";
            this.profileIDTextBox.Size = new System.Drawing.Size(45, 20);
            this.profileIDTextBox.TabIndex = 7;
            this.profileIDTextBox.Text = "0";
            this.profileIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.profileIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integerTextBoxKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Profile ID";
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.Location = new System.Drawing.Point(545, 17);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(40, 20);
            this.clientIDTextBox.TabIndex = 5;
            this.clientIDTextBox.Text = "536";
            this.clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clientIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integerTextBoxKeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Client ID";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(386, 17);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(71, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(250, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Requests Processed";
            // 
            // requestCountTextBox
            // 
            this.requestCountTextBox.Location = new System.Drawing.Point(148, 43);
            this.requestCountTextBox.Name = "requestCountTextBox";
            this.requestCountTextBox.ReadOnly = true;
            this.requestCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestCountTextBox.TabIndex = 1;
            this.requestCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // invoiceCountTextBox
            // 
            this.invoiceCountTextBox.Location = new System.Drawing.Point(148, 69);
            this.invoiceCountTextBox.Name = "invoiceCountTextBox";
            this.invoiceCountTextBox.ReadOnly = true;
            this.invoiceCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceCountTextBox.TabIndex = 3;
            this.invoiceCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Invoices Processed";
            // 
            // lineItemCountTextBox
            // 
            this.lineItemCountTextBox.Location = new System.Drawing.Point(148, 95);
            this.lineItemCountTextBox.Name = "lineItemCountTextBox";
            this.lineItemCountTextBox.ReadOnly = true;
            this.lineItemCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.lineItemCountTextBox.TabIndex = 5;
            this.lineItemCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Line Items Processed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Max Run Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Max Threads";
            // 
            // maxTimeComboBox
            // 
            this.maxTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxTimeComboBox.FormattingEnabled = true;
            this.maxTimeComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.maxTimeComboBox.Location = new System.Drawing.Point(245, 12);
            this.maxTimeComboBox.Name = "maxTimeComboBox";
            this.maxTimeComboBox.Size = new System.Drawing.Size(59, 21);
            this.maxTimeComboBox.TabIndex = 9;
            // 
            // maxThreadsComboBox
            // 
            this.maxThreadsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxThreadsComboBox.FormattingEnabled = true;
            this.maxThreadsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.maxThreadsComboBox.Location = new System.Drawing.Point(84, 12);
            this.maxThreadsComboBox.Name = "maxThreadsComboBox";
            this.maxThreadsComboBox.Size = new System.Drawing.Size(59, 21);
            this.maxThreadsComboBox.TabIndex = 10;
            // 
            // averageTimeTextBox
            // 
            this.averageTimeTextBox.Location = new System.Drawing.Point(148, 147);
            this.averageTimeTextBox.Name = "averageTimeTextBox";
            this.averageTimeTextBox.ReadOnly = true;
            this.averageTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageTimeTextBox.TabIndex = 16;
            this.averageTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Taxes Returned";
            // 
            // taxCountTextBox
            // 
            this.taxCountTextBox.Location = new System.Drawing.Point(148, 121);
            this.taxCountTextBox.Name = "taxCountTextBox";
            this.taxCountTextBox.ReadOnly = true;
            this.taxCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxCountTextBox.TabIndex = 12;
            this.taxCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Average Processing Time";
            // 
            // timeElapsedTextBox
            // 
            this.timeElapsedTextBox.Location = new System.Drawing.Point(148, 17);
            this.timeElapsedTextBox.Name = "timeElapsedTextBox";
            this.timeElapsedTextBox.ReadOnly = true;
            this.timeElapsedTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeElapsedTextBox.TabIndex = 19;
            this.timeElapsedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Time Elapsed";
            // 
            // averageResponseTextBox
            // 
            this.averageResponseTextBox.Location = new System.Drawing.Point(123, 17);
            this.averageResponseTextBox.Name = "averageResponseTextBox";
            this.averageResponseTextBox.ReadOnly = true;
            this.averageResponseTextBox.Size = new System.Drawing.Size(86, 20);
            this.averageResponseTextBox.TabIndex = 21;
            this.averageResponseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Average";
            // 
            // slowestResponseTextBox
            // 
            this.slowestResponseTextBox.Location = new System.Drawing.Point(123, 43);
            this.slowestResponseTextBox.Name = "slowestResponseTextBox";
            this.slowestResponseTextBox.ReadOnly = true;
            this.slowestResponseTextBox.Size = new System.Drawing.Size(86, 20);
            this.slowestResponseTextBox.TabIndex = 24;
            this.slowestResponseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Slowest";
            // 
            // percentile25TextBox
            // 
            this.percentile25TextBox.Location = new System.Drawing.Point(123, 69);
            this.percentile25TextBox.Name = "percentile25TextBox";
            this.percentile25TextBox.ReadOnly = true;
            this.percentile25TextBox.Size = new System.Drawing.Size(86, 20);
            this.percentile25TextBox.TabIndex = 27;
            this.percentile25TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "25th Percentile";
            // 
            // medianTextBox
            // 
            this.medianTextBox.Location = new System.Drawing.Point(123, 95);
            this.medianTextBox.Name = "medianTextBox";
            this.medianTextBox.ReadOnly = true;
            this.medianTextBox.Size = new System.Drawing.Size(86, 20);
            this.medianTextBox.TabIndex = 30;
            this.medianTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 98);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 29;
            this.label24.Text = "Median";
            // 
            // percentile75TextBox
            // 
            this.percentile75TextBox.Location = new System.Drawing.Point(123, 121);
            this.percentile75TextBox.Name = "percentile75TextBox";
            this.percentile75TextBox.ReadOnly = true;
            this.percentile75TextBox.Size = new System.Drawing.Size(86, 20);
            this.percentile75TextBox.TabIndex = 33;
            this.percentile75TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 124);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 13);
            this.label26.TabIndex = 32;
            this.label26.Text = "75th Percentile";
            // 
            // fastestTextBox
            // 
            this.fastestTextBox.Location = new System.Drawing.Point(123, 147);
            this.fastestTextBox.Name = "fastestTextBox";
            this.fastestTextBox.ReadOnly = true;
            this.fastestTextBox.Size = new System.Drawing.Size(86, 20);
            this.fastestTextBox.TabIndex = 36;
            this.fastestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 150);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "Fastest";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(254, 150);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(102, 13);
            this.label29.TabIndex = 38;
            this.label29.Text = "line items per minute";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(254, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "tax lines";
            // 
            // responseTimeGroupBox
            // 
            this.responseTimeGroupBox.Controls.Add(this.label27);
            this.responseTimeGroupBox.Controls.Add(this.label25);
            this.responseTimeGroupBox.Controls.Add(this.label23);
            this.responseTimeGroupBox.Controls.Add(this.label21);
            this.responseTimeGroupBox.Controls.Add(this.label19);
            this.responseTimeGroupBox.Controls.Add(this.label18);
            this.responseTimeGroupBox.Controls.Add(this.label17);
            this.responseTimeGroupBox.Controls.Add(this.averageResponseTextBox);
            this.responseTimeGroupBox.Controls.Add(this.label20);
            this.responseTimeGroupBox.Controls.Add(this.fastestTextBox);
            this.responseTimeGroupBox.Controls.Add(this.slowestResponseTextBox);
            this.responseTimeGroupBox.Controls.Add(this.label28);
            this.responseTimeGroupBox.Controls.Add(this.label22);
            this.responseTimeGroupBox.Controls.Add(this.percentile75TextBox);
            this.responseTimeGroupBox.Controls.Add(this.percentile25TextBox);
            this.responseTimeGroupBox.Controls.Add(this.label26);
            this.responseTimeGroupBox.Controls.Add(this.label24);
            this.responseTimeGroupBox.Controls.Add(this.medianTextBox);
            this.responseTimeGroupBox.Location = new System.Drawing.Point(400, 395);
            this.responseTimeGroupBox.Name = "responseTimeGroupBox";
            this.responseTimeGroupBox.Size = new System.Drawing.Size(370, 180);
            this.responseTimeGroupBox.TabIndex = 40;
            this.responseTimeGroupBox.TabStop = false;
            this.responseTimeGroupBox.Text = "Response Time";
            // 
            // processingStatsGroupBox
            // 
            this.processingStatsGroupBox.Controls.Add(this.label16);
            this.processingStatsGroupBox.Controls.Add(this.timeElapsedTextBox);
            this.processingStatsGroupBox.Controls.Add(this.label14);
            this.processingStatsGroupBox.Controls.Add(this.label7);
            this.processingStatsGroupBox.Controls.Add(this.label29);
            this.processingStatsGroupBox.Controls.Add(this.requestCountTextBox);
            this.processingStatsGroupBox.Controls.Add(this.label13);
            this.processingStatsGroupBox.Controls.Add(this.averageTimeTextBox);
            this.processingStatsGroupBox.Controls.Add(this.label15);
            this.processingStatsGroupBox.Controls.Add(this.invoiceCountTextBox);
            this.processingStatsGroupBox.Controls.Add(this.lineItemCountTextBox);
            this.processingStatsGroupBox.Controls.Add(this.taxCountTextBox);
            this.processingStatsGroupBox.Controls.Add(this.label8);
            this.processingStatsGroupBox.Controls.Add(this.label9);
            this.processingStatsGroupBox.Location = new System.Drawing.Point(15, 395);
            this.processingStatsGroupBox.Name = "processingStatsGroupBox";
            this.processingStatsGroupBox.Size = new System.Drawing.Size(370, 180);
            this.processingStatsGroupBox.TabIndex = 41;
            this.processingStatsGroupBox.TabStop = false;
            this.processingStatsGroupBox.Text = "Processing Stats";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(215, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "milliseconds";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(215, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "milliseconds";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(215, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "milliseconds";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(215, 98);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "milliseconds";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(215, 124);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 44;
            this.label25.Text = "milliseconds";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(215, 150);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 45;
            this.label27.Text = "milliseconds";
            // 
            // startButton
            // 
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.Location = new System.Drawing.Point(613, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 42;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // abortButton
            // 
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            this.abortButton.Enabled = false;
            this.abortButton.Location = new System.Drawing.Point(694, 10);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 23);
            this.abortButton.TabIndex = 43;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            //
            // chartPanel
            this.chartPanel.BackColor = System.Drawing.Color.Gray;
            this.chartPanel.Location = new System.Drawing.Point(14, 39);
            this.chartPanel.Controls.Add(chart);
            this.chartPanel.Size = new System.Drawing.Size(757, 352);
            //
            //
            // chart
            //
            this.chart.AreaType = Telerik.WinControls.UI.ChartAreaType.Cartesian;
            this.chart.Location = new System.Drawing.Point(1, 1);
            this.chart.ShowLegend = true;
            this.chart.Size = new System.Drawing.Size(755, 350);
            //
            // timer
            //
            this.timer.Enabled = false;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AfcRestDemoForm
            // 
            this.ClientSize = new System.Drawing.Size(810, 700);
            this.Controls.Add(this.authenticationGroupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 740);
            this.MinimumSize = new System.Drawing.Size(825, 740);
            this.Name = "AfcRestDemoForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Avalara for Communications  REST Demo Application";
            this.tabControl.ResumeLayout(false);
            this.sampleTabPage.ResumeLayout(false);
            this.sampleTabPage.PerformLayout();
            this.performanceTabPage.ResumeLayout(false);
            this.performanceTabPage.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.authenticationGroupBox.ResumeLayout(false);
            this.authenticationGroupBox.PerformLayout();
            this.responseTimeGroupBox.ResumeLayout(false);
            this.responseTimeGroupBox.PerformLayout();
            this.processingStatsGroupBox.ResumeLayout(false);
            this.processingStatsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage sampleTabPage;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.TabPage performanceTabPage;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox authenticationGroupBox;
        private System.Windows.Forms.TextBox profileIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel urlStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel versionStatusLabel;
        private System.Windows.Forms.TextBox averageTimeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox taxCountTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox maxThreadsComboBox;
        private System.Windows.Forms.ComboBox maxTimeComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lineItemCountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox invoiceCountTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox requestCountTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox processingStatsGroupBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox timeElapsedTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox responseTimeGroupBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox averageResponseTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox fastestTextBox;
        private System.Windows.Forms.TextBox slowestResponseTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox percentile75TextBox;
        private System.Windows.Forms.TextBox percentile25TextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox medianTextBox;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel chartPanel;
        private Telerik.WinControls.UI.RadChartView chart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label30;
    }
}
