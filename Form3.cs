using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Deficiencies
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		public Form1 MyParentForm;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
		{
			//
			// Required for Windows Form Designer support
			//
		
			InitializeComponent();
			printHelp();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			//printHelp();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightGray;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.MediumBlue;
			this.button1.Location = new System.Drawing.Point(272, 488);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(648, 448);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 534);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.button1});
			this.Name = "Form3";
			this.Text = "Deficiencies Manager Contents";
			this.ResumeLayout(false);

		}
		#endregion

		private void printHelp()
		{
			string tStr = "\nDeficiencies Manager Contents:";
			tStr += "\n\n\nDeficiencies Manager is used to keep track of home deficiencies.\n";
			tStr += "\n\nIn this program you can delete, find, insert, update an Access database.";
			tStr += "\n\nIn addition, you can print displayed records or save them to a file.";
			label1.Text = tStr;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	} // end form3 class
}
