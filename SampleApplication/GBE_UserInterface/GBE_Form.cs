using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using GBE_Data;
using GBE_Data.DataObjectConverters;
using GBE_Data.DataObjects;

namespace GBE_UserInterface
{
	public class GBE_Form : System.Windows.Forms.Form
	{
		#region Auto generated code

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordText;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.TextBox usernameText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label readonlyUrlLabel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label availableFundsLabel;
		private System.Windows.Forms.TextBox availableFundsText;
		private System.Windows.Forms.Label balanceLabel;
		private System.Windows.Forms.TextBox balanceText;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label exposureLabel;
		private System.Windows.Forms.TextBox exposureText;
		private System.Windows.Forms.Button getDetailsButton;
		private System.Windows.Forms.TextBox secureUrlText;
		private System.Windows.Forms.TextBox readonlyUrlText;
		private System.Windows.Forms.Label secureUrlLabel;
		private System.Windows.Forms.Label currencyLabel;
		private System.Windows.Forms.TextBox currencyText;
		private System.Windows.Forms.Label creditLabel;
		private System.Windows.Forms.TextBox creditText;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage page1;
		private System.Windows.Forms.TabPage page2;
		private System.Windows.Forms.Label logLabel;
		private System.Windows.Forms.TreeView eventsTreeView;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button getEventsButton;
		private System.Windows.Forms.Label eventsLabel;
		private System.Windows.Forms.TextBox baseUrlText;
		private System.Windows.Forms.Label baseUrlLabel;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label electionsLabel;
		private System.Windows.Forms.DataGrid selectionsGrid;
		private System.Windows.Forms.Label eventIdLabel;
		private System.Windows.Forms.TextBox eventIdText;
		private System.Windows.Forms.Label marketIdLabel;
		private System.Windows.Forms.TextBox marketIdText;
		private System.Windows.Forms.Label selectionIdLabel;
		private System.Windows.Forms.TextBox selectionIdText;
		private System.Windows.Forms.Label amountLabel;
		private System.Windows.Forms.TextBox amountText;
		private System.Windows.Forms.Label oddsLabel;
		private System.Windows.Forms.TextBox oddsText;
		private System.Windows.Forms.Label resetCountLabel;
		private System.Windows.Forms.TextBox resetCountText;
		private System.Windows.Forms.Button placeBetsButton;
		private System.Windows.Forms.Label betIdlabel;
		private System.Windows.Forms.Label polarityLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton backOption;
		private System.Windows.Forms.RadioButton layOption;
		private System.Windows.Forms.Button getBetsButton;
		private System.Windows.Forms.DataGrid betsGrid;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGrid listOrdersChangedSinceGrid;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button listOrdersChangedSinceButtonListBootstrapOrders;
		private System.Windows.Forms.Button connectButton;
		private System.Windows.Forms.TabPage page3;
		private System.Windows.Forms.Button addBetButton;
		private System.Windows.Forms.ListBox betsToPlaceList;
		private System.Windows.Forms.Label betsToPlaceLabel;
		private System.Windows.Forms.CheckBox displayIdsCheck;
		private System.Windows.Forms.Button clearListButton;
		private System.Windows.Forms.ListBox betIdsList;
		private System.Windows.Forms.Button cancelBetButton;
		private System.Windows.Forms.Label betIdToCancelLabel;
		private System.Windows.Forms.Button cancelBetPage1Button;
		private System.Windows.Forms.TextBox logText;
        private Button getPricesButton;

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button getPricesButton1;
		private System.Windows.Forms.CheckBox allOrNotingCheckBox;
		

        private long selectedMarketId;

