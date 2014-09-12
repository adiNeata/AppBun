using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			InitializeComboBox();
		}

		private void retrieveButton_Click(object sender, EventArgs e)
		{
			LinkToData link = new LinkToData();
			link.DisplayContents((string)tableComboBox.SelectedItem);
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			LinkToData link = new LinkToData();
			link.PassString(fieldInputTextBox.Text);
		}

		private void InitializeComboBox()
		{
			LinkToData link = new LinkToData();

			foreach (string item in link.PassTables())
			{
				this.tableComboBox.Items.Add(item.ToString());
			}
		}
	}
}
