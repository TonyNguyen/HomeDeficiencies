using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Deficiencies
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private DataGridPrinter dataGridPrinter1 = null;
		private static int numModifiedRows = 0;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
//			oleDbDataAdapter1.Fill( dataSet1, "DListTable");
			DisplayGrid();
			this.dataGrid1.SetDataBinding( dataSet1, "DListTable");
			dataGridLayout();
			SetupGridPrinter();
			welcomeMessage();
		}

		public void DisplayGrid()
		{


			this.oleDbDataAdapter1.Fill(this.dataSet1, "DListTable");


		}

		public void SetupGridPrinter()
		{
			dataGridPrinter1 = new DataGridPrinter(dataGrid1, printDocument1, this.dataSet1.Tables["DListTable"]);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dataSet1 = new System.Data.DataSet();
			this.label2 = new System.Windows.Forms.Label();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem6,
																					  this.menuItem13});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem16,
																					  this.menuItem5,
																					  this.menuItem4});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuItem2.Text = "&Save to File";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.menuItem3.Text = "&Print...";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 2;
			this.menuItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.menuItem16.Text = "Print Pre&view...";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 4;
			this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
			this.menuItem4.Text = "&Exit";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10,
																					  this.menuItem12,
																					  this.menuItem11});
			this.menuItem6.Text = "Tools";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
			this.menuItem7.Text = "&Delete";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.menuItem8.Text = "&Find";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
			this.menuItem9.Text = "&Insert";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
			this.menuItem10.Text = "&Update";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 4;
			this.menuItem12.Text = "-";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 5;
			this.menuItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.menuItem11.Text = "&Refresh/Cancel";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem14,
																					   this.menuItem15});
			this.menuItem13.Text = "Help";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItem14.Text = "&Contents";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 1;
			this.menuItem15.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.menuItem15.Text = "&About";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 40);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(872, 512);
			this.dataGrid1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label1});
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
			this.groupBox1.Location = new System.Drawing.Point(8, 560);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(872, 64);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Assistant :";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(832, 32);
			this.label1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button9,
																					this.button8,
																					this.button7,
																					this.button6,
																					this.button5,
																					this.button4,
																					this.button3,
																					this.button2,
																					this.button1});
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
			this.groupBox2.Location = new System.Drawing.Point(8, 624);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(872, 56);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Command Buttons";
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.LightGray;
			this.button9.Location = new System.Drawing.Point(808, 24);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(56, 23);
			this.button9.TabIndex = 8;
			this.button9.Text = "Exit";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			this.button9.MouseHover += new System.EventHandler(this.exitMouseHover);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.LightGray;
			this.button8.Location = new System.Drawing.Point(688, 24);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(104, 23);
			this.button8.TabIndex = 7;
			this.button8.Text = "Print Preview";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			this.button8.MouseHover += new System.EventHandler(this.printPreviewMouseHover);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.LightGray;
			this.button7.Location = new System.Drawing.Point(600, 24);
			this.button7.Name = "button7";
			this.button7.TabIndex = 6;
			this.button7.Text = "Print";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			this.button7.MouseHover += new System.EventHandler(this.printMouseHover);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.LightGray;
			this.button6.Location = new System.Drawing.Point(480, 24);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(104, 23);
			this.button6.TabIndex = 5;
			this.button6.Text = "Save to File";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			this.button6.MouseHover += new System.EventHandler(this.saveToFileMouseHover);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LightGray;
			this.button5.Location = new System.Drawing.Point(344, 24);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(120, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Cancel/Refresh";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			this.button5.MouseHover += new System.EventHandler(this.refreshMouseHover);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightGray;
			this.button4.Location = new System.Drawing.Point(248, 24);
			this.button4.Name = "button4";
			this.button4.TabIndex = 3;
			this.button4.Text = "Update";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			this.button4.MouseHover += new System.EventHandler(this.updateMouseHover);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightGray;
			this.button3.Location = new System.Drawing.Point(168, 24);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Insert";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			this.button3.MouseHover += new System.EventHandler(this.insertMouseHover);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightGray;
			this.button2.Location = new System.Drawing.Point(88, 24);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(64, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Find";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			this.button2.MouseHover += new System.EventHandler(this.findMouseHover);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightGray;
			this.button1.Location = new System.Drawing.Point(8, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Delete";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.MouseHover += new System.EventHandler(this.deleteMouseHover);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=DeficienciesDB.mdb;Mode=ReadWrite|Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "DListTable", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("Blding", "Blding"),
																																																					  new System.Data.Common.DataColumnMapping("Unit #", "Unit #"),
																																																					  new System.Data.Common.DataColumnMapping("Room", "Room"),
																																																					  new System.Data.Common.DataColumnMapping("Description", "Description"),
																																																					  new System.Data.Common.DataColumnMapping("Trade", "Trade"),
																																																					  new System.Data.Common.DataColumnMapping("Status", "Status")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM DListTable WHERE (Bld = ?) AND ([Desc] = ?) AND (Room = ?) AND (Unit_" +
				"Num = ?) AND (Status = ?) AND (Trade = ?)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Bld", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Blding", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Desc", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Room", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Room", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unit_Num", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unit #", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Status", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Trade", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Trade", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO DListTable(Bld, Unit_Num, Room, [Desc], Trade, Status) VALUES (?, ?, " +
				"?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Bld", System.Data.OleDb.OleDbType.VarWChar, 50, "Blding"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Unit_Num", System.Data.OleDb.OleDbType.VarWChar, 10, "Unit #"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Room", System.Data.OleDb.OleDbType.VarWChar, 50, "Room"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Desc", System.Data.OleDb.OleDbType.VarWChar, 255, "Description"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Trade", System.Data.OleDb.OleDbType.VarWChar, 50, "Trade"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 2, "Status"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Bld AS Blding, Unit_Num AS [Unit #], Room, [Desc] AS Description, Trade, S" +
				"tatus FROM DListTable WHERE Trade = \'0\'";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE DListTable SET Bld = ?, Unit_Num = ?, Room = ?, [Desc] = ?, Trade = ?, Sta" +
				"tus = ? WHERE (Bld = ?) AND ([Desc] = ?) AND (Room = ?) AND (Unit_Num = ?) AND (" +
				"Status = ?) AND (Trade = ?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Bld", System.Data.OleDb.OleDbType.VarWChar, 50, "Blding"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Unit_Num", System.Data.OleDb.OleDbType.VarWChar, 10, "Unit #"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Room", System.Data.OleDb.OleDbType.VarWChar, 50, "Room"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Desc", System.Data.OleDb.OleDbType.VarWChar, 255, "Description"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Trade", System.Data.OleDb.OleDbType.VarWChar, 50, "Trade"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 2, "Status"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Bld", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Blding", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Desc", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Room", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Room", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Unit_Num", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Unit #", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Status", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Trade", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Trade", System.Data.DataRowVersion.Original, null));
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(864, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Home Deficiencies";
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(44, 58);
			this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Opacity = 1;
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(892, 681);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.groupBox2,
																		  this.groupBox1,
																		  this.dataGrid1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Deficiencies Manager";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		// show contents menu
		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			Form3 oForm3 = new Form3();

			oForm3.MyParentForm = this;
			
			// Capture inputs from Form3 when user clicks OK
			if (oForm3.ShowDialog() == DialogResult.OK){}

		}

		// find button
		private void button2_Click(object sender, System.EventArgs e)
		{
			// Open Form2
			Form2 oForm2 = new Form2();
			ArrayList tArr = new ArrayList ();
			string tStr = "";
			string headerStr = "Home Deficiencies ";
			int numOfWhereInputValue = 0;

			oForm2.MyParentForm = this;
			
			// Capture inputs from Form2 when user clicks OK
			if (oForm2.ShowDialog() == DialogResult.OK)
			{
				tArr = oForm2.textBoxFilter();
			}
			else 
			{
				tStr = " WHERE Trade = \'`\'";
			}

			numOfWhereInputValue = tArr.Count; 

			// add for to the header string and build where part
			if (numOfWhereInputValue > 0)
			{
				headerStr += "for ";
				tStr = " WHERE " + tArr[0].ToString() + "'" + tArr[1].ToString() + "' ";
			}

			// build header string
			for ( int i = 0; i < numOfWhereInputValue; i = i + 2)
			{
				if ( i < (numOfWhereInputValue - 2) )
				{
					if ( !tArr[i].ToString().Equals("Desc LIKE "))
					{
						headerStr = headerStr + tArr[i].ToString() + tArr[i+1].ToString() + " and ";
					}
					else
					{
						headerStr = headerStr + "Desc = " + tArr[i+1].ToString().Substring(1, (tArr[i+1].ToString().Length -2)) + " and ";
					}
				}
				else
				{
					if ( !tArr[i].ToString().Equals("Desc LIKE "))
					{
						headerStr = headerStr + tArr[i].ToString() + tArr[i+1].ToString();
					}
					else
					{
						headerStr = headerStr + "Desc = " + tArr[i+1].ToString().Substring(1, (tArr[i+1].ToString().Length -2));
					}
				}
			}
			
			// build where part
			for ( int i = 2; i < tArr.Count; i = i + 2)
			{
				tStr = tStr + "AND " + tArr[i].ToString() + "'" + tArr[i+1].ToString() + "' ";
			}
			
			label2.Text = headerStr;
			
			this.oleDbSelectCommand1.CommandText = "SELECT Bld AS Blding, Unit_Num AS [Unit #], Room, [Desc] AS Description, Trade, S" +
				"tatus FROM DListTable" + tStr;
//			this.oleDbSelectCommand1.CommandText = this.oleDbSelectCommand1.CommandText  + tStr;
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			fnRefresh();

		}

		private void dataGridLayout()
		{
			DataGridTableStyle ts1 = new DataGridTableStyle();
			ts1.MappingName = "DListTable";

			DataGridTextBoxColumn TextCol1 = new DataGridTextBoxColumn();
			TextCol1.MappingName = "Blding";
			TextCol1.HeaderText = "Blding"; // use the alias name
			TextCol1.Width = 50;
			ts1.GridColumnStyles.Add(TextCol1);

			DataGridTextBoxColumn TextCol2 = new DataGridTextBoxColumn();
			TextCol2.MappingName = "Unit #";
			TextCol2.HeaderText = "Unit #";
			TextCol2.Width = 50;
			ts1.GridColumnStyles.Add(TextCol2);

			DataGridTextBoxColumn TextCol3 = new DataGridTextBoxColumn();
			TextCol3.MappingName = "Room";
			TextCol3.HeaderText = "Room";
			TextCol3.Width = 100;
			ts1.GridColumnStyles.Add(TextCol3);

			DataGridTextBoxColumn TextCol4 = new DataGridTextBoxColumn();
			TextCol4.MappingName = "Description";
			TextCol4.HeaderText = "Description";
			TextCol4.Width = 460;
			ts1.GridColumnStyles.Add(TextCol4);

			DataGridTextBoxColumn TextCol5 = new DataGridTextBoxColumn();
			TextCol5.MappingName = "Trade";
			TextCol5.HeaderText = "Trade";
			TextCol5.Width = 100;
			ts1.GridColumnStyles.Add(TextCol5);

			DataGridTextBoxColumn TextCol6 = new DataGridTextBoxColumn();
			TextCol6.MappingName = "Status";
			TextCol6.HeaderText = "Status";
			TextCol6.Width = 40;
			ts1.GridColumnStyles.Add(TextCol6);

			dataGrid1.TableStyles.Add(ts1); 

		}

		private void fnRefresh()
		{

//			dataGridLayout();
			this.dataSet1.Clear(); 
			this.oleDbDataAdapter1.Fill(this.dataSet1,"DListTable");

//			this.dataGrid1.SetDataBinding( dataSet1, "DListTable");
			this.dataGrid1.DataSource=this.dataSet1.Tables["DListTable"].DefaultView;
//			dataGrid1.TableStyles["DListTable"].GridColumnStyles["Desc"].Width = 120;			
		}

		// refresh button
		private void button5_Click(object sender, System.EventArgs e)
		{
			fnRefresh();
//			button3.Enabled = true;  // enable insert button
		}

		// insert button
		private void button3_Click(object sender, System.EventArgs e)
		{

//			this.button3.Enabled = false; // disable insert button
			label1.Text = "Enter your new record(s) at the end of the Table and click 'Update' button";
//			DataTable myTable = (DataTable) this.dataSet1.Tables["DListTable"];

			// Check to see if the dataset have been changed.  If changed, update it.
			if ( this.dataSet1.Tables["DListTable"].Rows.Count > 0 )
			{
				checkIfTableChange(false);
				insertButtonHelper();//sender, e);
			}
		}

		private void checkIfTableChange(bool messageOn)
		{
			try 
			{ 
				// to tell the datagrid that you have finished editting 
				foreach ( DataGridColumnStyle cs in this.dataGrid1.TableStyles["DListTable"].GridColumnStyles)
				{
					dataGrid1.TableStyles["DListTable"].EndEdit(cs, this.dataGrid1.CurrentCell.RowNumber, false);
				}

				int rowIndex = this.dataGrid1.CurrentRowIndex;
				this.dataGrid1.CurrentRowIndex = 0;
				this.dataGrid1.CurrentRowIndex = rowIndex;
				
				//put the modified DataSet into a new DataSet(myChangedDataset) 
				DataSet myChangedDataset = this.dataSet1.GetChanges(); 
				if (myChangedDataset != null ) 
				{ 
					// get how many rows changed 
					// int modifiedRows = this.oleDbDataAdapter1.Update(myChangedDataset);
					numModifiedRows += this.oleDbDataAdapter1.Update(myChangedDataset);
					if (messageOn)
					{
						MessageBox.Show("Database has been updated successfully: " + 
							numModifiedRows + " Modified row(s) ", "Success");

					}
					this.dataSet1.AcceptChanges(); //accept the all changes 
				}
				else
				{
					if (messageOn)
					{
						MessageBox.Show("Nothing to save", "No changes"); 
					}
				}
			} 
			catch(Exception ex) 
			{ 
				//if something somehow went wrong 
				MessageBox.Show("An error occurred updating the database: " + 
					ex.Message, "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error); 
				this.dataSet1.RejectChanges(); //cancel the changes 
			}//try-catch 
		}
		
		private void insertButtonHelper()//object sender, System.EventArgs e)
		{
			DataRow myRow = this.dataSet1.Tables["DListTable"].NewRow();

			if ( this.dataSet1.Tables["DListTable"].Rows.Count > 0)
			{
				//keep in mind the previous clicked row to unselect
				//				int iPrevRowIndex = this.dataGrid1.CurrentRowIndex;
				//get how many records in the table 
				int iCurrRowIndex = this.dataSet1.Tables["DListTable"].Rows.Count; 
				// select the last row 
				//				this.dataGrid1.Select(iCurrRowIndex);

				//				myTable.Rows[iCurrRowIndex-1][0] = "I Change"; //this.dataSet1.Tables["DListTable"].Rows[iCurrRowIndex-2][0].ToString();
				
				myRow["Blding"] = this.dataSet1.Tables["DListTable"].Rows[iCurrRowIndex -1]["Blding"].ToString();
				myRow["Unit #"] = this.dataSet1.Tables["DListTable"].Rows[iCurrRowIndex -1]["Unit #"].ToString();
				myRow["Room"] = this.dataSet1.Tables["DListTable"].Rows[iCurrRowIndex -1]["Room"].ToString();
				myRow["Trade"] = this.dataSet1.Tables["DListTable"].Rows[iCurrRowIndex -1]["Trade"].ToString();
				this.dataSet1.Tables["DListTable"].Rows.Add (myRow);

				// select the last row 
				this.dataGrid1.Select(iCurrRowIndex);

				//				this.dataSet1.Tables["DListTable"].Rows[iCurrRowIndex]. = this.dataSet1.Tables["DListTable"].Rows[iCurrRowIndex -1]; 
				//tTable[iCurrRowIndex] = tTable[iCurrRowIndex-1];
				//unselect the previous row
				//				this.dataGrid1.UnSelect(iPrevRowIndex);	
			}
			else if ( this.dataSet1.Tables["DListTable"].Rows.Count == 0)
			{
				this.dataGrid1.Select(0);
			}
		}

		// update botton
		private void button4_Click(object sender, System.EventArgs e)
		{
			checkIfTableChange(true); // message is on

			numModifiedRows = 0;
			
			label1.Text = "";
		}

		// delete button
		private void button1_Click(object sender, System.EventArgs e)
		{
			ArrayList selectedRowArr = new ArrayList();
			//ask user if wanting to delete
			DialogResult dr=MessageBox.Show("Are you sure you want to delete this row(s) ? ", 
				"Confirm deleting",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			for (int i = 0; i < this.dataSet1.Tables["DListTable"].Rows.Count; i++)
			{
				if (this.dataGrid1.IsSelected(i))
				{
					selectedRowArr.Add(i);
				}
			}
			if (dr == DialogResult.Yes) 
			{
				DataTable tbl=new DataTable("DeficienciesTable");
				tbl = this.dataSet1.Tables[0];
//				int i = this.dataGrid1.CurrentRowIndex;//get the index of the row you clicked
				for ( int i = 0; i < selectedRowArr.Count ; i++)
				{
					tbl.Rows[Int32.Parse(selectedRowArr[i].ToString())].Delete(); //delete the row(s)
				}
				this.oleDbDataAdapter1.Update(tbl); //update the table
				this.fnRefresh(); //refresh the table 
			}

		}  //end delete button

		// printDocument1 trigger event
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics	g = e.Graphics;
			DrawTopLabel(g);
			bool more = dataGridPrinter1.DrawDataGrid(g);
			if (more == true)
			{
				e.HasMorePages = true;
				dataGridPrinter1.PageNumber++;
			}
		}

		void DrawTopLabel(Graphics g)
		{
			int TopMargin = printDocument1.DefaultPageSettings.Margins.Top;

			g.FillRectangle(new SolidBrush(label2.BackColor), label2.Location.X, label2.Location.Y + TopMargin, label2.Size.Width, label2.Size.Height);
			g.DrawString(label2.Text, label2.Font, new SolidBrush(label2.ForeColor), label2.Location.X, label2.Location.Y + TopMargin, new StringFormat());
		}

		// print view loader at load
		private void printPreviewDialog1_Load(object sender, System.EventArgs e)
		{
			printPreviewDialog1.Bounds = ClientRectangle;

		}

		// print button
		private void button7_Click(object sender, System.EventArgs e)
		{
			dataGridPrinter1.PageNumber = 1;
			dataGridPrinter1.RowCount = 0;
			if (printDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		// print preview button
		private void button8_Click(object sender, System.EventArgs e)
		{
			dataGridPrinter1.PageNumber = 1;
			dataGridPrinter1.RowCount = 0;
			if (this.printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
			}
		}
		
		// exit button
		private void button9_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void deleteMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "You can delete one row or many rows at the same time.  Select the row(s) and click the delete button.";
		}

		private void findMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "To find a record.  Click on the find button, type in your preferred fields and then click the OK button.";
		}

		private void insertMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "Click Insert button to insert to the last row.  Some of your last inputs are copied to the new row for your convinience.  Press Enter to insert multiple rows.  CLICK THE UPDATE BUTTON WHEN FINISHED.";
		}

		private void updateMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "Click this button when you need to update changes on the table.";
		}

		private void refreshMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "To cancel the inputs of the last row (i.e. Nothing will be saved) or to refresh the table";
		}

		private void saveToFileMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "To save the current table to two files.  yourfile-view.xml and yourfile-style.xsl.  The .xml file is for viewing.";
		}

		private void printMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "To print the current table.";
		}

		private void printPreviewMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "To have an early look at how the current table will look before it is printed.";
		}

		private void exitMouseHover(object sender, System.EventArgs e)
		{
			label1.Text = "To close this program.";
		}
		
		private void welcomeMessage()
		{
			label1.Text = "Welcome !!! Move the mouse over the buttons for more help.";  
		}

		// save to file menu
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			button6_Click (sender, e);
		}

		// exit menu
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		// print menu click
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			button7_Click (sender, e);
		}

		// print preview menu click
		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			button8_Click (sender, e);
		}

		// find menu
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			button2_Click (sender, e);
		}

		// refresh menu
		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			button5_Click (sender, e);
		}

		// insert menu
		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			button3_Click (sender, e);
		}

		// update menu
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			button4_Click (sender, e);
		}

		// delete menu
		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			button1_Click( sender, e);
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Deficiencies Manager \n\nCopyright 2005 Tony Cung Nguyen \n\nContact: tonysw@gmail.com", "About"); 
		}

		// save to file button
		private void button6_Click(object sender, System.EventArgs e)
		{
			// Open Form4
			Form4 oForm4 = new Form4();

			string fileName = "";

			oForm4.MyParentForm = this;

			// The form4 pop up after this command
			DialogResult tempDialogResult = oForm4.ShowDialog();

			bool tempFileNotExistValue = oForm4.fileNotExist();
			

			// Capture inputs from Form2 when user clicks OK
			if (tempDialogResult == DialogResult.OK && tempFileNotExistValue)
			{
				fileName = oForm4.getFileName();

				writeXSLFile (fileName, label2.Text);
				writeToTempXMLFile();
				writeXSLLinkToXML(fileName);

				string s="The current data of the DataSet coppied on \n\n";
				s += fileName + "-view.xml and " + fileName + "-style.xsl \n";
				s += "The two files are located at your Deficiencies folder. \n\n";
				s += "Now you can attach these two files to your email"; 
				MessageBox.Show(s); 

			}
			else if (tempDialogResult == DialogResult.OK && !tempFileNotExistValue)
			{
				button6_Click (sender, e);
			}
		}

		// save to file button helper
		private void writeToTempXMLFile() 
		{
			if (this.dataSet1 == null) 
			{
				return; //cancel 
			}
			this.dataSet1.WriteXml("temp.xml"); 
		}		

		private void writeXSLLinkToXML(string fileName)
		{
			StreamReader re = File.OpenText("temp.xml");
			TextWriter tw = new StreamWriter(fileName + "-view.xml");

			string readTempStr = re.ReadLine();
			tw.WriteLine(readTempStr);
			tw.WriteLine("<?xml-stylesheet href=\"" + fileName + "-style.xsl\"" + " type=\"text/xsl\"?>");

			while ((readTempStr = re.ReadLine()) != null)
			{
				tw.WriteLine(readTempStr);
			}
			
			re.Close();
			tw.Close();
		}

		// write the xsl file
		private void writeXSLFile (string fileName, string tHeader)
		{
			TextWriter tw = new StreamWriter(fileName + "-style.xsl");
			tw.WriteLine("<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?><xsl:stylesheet version=\"1.0\"");
			tw.WriteLine("xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\"><xsl:template match=\"/\">");
			tw.WriteLine("  <html>");
			tw.WriteLine("  <body>");
			tw.WriteLine("    <h2>" + tHeader + "</h2>");
			tw.WriteLine("    <table border=\"1\">");
			tw.WriteLine("    <tr bgcolor=\"CCCCCC\">");
			tw.WriteLine("      	<td align=\"left\"><font size=\"4\" font-family=\"Serif\"> Building</font></td>");
			tw.WriteLine("      	<td align=\"left\"><font size=\"4\" font-family=\"Serif\">Unit #</font></td>");
			tw.WriteLine("      	<td align=\"left\"><font size=\"4\" font-family=\"Serif\"> Room</font></td>");
			tw.WriteLine("      	<td align=\"left\"><font size=\"4\" font-family=\"Serif\">Description</font></td>");
			tw.WriteLine("      	<td align=\"left\"><font size=\"4\" font-family=\"Serif\">Trade</font></td>");
			tw.WriteLine("      	<td align=\"left\"><font size=\"4\" font-family=\"Serif\">Status</font></td>");
			tw.WriteLine("    </tr>");
			tw.WriteLine("    <xsl:for-each select=\"NewDataSet/DListTable\">");
			tw.WriteLine("    <tr>");
			tw.WriteLine("	<td><font size=\"4\"><xsl:value-of select=\"Blding\"/></font></td>");
			tw.WriteLine("	<td><font size=\"4\"><xsl:value-of select=\"Unit_x0020__x0023_\"/></font></td>");
			tw.WriteLine("	<td><font size=\"4\"><xsl:value-of select=\"Room\"/></font></td>");
			tw.WriteLine("	<td><font size=\"4\"><xsl:value-of select=\"Description\"/></font></td>");
			tw.WriteLine("	<td><font size=\"4\"><xsl:value-of select=\"Trade\"/></font></td>");
			tw.WriteLine("	<td><font size=\"4\"><xsl:value-of select=\"Status\"/></font></td>");
			tw.WriteLine("    </tr>");
			tw.WriteLine("    </xsl:for-each>");
			tw.WriteLine("    </table>");
			tw.WriteLine("  </body>");
			tw.WriteLine("  </html>");
			tw.WriteLine("</xsl:template></xsl:stylesheet>  ");
			tw.Close();
		}

/*
		// for keydown capture, work only when not editting the datagrid
		private void dataGrid1_KeyDown(object sender,
			System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Insert)
			{
				MessageBox.Show("Insert key pressed in dataGrid1_Keydown");
			}
		}

		private void dataGrid1_ControlAdded(object sender, ControlEventArgs e)
		{
			e.Control.KeyDown +=new KeyEventHandler(Control_KeyDown);
		}

		private void Control_KeyDown(object sender, KeyEventArgs e)
		{
		}
*/
	} // end Form1 class
} // end namespace