		[STAThread]
		static void Main() 
		{
			Application.Run(new GBE_Form());
		}


		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.connectButton = new System.Windows.Forms.Button();
			this.baseUrlText = new System.Windows.Forms.TextBox();
			this.baseUrlLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.usernameText = new System.Windows.Forms.TextBox();
			this.secureUrlText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.readonlyUrlLabel = new System.Windows.Forms.Label();
			this.readonlyUrlText = new System.Windows.Forms.TextBox();
			this.secureUrlLabel = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.creditLabel = new System.Windows.Forms.Label();
			this.creditText = new System.Windows.Forms.TextBox();
			this.currencyLabel = new System.Windows.Forms.Label();
			this.currencyText = new System.Windows.Forms.TextBox();
			this.availableFundsLabel = new System.Windows.Forms.Label();
			this.availableFundsText = new System.Windows.Forms.TextBox();
			this.balanceLabel = new System.Windows.Forms.Label();
			this.balanceText = new System.Windows.Forms.TextBox();
			this.getDetailsButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.exposureLabel = new System.Windows.Forms.Label();
			this.exposureText = new System.Windows.Forms.TextBox();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.tabs = new System.Windows.Forms.TabControl();
			this.page1 = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.allOrNotingCheckBox = new System.Windows.Forms.CheckBox();
			this.cancelBetPage1Button = new System.Windows.Forms.Button();
			this.betIdsList = new System.Windows.Forms.ListBox();
			this.clearListButton = new System.Windows.Forms.Button();
			this.displayIdsCheck = new System.Windows.Forms.CheckBox();
			this.betsToPlaceLabel = new System.Windows.Forms.Label();
			this.betsToPlaceList = new System.Windows.Forms.ListBox();
			this.addBetButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.backOption = new System.Windows.Forms.RadioButton();
			this.layOption = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.polarityLabel = new System.Windows.Forms.Label();
			this.betIdlabel = new System.Windows.Forms.Label();
			this.placeBetsButton = new System.Windows.Forms.Button();
			this.resetCountLabel = new System.Windows.Forms.Label();
			this.resetCountText = new System.Windows.Forms.TextBox();
			this.oddsLabel = new System.Windows.Forms.Label();
			this.oddsText = new System.Windows.Forms.TextBox();
			this.amountLabel = new System.Windows.Forms.Label();
			this.amountText = new System.Windows.Forms.TextBox();
			this.selectionIdLabel = new System.Windows.Forms.Label();
			this.selectionIdText = new System.Windows.Forms.TextBox();
			this.marketIdLabel = new System.Windows.Forms.Label();
			this.marketIdText = new System.Windows.Forms.TextBox();
			this.eventIdLabel = new System.Windows.Forms.Label();
			this.eventIdText = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.getPricesButton1 = new System.Windows.Forms.Button();
			this.getEventsButton = new System.Windows.Forms.Button();
			this.eventsLabel = new System.Windows.Forms.Label();
			this.eventsTreeView = new System.Windows.Forms.TreeView();
			this.selectionsGrid = new System.Windows.Forms.DataGrid();
			this.electionsLabel = new System.Windows.Forms.Label();
			this.page3 = new System.Windows.Forms.TabPage();
			this.cancelBetButton = new System.Windows.Forms.Button();
			this.betIdToCancelLabel = new System.Windows.Forms.Label();
			this.listOrdersChangedSinceButtonListBootstrapOrders = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.listOrdersChangedSinceGrid = new System.Windows.Forms.DataGrid();
			this.label4 = new System.Windows.Forms.Label();
			this.getBetsButton = new System.Windows.Forms.Button();
			this.betsGrid = new System.Windows.Forms.DataGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.page2 = new System.Windows.Forms.TabPage();
			this.logText = new System.Windows.Forms.TextBox();
			this.logLabel = new System.Windows.Forms.Label();
			this.getPricesButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabs.SuspendLayout();
			this.page1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.selectionsGrid)).BeginInit();
			this.page3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.listOrdersChangedSinceGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.betsGrid)).BeginInit();
			this.page2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.connectButton);
			this.panel1.Controls.Add(this.baseUrlText);
			this.panel1.Controls.Add(this.baseUrlLabel);
			this.panel1.Controls.Add(this.passwordLabel);
			this.panel1.Controls.Add(this.passwordText);
			this.panel1.Controls.Add(this.usernameLabel);
			this.panel1.Controls.Add(this.usernameText);
			this.panel1.Controls.Add(this.secureUrlText);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.readonlyUrlLabel);
			this.panel1.Controls.Add(this.readonlyUrlText);
			this.panel1.Controls.Add(this.secureUrlLabel);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 208);
			this.panel1.TabIndex = 6;
			// 
			// connectButton
			// 
			this.connectButton.BackColor = System.Drawing.Color.MidnightBlue;
			this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.connectButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.connectButton.ForeColor = System.Drawing.Color.White;
			this.connectButton.Location = new System.Drawing.Point(368, 176);
			this.connectButton.Name = "connectButton";
			this.connectButton.Size = new System.Drawing.Size(104, 24);
			this.connectButton.TabIndex = 10;
			this.connectButton.Text = "Connect";
			this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
			// 
			// baseUrlText
			// 
			this.baseUrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.baseUrlText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.baseUrlText.Location = new System.Drawing.Point(96, 96);
			this.baseUrlText.Name = "baseUrlText";
			this.baseUrlText.Size = new System.Drawing.Size(376, 19);
			this.baseUrlText.TabIndex = 3;
			this.baseUrlText.Text = "http://api.betdaq.com/v2.0/";
			// 
			// baseUrlLabel
			// 
			this.baseUrlLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.baseUrlLabel.Location = new System.Drawing.Point(16, 96);
			this.baseUrlLabel.Name = "baseUrlLabel";
			this.baseUrlLabel.Size = new System.Drawing.Size(73, 23);
			this.baseUrlLabel.TabIndex = 9;
			this.baseUrlLabel.Text = "Base URL:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.passwordLabel.Location = new System.Drawing.Point(16, 72);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(72, 23);
			this.passwordLabel.TabIndex = 8;
			this.passwordLabel.Text = "Password:";
			// 
			// passwordText
			// 
			this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.passwordText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.passwordText.Location = new System.Drawing.Point(96, 72);
			this.passwordText.Name = "passwordText";
			this.passwordText.PasswordChar = '*';
			this.passwordText.Size = new System.Drawing.Size(376, 19);
			this.passwordText.TabIndex = 2;
			this.passwordText.Text = "";
			// 
			// usernameLabel
			// 
			this.usernameLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.usernameLabel.Location = new System.Drawing.Point(16, 49);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(72, 23);
			this.usernameLabel.TabIndex = 6;
			this.usernameLabel.Text = "Username:";
			// 
			// usernameText
			// 
			this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.usernameText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.usernameText.Location = new System.Drawing.Point(96, 49);
			this.usernameText.Name = "usernameText";
			this.usernameText.Size = new System.Drawing.Size(376, 19);
			this.usernameText.TabIndex = 1;
			this.usernameText.Text = "";
			// 
			// secureUrlText
			// 
			this.secureUrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.secureUrlText.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.secureUrlText.Location = new System.Drawing.Point(96, 120);
			this.secureUrlText.Name = "secureUrlText";
			this.secureUrlText.Size = new System.Drawing.Size(376, 18);
			this.secureUrlText.TabIndex = 4;
			this.secureUrlText.Text = "Secure/SecureService.asmx";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Configure Web Service Settings:";
			// 
			// readonlyUrlLabel
			// 
			this.readonlyUrlLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.readonlyUrlLabel.Location = new System.Drawing.Point(16, 144);
			this.readonlyUrlLabel.Name = "readonlyUrlLabel";
			this.readonlyUrlLabel.Size = new System.Drawing.Size(72, 23);
			this.readonlyUrlLabel.TabIndex = 0;
			this.readonlyUrlLabel.Text = "Readonly:";
			// 
			// readonlyUrlText
			// 
			this.readonlyUrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.readonlyUrlText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.readonlyUrlText.Location = new System.Drawing.Point(96, 144);
			this.readonlyUrlText.Name = "readonlyUrlText";
			this.readonlyUrlText.Size = new System.Drawing.Size(376, 19);
			this.readonlyUrlText.TabIndex = 5;
			this.readonlyUrlText.Text = "ReadOnlyService.asmx";
			// 
			// secureUrlLabel
			// 
			this.secureUrlLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.secureUrlLabel.Location = new System.Drawing.Point(16, 120);
			this.secureUrlLabel.Name = "secureUrlLabel";
			this.secureUrlLabel.Size = new System.Drawing.Size(64, 23);
			this.secureUrlLabel.TabIndex = 1;
			this.secureUrlLabel.Text = "Secure:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.creditLabel);
			this.panel2.Controls.Add(this.creditText);
			this.panel2.Controls.Add(this.currencyLabel);
			this.panel2.Controls.Add(this.currencyText);
			this.panel2.Controls.Add(this.availableFundsLabel);
			this.panel2.Controls.Add(this.availableFundsText);
			this.panel2.Controls.Add(this.balanceLabel);
			this.panel2.Controls.Add(this.balanceText);
			this.panel2.Controls.Add(this.getDetailsButton);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.exposureLabel);
			this.panel2.Controls.Add(this.exposureText);
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.Location = new System.Drawing.Point(496, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(232, 208);
			this.panel2.TabIndex = 7;
			// 
			// creditLabel
			// 
			this.creditLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.creditLabel.Location = new System.Drawing.Point(8, 144);
			this.creditLabel.Name = "creditLabel";
			this.creditLabel.TabIndex = 14;
			this.creditLabel.Text = "Credit:";
			// 
			// creditText
			// 
			this.creditText.BackColor = System.Drawing.Color.White;
			this.creditText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.creditText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.creditText.Location = new System.Drawing.Point(120, 144);
			this.creditText.Name = "creditText";
			this.creditText.ReadOnly = true;
			this.creditText.Size = new System.Drawing.Size(104, 19);
			this.creditText.TabIndex = 15;
			this.creditText.TabStop = false;
			this.creditText.Text = "";
			// 
			// currencyLabel
			// 
			this.currencyLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.currencyLabel.Location = new System.Drawing.Point(8, 49);
			this.currencyLabel.Name = "currencyLabel";
			this.currencyLabel.TabIndex = 12;
			this.currencyLabel.Text = "Currency:";
			// 
			// currencyText
			// 
			this.currencyText.BackColor = System.Drawing.Color.White;
			this.currencyText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.currencyText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.currencyText.Location = new System.Drawing.Point(120, 49);
			this.currencyText.Name = "currencyText";
			this.currencyText.ReadOnly = true;
			this.currencyText.Size = new System.Drawing.Size(104, 19);
			this.currencyText.TabIndex = 13;
			this.currencyText.TabStop = false;
			this.currencyText.Text = "";
			// 
			// availableFundsLabel
			// 
			this.availableFundsLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.availableFundsLabel.Location = new System.Drawing.Point(8, 96);
			this.availableFundsLabel.Name = "availableFundsLabel";
			this.availableFundsLabel.Size = new System.Drawing.Size(112, 23);
			this.availableFundsLabel.TabIndex = 10;
			this.availableFundsLabel.Text = "Available funds:";
			// 
			// availableFundsText
			// 
			this.availableFundsText.BackColor = System.Drawing.Color.White;
			this.availableFundsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.availableFundsText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.availableFundsText.Location = new System.Drawing.Point(120, 96);
			this.availableFundsText.Name = "availableFundsText";
			this.availableFundsText.ReadOnly = true;
			this.availableFundsText.Size = new System.Drawing.Size(104, 19);
			this.availableFundsText.TabIndex = 11;
			this.availableFundsText.TabStop = false;
			this.availableFundsText.Text = "";
			// 
			// balanceLabel
			// 
			this.balanceLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.balanceLabel.Location = new System.Drawing.Point(8, 72);
			this.balanceLabel.Name = "balanceLabel";
			this.balanceLabel.TabIndex = 8;
			this.balanceLabel.Text = "Balance:";
			// 
			// balanceText
			// 
			this.balanceText.BackColor = System.Drawing.Color.White;
			this.balanceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.balanceText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.balanceText.Location = new System.Drawing.Point(120, 72);
			this.balanceText.Name = "balanceText";
			this.balanceText.ReadOnly = true;
			this.balanceText.Size = new System.Drawing.Size(104, 19);
			this.balanceText.TabIndex = 9;
			this.balanceText.TabStop = false;
			this.balanceText.Text = "";
			// 
			// getDetailsButton
			// 
			this.getDetailsButton.BackColor = System.Drawing.Color.MidnightBlue;
			this.getDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getDetailsButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.getDetailsButton.ForeColor = System.Drawing.Color.White;
			this.getDetailsButton.Location = new System.Drawing.Point(120, 176);
			this.getDetailsButton.Name = "getDetailsButton";
			this.getDetailsButton.Size = new System.Drawing.Size(104, 24);
			this.getDetailsButton.TabIndex = 6;
			this.getDetailsButton.Text = "Get Details";
			this.getDetailsButton.Click += new System.EventHandler(this.getDetailsButton_Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Account Details:";
			// 
			// exposureLabel
			// 
			this.exposureLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.exposureLabel.Location = new System.Drawing.Point(8, 120);
			this.exposureLabel.Name = "exposureLabel";
			this.exposureLabel.TabIndex = 0;
			this.exposureLabel.Text = "Exposure:";
			// 
			// exposureText
			// 
			this.exposureText.BackColor = System.Drawing.Color.White;
			this.exposureText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.exposureText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.exposureText.Location = new System.Drawing.Point(120, 120);
			this.exposureText.Name = "exposureText";
			this.exposureText.ReadOnly = true;
			this.exposureText.Size = new System.Drawing.Size(104, 19);
			this.exposureText.TabIndex = 2;
			this.exposureText.TabStop = false;
			this.exposureText.Text = "";
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 710);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(744, 16);
			this.statusBar.TabIndex = 8;
			this.statusBar.Text = "Not connected";
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.page1);
			this.tabs.Controls.Add(this.page3);
			this.tabs.Controls.Add(this.page2);
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(744, 710);
			this.tabs.TabIndex = 9;
			// 
			// page1
			// 
			this.page1.BackColor = System.Drawing.Color.Gray;
			this.page1.Controls.Add(this.panel4);
			this.page1.Controls.Add(this.panel1);
			this.page1.Controls.Add(this.panel2);
			this.page1.Controls.Add(this.panel3);
			this.page1.Location = new System.Drawing.Point(4, 22);
			this.page1.Name = "page1";
			this.page1.Size = new System.Drawing.Size(736, 684);
			this.page1.TabIndex = 0;
			this.page1.Text = "Details";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Control;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.allOrNotingCheckBox);
			this.panel4.Controls.Add(this.cancelBetPage1Button);
			this.panel4.Controls.Add(this.betIdsList);
			this.panel4.Controls.Add(this.clearListButton);
			this.panel4.Controls.Add(this.displayIdsCheck);
			this.panel4.Controls.Add(this.betsToPlaceLabel);
			this.panel4.Controls.Add(this.betsToPlaceList);
			this.panel4.Controls.Add(this.addBetButton);
			this.panel4.Controls.Add(this.groupBox1);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.polarityLabel);
			this.panel4.Controls.Add(this.betIdlabel);
			this.panel4.Controls.Add(this.placeBetsButton);
			this.panel4.Controls.Add(this.resetCountLabel);
			this.panel4.Controls.Add(this.resetCountText);
			this.panel4.Controls.Add(this.oddsLabel);
			this.panel4.Controls.Add(this.oddsText);
			this.panel4.Controls.Add(this.amountLabel);
			this.panel4.Controls.Add(this.amountText);
			this.panel4.Controls.Add(this.selectionIdLabel);
			this.panel4.Controls.Add(this.selectionIdText);
			this.panel4.Controls.Add(this.marketIdLabel);
			this.panel4.Controls.Add(this.marketIdText);
			this.panel4.Controls.Add(this.eventIdLabel);
			this.panel4.Controls.Add(this.eventIdText);
			this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(496, 224);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(232, 456);
			this.panel4.TabIndex = 20;
			// 
			// allOrNotingCheckBox
			// 
			this.allOrNotingCheckBox.Location = new System.Drawing.Point(120, 344);
			this.allOrNotingCheckBox.Name = "allOrNotingCheckBox";
			this.allOrNotingCheckBox.TabIndex = 42;
			this.allOrNotingCheckBox.Text = "All or nothing";
			// 
			// cancelBetPage1Button
			// 
			this.cancelBetPage1Button.BackColor = System.Drawing.Color.MidnightBlue;
			this.cancelBetPage1Button.Enabled = false;
			this.cancelBetPage1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBetPage1Button.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cancelBetPage1Button.ForeColor = System.Drawing.Color.White;
			this.cancelBetPage1Button.Location = new System.Drawing.Point(120, 520);
			this.cancelBetPage1Button.Name = "cancelBetPage1Button";
			this.cancelBetPage1Button.Size = new System.Drawing.Size(104, 24);
			this.cancelBetPage1Button.TabIndex = 41;
			this.cancelBetPage1Button.Text = "Cancel Bet";
			this.cancelBetPage1Button.Click += new System.EventHandler(this.cancelBetPage1Button_Click);
			// 
			// betIdsList
			// 
			this.betIdsList.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.betIdsList.ItemHeight = 12;
			this.betIdsList.Location = new System.Drawing.Point(120, 400);
			this.betIdsList.Name = "betIdsList";
			this.betIdsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.betIdsList.Size = new System.Drawing.Size(104, 40);
			this.betIdsList.TabIndex = 40;
			// 
			// clearListButton
			// 
			this.clearListButton.BackColor = System.Drawing.Color.MidnightBlue;
			this.clearListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearListButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.clearListButton.ForeColor = System.Drawing.Color.White;
			this.clearListButton.Location = new System.Drawing.Point(8, 368);
			this.clearListButton.Name = "clearListButton";
			this.clearListButton.Size = new System.Drawing.Size(104, 24);
			this.clearListButton.TabIndex = 39;
			this.clearListButton.Text = "Clear List";
			this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
			// 
			// displayIdsCheck
			// 
			this.displayIdsCheck.Location = new System.Drawing.Point(120, 16);
			this.displayIdsCheck.Name = "displayIdsCheck";
			this.displayIdsCheck.TabIndex = 38;
			this.displayIdsCheck.Text = "Display IDs";
			this.displayIdsCheck.CheckedChanged += new System.EventHandler(this.displayIdsCheck_CheckedChanged);
			// 
			// betsToPlaceLabel
			// 
			this.betsToPlaceLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.betsToPlaceLabel.Location = new System.Drawing.Point(8, 280);
			this.betsToPlaceLabel.Name = "betsToPlaceLabel";
			this.betsToPlaceLabel.Size = new System.Drawing.Size(104, 23);
			this.betsToPlaceLabel.TabIndex = 35;
			this.betsToPlaceLabel.Text = "Bets to place:";
			// 
			// betsToPlaceList
			// 
			this.betsToPlaceList.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.betsToPlaceList.ItemHeight = 12;
			this.betsToPlaceList.Location = new System.Drawing.Point(120, 280);
			this.betsToPlaceList.Name = "betsToPlaceList";
			this.betsToPlaceList.Size = new System.Drawing.Size(104, 40);
			this.betsToPlaceList.TabIndex = 34;
			// 
			// addBetButton
			// 
			this.addBetButton.BackColor = System.Drawing.Color.MidnightBlue;
			this.addBetButton.Enabled = false;
			this.addBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBetButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.addBetButton.ForeColor = System.Drawing.Color.White;
			this.addBetButton.Location = new System.Drawing.Point(120, 248);
			this.addBetButton.Name = "addBetButton";
			this.addBetButton.Size = new System.Drawing.Size(104, 24);
			this.addBetButton.TabIndex = 33;
			this.addBetButton.Text = "Add Bet";
			this.addBetButton.Click += new System.EventHandler(this.addBetButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.backOption);
			this.groupBox1.Controls.Add(this.layOption);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(120, 184);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(104, 48);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			// 
			// backOption
			// 
			this.backOption.Checked = true;
			this.backOption.Location = new System.Drawing.Point(8, 8);
			this.backOption.Name = "backOption";
			this.backOption.Size = new System.Drawing.Size(56, 16);
			this.backOption.TabIndex = 0;
			this.backOption.TabStop = true;
			this.backOption.Text = "Back";
			// 
			// layOption
			// 
			this.layOption.Location = new System.Drawing.Point(8, 24);
			this.layOption.Name = "layOption";
			this.layOption.Size = new System.Drawing.Size(56, 16);
			this.layOption.TabIndex = 1;
			this.layOption.Text = "Lay";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 16);
			this.label2.TabIndex = 31;
			this.label2.Text = "Bet Details";
			// 
			// polarityLabel
			// 
			this.polarityLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.polarityLabel.Location = new System.Drawing.Point(8, 192);
			this.polarityLabel.Name = "polarityLabel";
			this.polarityLabel.Size = new System.Drawing.Size(104, 23);
			this.polarityLabel.TabIndex = 30;
			this.polarityLabel.Text = "Polarity:";
			// 
			// betIdlabel
			// 
			this.betIdlabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.betIdlabel.Location = new System.Drawing.Point(8, 400);
			this.betIdlabel.Name = "betIdlabel";
			this.betIdlabel.Size = new System.Drawing.Size(104, 23);
			this.betIdlabel.TabIndex = 27;
			this.betIdlabel.Text = "Bet Id(s):";
			// 
			// placeBetsButton
			// 
			this.placeBetsButton.BackColor = System.Drawing.Color.MidnightBlue;
			this.placeBetsButton.Enabled = false;
			this.placeBetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.placeBetsButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.placeBetsButton.ForeColor = System.Drawing.Color.White;
			this.placeBetsButton.Location = new System.Drawing.Point(120, 368);
			this.placeBetsButton.Name = "placeBetsButton";
			this.placeBetsButton.Size = new System.Drawing.Size(104, 24);
			this.placeBetsButton.TabIndex = 11;
			this.placeBetsButton.Text = "Place Bet";
			this.placeBetsButton.Click += new System.EventHandler(this.placeBetsButton_Click);
			// 
			// resetCountLabel
			// 
			this.resetCountLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.resetCountLabel.Location = new System.Drawing.Point(8, 112);
			this.resetCountLabel.Name = "resetCountLabel";
			this.resetCountLabel.Size = new System.Drawing.Size(104, 23);
			this.resetCountLabel.TabIndex = 24;
			this.resetCountLabel.Text = "Reset count:";
			// 
			// resetCountText
			// 
			this.resetCountText.BackColor = System.Drawing.Color.White;
			this.resetCountText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resetCountText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.resetCountText.Location = new System.Drawing.Point(120, 112);
			this.resetCountText.Name = "resetCountText";
			this.resetCountText.ReadOnly = true;
			this.resetCountText.Size = new System.Drawing.Size(104, 19);
			this.resetCountText.TabIndex = 25;
			this.resetCountText.TabStop = false;
			this.resetCountText.Text = "";
			// 
			// oddsLabel
			// 
			this.oddsLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.oddsLabel.Location = new System.Drawing.Point(8, 160);
			this.oddsLabel.Name = "oddsLabel";
			this.oddsLabel.Size = new System.Drawing.Size(104, 23);
			this.oddsLabel.TabIndex = 22;
			this.oddsLabel.Text = "Odds:";
			// 
			// oddsText
			// 
			this.oddsText.BackColor = System.Drawing.Color.White;
			this.oddsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.oddsText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.oddsText.Location = new System.Drawing.Point(120, 160);
			this.oddsText.Name = "oddsText";
			this.oddsText.Size = new System.Drawing.Size(104, 19);
			this.oddsText.TabIndex = 9;
			this.oddsText.Text = "2.0";
			// 
			// amountLabel
			// 
			this.amountLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.amountLabel.Location = new System.Drawing.Point(8, 136);
			this.amountLabel.Name = "amountLabel";
			this.amountLabel.Size = new System.Drawing.Size(104, 23);
			this.amountLabel.TabIndex = 20;
			this.amountLabel.Text = "Amount:";
			// 
			// amountText
			// 
			this.amountText.BackColor = System.Drawing.Color.White;
			this.amountText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.amountText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.amountText.Location = new System.Drawing.Point(120, 136);
			this.amountText.Name = "amountText";
			this.amountText.Size = new System.Drawing.Size(104, 19);
			this.amountText.TabIndex = 8;
			this.amountText.Text = "0.5";
			// 
			// selectionIdLabel
			// 
			this.selectionIdLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.selectionIdLabel.Location = new System.Drawing.Point(8, 88);
			this.selectionIdLabel.Name = "selectionIdLabel";
			this.selectionIdLabel.Size = new System.Drawing.Size(104, 23);
			this.selectionIdLabel.TabIndex = 18;
			this.selectionIdLabel.Text = "Selection:";
			// 
			// selectionIdText
			// 
			this.selectionIdText.BackColor = System.Drawing.Color.White;
			this.selectionIdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.selectionIdText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.selectionIdText.Location = new System.Drawing.Point(120, 88);
			this.selectionIdText.Name = "selectionIdText";
			this.selectionIdText.ReadOnly = true;
			this.selectionIdText.Size = new System.Drawing.Size(104, 19);
			this.selectionIdText.TabIndex = 19;
			this.selectionIdText.TabStop = false;
			this.selectionIdText.Text = "";
			this.selectionIdText.TextChanged += new System.EventHandler(this.selectionIdText_TextChanged);
			// 
			// marketIdLabel
			// 
			this.marketIdLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.marketIdLabel.Location = new System.Drawing.Point(8, 64);
			this.marketIdLabel.Name = "marketIdLabel";
			this.marketIdLabel.Size = new System.Drawing.Size(104, 23);
			this.marketIdLabel.TabIndex = 16;
			this.marketIdLabel.Text = "Market:";
			// 
			// marketIdText
			// 
			this.marketIdText.BackColor = System.Drawing.Color.White;
			this.marketIdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.marketIdText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.marketIdText.Location = new System.Drawing.Point(120, 64);
			this.marketIdText.Name = "marketIdText";
			this.marketIdText.ReadOnly = true;
			this.marketIdText.Size = new System.Drawing.Size(104, 19);
			this.marketIdText.TabIndex = 17;
			this.marketIdText.TabStop = false;
			this.marketIdText.Text = "";
			// 
			// eventIdLabel
			// 
			this.eventIdLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.eventIdLabel.Location = new System.Drawing.Point(8, 40);
			this.eventIdLabel.Name = "eventIdLabel";
			this.eventIdLabel.Size = new System.Drawing.Size(104, 23);
			this.eventIdLabel.TabIndex = 14;
			this.eventIdLabel.Text = "Event:";
			// 
			// eventIdText
			// 
			this.eventIdText.BackColor = System.Drawing.Color.White;
			this.eventIdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.eventIdText.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.eventIdText.Location = new System.Drawing.Point(120, 40);
			this.eventIdText.Name = "eventIdText";
			this.eventIdText.ReadOnly = true;
			this.eventIdText.Size = new System.Drawing.Size(104, 19);
			this.eventIdText.TabIndex = 15;
			this.eventIdText.TabStop = false;
			this.eventIdText.Text = "";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.getPricesButton1);
			this.panel3.Controls.Add(this.getEventsButton);
			this.panel3.Controls.Add(this.eventsLabel);
			this.panel3.Controls.Add(this.eventsTreeView);
			this.panel3.Controls.Add(this.selectionsGrid);
			this.panel3.Controls.Add(this.electionsLabel);
			this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.Location = new System.Drawing.Point(8, 224);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(480, 456);
			this.panel3.TabIndex = 19;
			// 
			// getPricesButton1
			// 
			this.getPricesButton1.BackColor = System.Drawing.Color.MidnightBlue;
			this.getPricesButton1.Enabled = false;
			this.getPricesButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getPricesButton1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.getPricesButton1.ForeColor = System.Drawing.Color.White;
			this.getPricesButton1.Location = new System.Drawing.Point(320, 424);
			this.getPricesButton1.Name = "getPricesButton1";
			this.getPricesButton1.Size = new System.Drawing.Size(152, 24);
			this.getPricesButton1.TabIndex = 19;
			this.getPricesButton1.Text = "Refresh Prices";
			this.getPricesButton1.Click += new System.EventHandler(this.getPricesButton1_Click);
			// 
			// getEventsButton
			// 
			this.getEventsButton.BackColor = System.Drawing.Color.MidnightBlue;
			this.getEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getEventsButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.getEventsButton.ForeColor = System.Drawing.Color.White;
			this.getEventsButton.Location = new System.Drawing.Point(320, 256);
			this.getEventsButton.Name = "getEventsButton";
			this.getEventsButton.Size = new System.Drawing.Size(152, 24);
			this.getEventsButton.TabIndex = 7;
			this.getEventsButton.Text = "Get Top Level Events";
			this.getEventsButton.Click += new System.EventHandler(this.getEventsButton_Click);
			// 
			// eventsLabel
			// 
			this.eventsLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.eventsLabel.Location = new System.Drawing.Point(16, 8);
			this.eventsLabel.Name = "eventsLabel";
			this.eventsLabel.Size = new System.Drawing.Size(64, 23);
			this.eventsLabel.TabIndex = 4;
			this.eventsLabel.Text = "Events";
			// 
			// eventsTreeView
			// 
			this.eventsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.eventsTreeView.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.eventsTreeView.FullRowSelect = true;
			this.eventsTreeView.ImageIndex = -1;
			this.eventsTreeView.Location = new System.Drawing.Point(16, 32);
			this.eventsTreeView.Name = "eventsTreeView";
			this.eventsTreeView.SelectedImageIndex = -1;
			this.eventsTreeView.Size = new System.Drawing.Size(456, 216);
			this.eventsTreeView.TabIndex = 18;
			this.eventsTreeView.TabStop = false;
			this.eventsTreeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.eventsTreeView_BeforeSelect);
			this.eventsTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.eventsTreeView_BeforeExpand);
			// 
			// selectionsGrid
			// 
			this.selectionsGrid.AllowNavigation = false;
			this.selectionsGrid.BackgroundColor = System.Drawing.Color.Gray;
			this.selectionsGrid.CaptionBackColor = System.Drawing.Color.Gray;
			this.selectionsGrid.DataMember = "";
			this.selectionsGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.selectionsGrid.ForeColor = System.Drawing.Color.Black;
			this.selectionsGrid.HeaderForeColor = System.Drawing.Color.Black;
			this.selectionsGrid.Location = new System.Drawing.Point(16, 288);
			this.selectionsGrid.Name = "selectionsGrid";
			this.selectionsGrid.ParentRowsForeColor = System.Drawing.Color.Gray;
			this.selectionsGrid.ReadOnly = true;
			this.selectionsGrid.SelectionBackColor = System.Drawing.Color.Black;
			this.selectionsGrid.Size = new System.Drawing.Size(456, 128);
			this.selectionsGrid.TabIndex = 5;
			this.selectionsGrid.TabStop = false;
			this.selectionsGrid.CurrentCellChanged += new System.EventHandler(this.selectionsGrid_CurrentCellChanged);
			// 
			// electionsLabel
			// 
			this.electionsLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.electionsLabel.Location = new System.Drawing.Point(16, 264);
			this.electionsLabel.Name = "electionsLabel";
			this.electionsLabel.Size = new System.Drawing.Size(80, 23);
			this.electionsLabel.TabIndex = 4;
			this.electionsLabel.Text = "Selections";
			// 
			// page3
			// 
			this.page3.Controls.Add(this.cancelBetButton);
			this.page3.Controls.Add(this.betIdToCancelLabel);
			this.page3.Controls.Add(this.listOrdersChangedSinceButtonListBootstrapOrders);
			this.page3.Controls.Add(this.label6);
			this.page3.Controls.Add(this.listOrdersChangedSinceGrid);
			this.page3.Controls.Add(this.label4);
			this.page3.Controls.Add(this.getBetsButton);
			this.page3.Controls.Add(this.betsGrid);
			this.page3.Controls.Add(this.label3);
			this.page3.Location = new System.Drawing.Point(4, 22);
			this.page3.Name = "page3";
			this.page3.Size = new System.Drawing.Size(736, 684);
			this.page3.TabIndex = 2;
			this.page3.Text = "My Bets";
			// 
			// cancelBetButton
			// 
			this.cancelBetButton.BackColor = System.Drawing.Color.MidnightBlue;
			this.cancelBetButton.Enabled = false;
			this.cancelBetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBetButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cancelBetButton.ForeColor = System.Drawing.Color.White;
			this.cancelBetButton.Location = new System.Drawing.Point(512, 552);
			this.cancelBetButton.Name = "cancelBetButton";
			this.cancelBetButton.Size = new System.Drawing.Size(216, 24);
			this.cancelBetButton.TabIndex = 17;
			this.cancelBetButton.Text = "Cancel Selected Bet";
			this.cancelBetButton.Click += new System.EventHandler(this.cancelBetButton_Click);
			// 
			// betIdToCancelLabel
			// 
			this.betIdToCancelLabel.Location = new System.Drawing.Point(288, 552);
			this.betIdToCancelLabel.Name = "betIdToCancelLabel";
			this.betIdToCancelLabel.Size = new System.Drawing.Size(216, 23);
			this.betIdToCancelLabel.TabIndex = 21;
			this.betIdToCancelLabel.Text = "Make selection from any of the bets grids to enable this button";
			this.betIdToCancelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// listOrdersChangedSinceButtonListBootstrapOrders
			// 
			this.listOrdersChangedSinceButtonListBootstrapOrders.BackColor = System.Drawing.Color.MidnightBlue;
			this.listOrdersChangedSinceButtonListBootstrapOrders.Enabled = false;
			this.listOrdersChangedSinceButtonListBootstrapOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.listOrdersChangedSinceButtonListBootstrapOrders.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listOrdersChangedSinceButtonListBootstrapOrders.ForeColor = System.Drawing.Color.White;
			this.listOrdersChangedSinceButtonListBootstrapOrders.Location = new System.Drawing.Point(512, 504);
			this.listOrdersChangedSinceButtonListBootstrapOrders.Name = "listOrdersChangedSinceButtonListBootstrapOrders";
			this.listOrdersChangedSinceButtonListBootstrapOrders.Size = new System.Drawing.Size(216, 24);
			this.listOrdersChangedSinceButtonListBootstrapOrders.TabIndex = 15;
			this.listOrdersChangedSinceButtonListBootstrapOrders.Text = "ListOrdersChangedSince";
			this.listOrdersChangedSinceButtonListBootstrapOrders.Click += new System.EventHandler(this.listOrdersChangedSinceButton_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 272);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(192, 24);
			this.label6.TabIndex = 14;
			this.label6.Text = "Recently changed bets:";
			// 
			// listOrdersChangedSinceGrid
			// 
			this.listOrdersChangedSinceGrid.AllowNavigation = false;
			this.listOrdersChangedSinceGrid.BackgroundColor = System.Drawing.Color.Gray;
			this.listOrdersChangedSinceGrid.CaptionBackColor = System.Drawing.Color.Gray;
			this.listOrdersChangedSinceGrid.DataMember = "";
			this.listOrdersChangedSinceGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listOrdersChangedSinceGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.listOrdersChangedSinceGrid.Location = new System.Drawing.Point(8, 296);
			this.listOrdersChangedSinceGrid.Name = "listOrdersChangedSinceGrid";
			this.listOrdersChangedSinceGrid.ReadOnly = true;
			this.listOrdersChangedSinceGrid.SelectionBackColor = System.Drawing.Color.Black;
			this.listOrdersChangedSinceGrid.Size = new System.Drawing.Size(720, 200);
			this.listOrdersChangedSinceGrid.TabIndex = 13;
			this.listOrdersChangedSinceGrid.TabStop = false;
			this.listOrdersChangedSinceGrid.CurrentCellChanged += new System.EventHandler(this.listOrdersChangedSinceGrid_CurrentCellChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Bet history:";
			// 
			// getBetsButton
			// 
			this.getBetsButton.BackColor = System.Drawing.Color.MidnightBlue;
			this.getBetsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getBetsButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.getBetsButton.ForeColor = System.Drawing.Color.White;
			this.getBetsButton.Location = new System.Drawing.Point(512, 264);
			this.getBetsButton.Name = "getBetsButton";
			this.getBetsButton.Size = new System.Drawing.Size(216, 24);
			this.getBetsButton.TabIndex = 10;
			this.getBetsButton.Text = "ListBootstrapOrders";
			this.getBetsButton.Click += new System.EventHandler(this.getBetsButton_Click);
			// 
			// betsGrid
			// 
			this.betsGrid.AllowNavigation = false;
			this.betsGrid.BackgroundColor = System.Drawing.Color.Gray;
			this.betsGrid.CaptionBackColor = System.Drawing.Color.Gray;
			this.betsGrid.DataMember = "";
			this.betsGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.betsGrid.ForeColor = System.Drawing.Color.Black;
			this.betsGrid.HeaderForeColor = System.Drawing.Color.Black;
			this.betsGrid.Location = new System.Drawing.Point(8, 56);
			this.betsGrid.Name = "betsGrid";
			this.betsGrid.ReadOnly = true;
			this.betsGrid.SelectionBackColor = System.Drawing.Color.Black;
			this.betsGrid.Size = new System.Drawing.Size(720, 200);
			this.betsGrid.TabIndex = 9;
			this.betsGrid.TabStop = false;
			this.betsGrid.CurrentCellChanged += new System.EventHandler(this.betsGrid_CurrentCellChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Single Bets";
			// 
			// page2
			// 
			this.page2.Controls.Add(this.logText);
			this.page2.Controls.Add(this.logLabel);
			this.page2.Location = new System.Drawing.Point(4, 22);
			this.page2.Name = "page2";
			this.page2.Size = new System.Drawing.Size(736, 684);
			this.page2.TabIndex = 1;
			this.page2.Text = "Log";
			// 
			// logText
			// 
			this.logText.BackColor = System.Drawing.SystemColors.Control;
			this.logText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.logText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.logText.ImeMode = System.Windows.Forms.ImeMode.Katakana;
			this.logText.Location = new System.Drawing.Point(8, 32);
			this.logText.Multiline = true;
			this.logText.Name = "logText";
			this.logText.ReadOnly = true;
			this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.logText.Size = new System.Drawing.Size(720, 632);
			this.logText.TabIndex = 11;
			this.logText.Text = "";
			this.logText.WordWrap = false;
			// 
			// logLabel
			// 
			this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.logLabel.Location = new System.Drawing.Point(8, 8);
			this.logLabel.Name = "logLabel";
			this.logLabel.TabIndex = 8;
			this.logLabel.Text = "Log:";
			// 
			// getPricesButton
			// 
			this.getPricesButton.Location = new System.Drawing.Point(0, 0);
			this.getPricesButton.Name = "getPricesButton";
			this.getPricesButton.TabIndex = 0;
			// 
			// GBE_Form
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(744, 726);
			this.Controls.Add(this.tabs);
			this.Controls.Add(this.statusBar);
			this.Name = "GBE_Form";
			this.Text = "Global Betting Exchange";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.page1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.selectionsGrid)).EndInit();
			this.page3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.listOrdersChangedSinceGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.betsGrid)).EndInit();
			this.page2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		#endregion


		private SecureServiceAgent _secureAgent = null;
		private ReadonlyServiceAgent _readonlyAgent = null;
		private LogUtility _logWriter = null;
		private long _maxSequenceNo;
		private Market _currentMarket = null;


		public GBE_Form()
		{
			InitializeComponent();


			SetupServiceAgents();
			_logWriter = new LogUtility(logText, statusBar);
		}


		private void connectButton_Click(object sender, System.EventArgs e)
		{
			// Needed to add this in case the connection details are changed so old 
			//  connection can be dropped and a new connection using new details created.


			SetupServiceAgents();


			// Just to test if working.
			getDetailsButton_Click(null, null);						
		}


		private void SetupServiceAgents()
		{
			_secureAgent = new SecureServiceAgent(baseUrlText.Text + secureUrlText.Text
				, usernameText.Text, passwordText.Text);

			_readonlyAgent = new ReadonlyServiceAgent(baseUrlText.Text + readonlyUrlText.Text
				, usernameText.Text);
		}


		#region Page one

		/// <summary>
		/// Handles getting the account summary for the specified user.
		/// </summary>
		private void getDetailsButton_Click(object sender, System.EventArgs e)
		{
			const string API_NAME = "GetAccountBalances";
			_logWriter.BeginCall(API_NAME);


			try
			{
				AccountBalances balances = _secureAgent.GetAccountBalances();

				currencyText.Text = balances.Currency;
				balanceText.Text = String.Format("{0:$#,##0.00;($#,##0.00);Zero}", balances.Balance);
				availableFundsText.Text = String.Format("{0:$#,##0.00;($#,##0.00);Zero}", balances.AvailableFunds);
				exposureText.Text = String.Format("{0:$#,##0.00;($#,##0.00);Zero}", balances.Exposure);
				creditText.Text = String.Format("{0:$#,##0.00;($#,##0.00);Zero}", balances.Credit);


				_logWriter.EndCall(API_NAME);
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
			}
		}


		/// <summary>
		/// Handles when user presses the Get Top Level Events button.
		/// </summary>
		private void getEventsButton_Click(object sender, System.EventArgs e)
		{
			const string API_NAME = "GetTopLevelEvents";
			_logWriter.BeginCall(API_NAME);


			// Prepare tree for the adding of nodes.
			eventsTreeView.Nodes.Clear();
			eventsTreeView.Nodes.Add("Events");


			// Try to call the web service to get the top level events.
			Event[] topLevelEvents = null;
			try
			{
				topLevelEvents = _readonlyAgent.GetTopLevelEvents();

				// For each top level event add a new node to the tree.
				for (int i = 0; i < topLevelEvents.Length; i++)
				{
					TreeNode topLevelEventNode = new TreeNode(topLevelEvents[i].Name);
					topLevelEventNode.Tag = topLevelEvents[i].EventId;

					// Need to add a dummy node to get the little plus symbol.
					topLevelEventNode.Nodes.Add("xxx");

					eventsTreeView.Nodes[0].Nodes.Add(topLevelEventNode);
				}


				_logWriter.EndCall(API_NAME);
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message) ;
			}
		}


		/// <summary>
		/// Handles when user clicks plus icon in tree to expand node.
		/// </summary>
		private void eventsTreeView_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{			
			// Must already have populated all nodes coming off the root otherwise tree would be empty, 
			//  so don't need to do anything here except allow the expansion to occur.
			if (e.Node.Text == "Events")
				return;


			// If dummy node is not present then must have already done the expansion previously,
			//  so don't need to call web service again, just allow the expansion to occur.
			if (e.Node.Nodes[0].Text != "xxx")
				return;
			else
				// Else, first time expanded, so remove dummy node and continue.
				eventsTreeView.Nodes.Remove(e.Node.Nodes[0]);


			const string API_NAME = "GetEventSubTreeNoSelections";
			_logWriter.BeginCall(API_NAME);


			// Do the actual web service call.
			// Get the branch of sub-events and markets for this event.
			// No way to get only one layer at a time, 
			//  instead have to get full tree of sub-events and markets
			//  for this root event, regardless of how many layers that may be.
			// Means the first time the node is expanded will take awhile,
			//  but each subsequent time that node is expanded will be very quick.
			Event eventTree = null;
			DisplayIdsOrNames(e.Node.Tag.ToString(), e.Node.Text, null, null, null, null);

			try
			{
				eventTree = _readonlyAgent.GetEventSubTreeNoSelections((long) e.Node.Tag);
				
				// Start of recursive procedure to add sub-event and markets.
				if (eventTree.Events != null
					|| eventTree.Markets != null)
					AddEventsAndMarketsToThisNode(e.Node, eventTree);

 
				_logWriter.EndCall(API_NAME);
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
			}
		}


		/// <summary>
		/// Handles when user makes selection from tree, either an event or market.
		/// </summary>
		private void eventsTreeView_BeforeSelect(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{
			ClearIdsOrNames();


			// If not market node selected then just display event name (id) and exit.
			if (e.Node.Text.Length < 6 || e.Node.Text.IndexOf("Market", 0, 6) < 0)
			{
				this.getPricesButton1.Enabled = false;
				if (e.Node.Tag != null)
					DisplayIdsOrNames(e.Node.Tag.ToString(), e.Node.Text, null, null, null, null);
				return;
			}
			else // Else is market, so display market name (id) and continue on to get selections and prices.
			{
				if (e.Node.Tag != null)
				{
					DisplayIdsOrNames(e.Node.Parent.Tag.ToString(), e.Node.Parent.Text
						, e.Node.Tag.ToString(), e.Node.Text.Substring(8)
						, null, null);
					this.getPricesButton1.Enabled = true;
				}
			}


			const string API_NAME = "GetPrices";
			_logWriter.BeginCall(API_NAME);


			try
			{
                selectedMarketId = (long)e.Node.Tag;
				_currentMarket = _readonlyAgent.GetPrices((long) e.Node.Tag);
				if (_currentMarket.Selections != null)
					selectionsGrid.DataSource = DataTableCreator.CreateAndPopulateSelectionsTable(_currentMarket.Selections); 


				_logWriter.EndCall(API_NAME+" marketStatus: "+_currentMarket.MarketStatus);
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
			}
		}

		
		/// <summary>
		/// When user makes selection from the selection grid then need to update text boxes.
		/// </summary>
		private void selectionsGrid_CurrentCellChanged(object sender, System.EventArgs e)
		{
			int selectedRow = selectionsGrid.CurrentRowIndex;
			selectionsGrid.Select(selectedRow);


			DataTable selectionsData = selectionsGrid.DataSource as DataTable;
			long selectionId = long.Parse(selectionsData.Rows[selectedRow]["Id"].ToString());
			

			foreach(Selection sel in _currentMarket.Selections)
			{
				if (selectionId == sel.Id)
				{
					DisplayIdsOrNames(null, null, _currentMarket.MarketId.ToString(), _currentMarket.Name
						, sel.Id.ToString(), sel.Name);
					resetCountText.Text = sel.ResetCount.ToString();
				}
			}
		}


		/// <summary>
		/// Handles the checkbox which switches from displaying names to ids.
		/// </summary>
		private void displayIdsCheck_CheckedChanged(object sender, System.EventArgs e)
		{
			// Just do basic swap.


			string string1 = eventIdText.Text as string;
			string string2 = eventIdText.Tag as string;

			if (string1 != null && string2 != null)
			{
				eventIdText.Text = string2;
				eventIdText.Tag = string1;
			}


			string1 = marketIdText.Text as string;
			string2 = marketIdText.Tag as string;

			if (string1 != null && string2 != null)
			{
				marketIdText.Text = string2;
				marketIdText.Tag = string1;
			}


			string1 = selectionIdText.Text as string;
			string2 = selectionIdText.Tag as string;

			if (string1 != null && string2 != null)
			{
				selectionIdText.Text = string2;
				selectionIdText.Tag = string1;
			}
		}


		/// <summary>
		/// This seems to be the easiest way to enable/disable button for adding bets,
		///  if this text box is empty then not allowed to add bet to bets list.
		/// </summary>
		private void selectionIdText_TextChanged(object sender, System.EventArgs e)
		{
			if (selectionIdText.Text == "")
				addBetButton.Enabled = false;
			else
				addBetButton.Enabled = true;
		}


		/// <summary>
		/// Handles the button for adding single bets to the bets listbox.
		/// </summary>
		private void addBetButton_Click(object sender, System.EventArgs e)
		{
			placeBetsButton.Enabled = true;


			DataTable betsToPlaceTable = AddNewSelectionToBetsToPlaceTable();


			// Text to display in the listbox.
			int lastRow = betsToPlaceTable.Rows.Count - 1;
			string selectionName = betsToPlaceTable.Rows[lastRow]["Selection Name"].ToString();
			string amount = betsToPlaceTable.Rows[lastRow]["Amount"].ToString();
			string odds = betsToPlaceTable.Rows[lastRow]["Odds"].ToString();
			byte polarityIndex = byte.Parse(betsToPlaceTable.Rows[lastRow]["Polarity"].ToString());
			string polarity = polarityIndex == 1 ? "Back" : "Lay";
			betsToPlaceList.Items.Add(string.Format("{3} {0} ({1} at {2})"
				, selectionName, amount, odds, polarity));
		}

		
		/// <summary>
		/// Handles the button for clearing list of bets to place.
		/// </summary>
		private void clearListButton_Click(object sender, System.EventArgs e)
		{
			// Clear the list of bets to be placed,
			//  and enable both addBetButton and addMultipleBetButton.
		

			betsToPlaceList.Items.Clear();
			betsToPlaceList.Tag = null;

			placeBetsButton.Enabled = false;
		}


		/// <summary>
		/// Handles when user presses the button to place bet.
		/// </summary>
		private void placeBetsButton_Click(object sender, System.EventArgs e)
		{
			const string API_NAME = "PlaceOrdersNoReceipt";
			DataTable betsToPlaceTable = betsToPlaceList.Tag as DataTable;
			long[] placedBetsIds = null;

			try
			{
				_logWriter.BeginCall(API_NAME);
				bool allOrNothing = allOrNotingCheckBox.Checked;

				//We call PlaceOrdersNoReceipt with allOrNothing parameters that tell us if we want to place or or none if we get a non success return code,
				//and market current withdrawSequenceNumber that needs to match with the expectedWithrdawSequenceNumber in the order request
				placedBetsIds = _secureAgent.PlaceOrdersNoReceipt(betsToPlaceTable, allOrNothing, (byte)_currentMarket.WithdrawalSeqNo);


				// Clear the old bet ids and add the new ones.
				betIdsList.Items.Clear();
				foreach (long betId in placedBetsIds)
					betIdsList.Items.Add(betId.ToString());
				

				clearListButton_Click(null, null);
				cancelBetPage1Button.Enabled = true;
				
				
				//Code used to write all placed bets in the log tab
				string bets = "[ ";
				foreach(long placedBetsId in placedBetsIds)
				{
					bets += placedBetsId.ToString() + " ";
				}
				bets += "]";
				_logWriter.EndCall(API_NAME + "( Bets: " + bets + ")");
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
			}
		}


		/// <summary>
		/// Handles the cancel bets button on the first page.
		/// </summary>
		private void cancelBetPage1Button_Click(object sender, System.EventArgs e)
		{
			if (betIdsList.SelectedItems.Count == 0)
				return;


			const string API_NAME = "CancelOrders";
			_logWriter.BeginCall(API_NAME);


			try
			{
				long[] betIdsToCancel = new long[betIdsList.SelectedItems.Count];
				for (int i = 0 ; i < betIdsList.SelectedItems.Count ; i++)
					betIdsToCancel[i] = long.Parse(betIdsList.SelectedItems[i].ToString());


				_secureAgent.CancelOrders(betIdsToCancel);


				// Move backwards through the list box contents, 
				//  if it was one of the cancelled bets then remove from the list box.
				for (int i = betIdsList.Items.Count - 1 ; i >= 0 ; i--)
					if (DoesArrayHaveThisValue(betIdsToCancel, long.Parse(betIdsList.Items[i].ToString())))
						betIdsList.Items.RemoveAt(i);


				_logWriter.EndCall(API_NAME);
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
			}


			betIdsList.SelectedIndex = -1;
		}


		/// <summary>
		/// No longer used, but left in case want to add a button for cancelling all bets later.
		/// </summary>
		private void cancelBetButtonNotUsed_Click(object sender, System.EventArgs e)
		{
			// Remember that there is also a cancel all for market version as well.


			const string API_NAME = "CancelAllOrders";
			_logWriter.BeginCall(API_NAME);


			try
			{
				_secureAgent.CancelAllOrders();


				_logWriter.EndCall(API_NAME);
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message) ;
			}
		}

		#endregion


		#region My Bets page

		/// <summary>
		/// Handles when user presses the ListBootstrapOrders button.
		/// </summary>
		private void getBetsButton_Click(object sender, System.EventArgs e)
		{
			string API_NAME = "ListBootstrapOrders";
			_logWriter.BeginCall(API_NAME);


			Bet[] bootstrapBets = null;
			try
			{
				// Storing in _maxSequenceNo member variable so that next time ListOrdersChangedSince
				//  button is pressed it can start from this position.
				bootstrapBets = _secureAgent.ListBootstrapOrders(out _maxSequenceNo);


				_logWriter.EndCall(API_NAME);
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
				return;
			}


			API_NAME = "ListOrdersChangedSince";
			_logWriter.BeginCall(API_NAME);

			try
			{
				// To be sure that you've got all bets need to call ListOrdersChangedSince once
				//  after the ListBootstrapOrders cycle, just in case bets have changed since starting.
				// Combining ListBootstrapOrders bets with ListOrdersChangedSince bets here.
				Bet[] listOrdersBets = _secureAgent.ListOrdersChangedSince(_maxSequenceNo);
				Bet[] fullListOfBets = OrderConverter.CombineTwoBetArrays(bootstrapBets, listOrdersBets);
				betsGrid.DataSource = DataTableCreator.CreateAndPopulateBetsTable(fullListOfBets); 


				_logWriter.EndCall(API_NAME);
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
				return;
			}


			// Now that we've called ListBootstrapOrders we are allowed to call ListOrdersChangedSince.
			listOrdersChangedSinceButtonListBootstrapOrders.Enabled = true;
		}


		private void listOrdersChangedSinceButton_Click(object sender, System.EventArgs e)
		{
			const string API_NAME = "ListOrdersChangedSince";
			_logWriter.BeginCall(API_NAME);


			Bet[] listOrdersBets = null;
			try
			{
				// Get any orders that may have changed since last call
				//  to ListOrdersChangedSince or ListBootstrapOrders.
				listOrdersBets = _secureAgent.ListOrdersChangedSince(_maxSequenceNo);

				
				_logWriter.EndCall(API_NAME);


				if (listOrdersBets == null)
					return;
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
				return;
			}


			// Add any new orders to the orders already held in the datagrid.
			DataTable betsTable = listOrdersChangedSinceGrid.DataSource as DataTable;

			if (betsTable == null)
				// If the datagrid was empty then need to create a new table of data.
				betsTable = DataTableCreator.CreateAndPopulateBetsTable(listOrdersBets);
			else
				// Else, if it wasn't empty add the new data to the existing table of data.
				// This approach to displaying the bets needs to be improved,
				//  currently will list the same bet twice if it changes state,
				//  should really search the table of previously retrieved bets
				//  to see if current bet is there, is so replace with new version.
				DataTableCreator.PopulateBetsTable(listOrdersBets, betsTable); 

			listOrdersChangedSinceGrid.DataSource = betsTable;


			_maxSequenceNo = OrderConverter.GetMaxSequenceNoFromListOfBets(listOrdersBets);
		}

		
		private void betsGrid_CurrentCellChanged(object sender, System.EventArgs e)
		{
			// Get the bet id for the row selected.
			// Because the user may sort by any of the columns its not as straight forward
			//  as might like, instead need to use this CurrencyManager object.


			DataGrid betsGrid = sender as DataGrid;
			DataTable betsData = betsGrid.DataSource as DataTable;
			CurrencyManager man = (CurrencyManager) betsGrid.BindingContext[betsData]; 
			DataRowView currentRowView = (DataRowView) man.Current;


			betIdToCancelLabel.Text = currentRowView.Row[0].ToString();
			cancelBetButton.Enabled = true;
		}

		
		private void listOrdersChangedSinceGrid_CurrentCellChanged(object sender, System.EventArgs e)
		{
			// Get the bet id for the row selected.
			// Because the user may sort by any of the columns its not as straight forward
			//  as might like, instead need to use this CurrencyManager object.


			DataGrid betsGrid = sender as DataGrid;
			DataTable betsData = betsGrid.DataSource as DataTable;
			CurrencyManager man = (CurrencyManager)betsGrid.BindingContext[betsData]; 
			DataRowView currentRowView = (DataRowView) man.Current;


			betIdToCancelLabel.Text = currentRowView.Row[0].ToString();
			cancelBetButton.Enabled = true;
		}

		
		/// <summary>
		/// Handles the cancel bets button on the second page. When user makes selection from the grid.
		/// </summary>
		private void cancelBetButton_Click(object sender, System.EventArgs e)
		{
			// If a selection has been made from one of the bet grids
			//  then the betIdToCancelLabel label will contain the id
			//  and so we're allowed to try cancelling the bet.


			if (betIdToCancelLabel.Text == "")
				return;


			const string API_NAME = "CancelOrders";
			_logWriter.BeginCall(API_NAME);


			try
			{
				long betIdToCancel = int.Parse(betIdToCancelLabel.Text);
				
				_secureAgent.CancelOrders(new long[] {betIdToCancel});
				
				//Write the API call with the bet specified in the log tab
				_logWriter.EndCall(API_NAME + "( Bet: " + betIdToCancel.ToString()+")");
			}
			catch (Exception ex)
			{
				_logWriter.FailCall(API_NAME, ex.Message);
				return;
			}
		}

		#endregion


		#region Helper methods

		private void ClearIdsOrNames()
		{
			// Do this when selecting a new event or market, as don't want to have
			//  details lingering from old market or event.


			eventIdText.Text = "";
			eventIdText.Tag = null;

			marketIdText.Text = "";
			marketIdText.Tag = null;

			selectionIdText.Text = "";
			selectionIdText.Tag = null;

			resetCountText.Text = "";
		}


		private void DisplayIdsOrNames(string eventId, string eventName, string marketId, string marketName
			, string selectionId, string selectionName)
		{
			// All the params are in pairs, and each pair is optional, as may just want to display event info
			//  for example, however if do pass an id param then must also set the corresponding name param.
			// By setting displayIdsCheck to known state at beginning (and returning state at end) 
			//  then we don't need extra if statements to check state and display differently.


			bool currentCheckedState = displayIdsCheck.Checked;
			displayIdsCheck.Checked = true;


			if (eventId != null && eventName != null)
			{
				eventIdText.Text = eventId;
				eventIdText.Tag = eventName;
			}

			if (marketId != null && marketName != null)
			{
				marketIdText.Text = marketId;
				marketIdText.Tag = marketName;
			}
			
			if (selectionId != null && selectionName != null)
			{
				selectionIdText.Text = selectionId;
				selectionIdText.Tag = selectionName;
			}


			// Now restore checkbox to the state it was in at beginning of method,
			//  this may trigger the control's event to toggle the display as appropriate.
			displayIdsCheck.Checked = currentCheckedState;
		}


		private DataTable AddNewSelectionToBetsToPlaceTable()
		{
			// Info about all bets ready to be placed is stored in a DataTable which 
			//  is persisted using the Tag property of the betsToPlaceList listbox.
			// To add a new bet to this list we simply grab the info from the relevant textboxes,
			//  fetch the DataTable from the Tag property of the betsToPlaceList listbox, 
			//  or create a new DataTable using the DataTableCreator utility class if first bet added,
			//  then use the DataTableCreator utility class again to add a new entry to the DataTable.


			// Get data about current selection.
			long selectionId;
			string selectionName;
			byte polarity = (byte) (backOption.Checked ? 1 : 2);
			if (displayIdsCheck.Checked)
			{
				selectionId = long.Parse(selectionIdText.Text);
				selectionName = selectionIdText.Tag as string;
			}
			else
			{
				selectionId = long.Parse(selectionIdText.Tag as string);
				selectionName = selectionIdText.Text;
			}


			// Try to get the DataTable previously created, or create a new DataTable if first time.
			DataTable betsToPlaceTable = betsToPlaceList.Tag as DataTable;
			if (betsToPlaceTable == null)
				betsToPlaceTable = DataTableCreator.CreateBetsToPlaceTable();


			// Add current bet to the table of bets to be placed, and store in the Tag.
			DataTableCreator.AddToBetsToPlaceTable(selectionId
				, polarity, decimal.Parse(amountText.Text)
				, decimal.Parse(oddsText.Text), byte.Parse(resetCountText.Text)
				, selectionName, betsToPlaceTable);
			betsToPlaceList.Tag = betsToPlaceTable;


			return betsToPlaceTable;
		}


		private void AddEventsAndMarketsToThisNode(TreeNode nodeToAddTo, Event eventToExpand)
		{
			// Node text determined by:
			//  if event just display event name,
			//  if market include the string "Market: " before market name.


			// If there are any sub-events then add those.
			if (eventToExpand.Events != null)
				for (int i = 0; i < eventToExpand.Events.Length ; i++)
				{
					// Create a new sub-event node.
					TreeNode newEventNode = new TreeNode(eventToExpand.Events[i].Name);
					newEventNode.Tag = eventToExpand.Events[i].EventId;
					

					// Recursively add any sub-sub-events to our new sub-event.
					AddEventsAndMarketsToThisNode(newEventNode, eventToExpand.Events[i]);


					// Finally, add our new sub-event node to the original node.
					nodeToAddTo.Nodes.Add(newEventNode);
				}


			// If there are any markets off our event node in question then add those.
			if (eventToExpand.Markets != null)
				for (int i = 0; i < eventToExpand.Markets.Length ; i++)
				{
					TreeNode newMarketNode = new TreeNode("Market: " + eventToExpand.Markets[i].Name);
					newMarketNode.Tag = eventToExpand.Markets[i].MarketId;
					nodeToAddTo.Nodes.Add(newMarketNode);
				}
		}

		
		private bool DoesArrayHaveThisValue(long[] arrayOfValues, long valueToFind)
		{
			for (int i = 0 ; i < arrayOfValues.Length ; i++)
				if (arrayOfValues[i] == valueToFind)
					return true;

			return false;
		}

		#endregion

		private void getPricesButton1_Click(object sender, System.EventArgs e)
		{			
				const string API_NAME = "GetPrices";
				_logWriter.BeginCall(API_NAME);


				try
				{
					_currentMarket = _readonlyAgent.GetPrices(selectedMarketId);
					if (_currentMarket.Selections != null)
						selectionsGrid.DataSource = DataTableCreator.CreateAndPopulateSelectionsTable(_currentMarket.Selections); 


					_logWriter.EndCall(API_NAME+" marketStatus: "+_currentMarket.MarketStatus);
				}
				catch (Exception ex)
				{
					_logWriter.FailCall(API_NAME, ex.Message);
				}

		}

    
		}

		

		
	}

