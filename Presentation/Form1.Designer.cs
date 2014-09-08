namespace Presentation
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
			this.addButton = new System.Windows.Forms.Button();
			this.fieldInputTextBox = new System.Windows.Forms.TextBox();
			this.retrieveButton = new System.Windows.Forms.Button();
			this.tableComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(26, 29);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(79, 29);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Adauga";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// fieldInputTextBox
			// 
			this.fieldInputTextBox.ForeColor = System.Drawing.Color.Black;
			this.fieldInputTextBox.Location = new System.Drawing.Point(177, 34);
			this.fieldInputTextBox.Name = "fieldInputTextBox";
			this.fieldInputTextBox.Size = new System.Drawing.Size(100, 20);
			this.fieldInputTextBox.TabIndex = 1;
			// 
			// retrieveButton
			// 
			this.retrieveButton.Location = new System.Drawing.Point(26, 87);
			this.retrieveButton.Name = "retrieveButton";
			this.retrieveButton.Size = new System.Drawing.Size(75, 31);
			this.retrieveButton.TabIndex = 2;
			this.retrieveButton.Text = "ScoateTot";
			this.retrieveButton.UseVisualStyleBackColor = true;
			this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
			// 
			// tableComboBox
			// 
			this.tableComboBox.FormattingEnabled = true;
			this.tableComboBox.Location = new System.Drawing.Point(177, 96);
			this.tableComboBox.Name = "tableComboBox";
			this.tableComboBox.Size = new System.Drawing.Size(128, 21);
			this.tableComboBox.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 261);
			this.Controls.Add(this.tableComboBox);
			this.Controls.Add(this.retrieveButton);
			this.Controls.Add(this.fieldInputTextBox);
			this.Controls.Add(this.addButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox fieldInputTextBox;
		private System.Windows.Forms.Button retrieveButton;
		private System.Windows.Forms.ComboBox tableComboBox;
	}
}

