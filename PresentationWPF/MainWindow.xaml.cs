using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentationWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		TextBox[] result = new TextBox[13];
		public MainWindow()
		{
			InitializeComponent();
			InitializeComboBoxes();
			InitOperatorsComboBox();
			InitTextBoxes(result);
		}

		#region Init

		private void InitializeComboBoxes()
		{
			InitializeComboBoxTable(this.selectTableComboBox);
			InitializeComboBoxTable(this.selectCertainValueComboBox);
			InitializeComboBoxTable(this.insertValueComboBox);
			InitializeComboBoxTable(this.updateTableComboBox);
			InitializeComboBoxTable(this.deleteComboBox);
		}

		private void InitializeComboBoxTable(ComboBox c)
		{
			LinkToData link = new LinkToData();

			foreach (string item in link.PassTables())
			{
				c.Items.Add(item.ToString());
			}
		}

		private void InitializeComboBoxTableFields(string tableSelected, ComboBox box)
		{
			LinkToData link = new LinkToData();

			box.Items.Clear();

			foreach (string item in link.PassFields(tableSelected))
			{
				box.Items.Add(item.ToString());
			}
		}

		private void InitOperatorsComboBox()
		{
			selectOperators.Items.Add("<");
			selectOperators.Items.Add(">");
			selectOperators.Items.Add("=");

			updateOperators.Items.Add("<");
			updateOperators.Items.Add(">");
			updateOperators.Items.Add("=");
		}

		private void InitTextBoxes(TextBox[] x)
		{
			result[0] = insertTextBox1;
			result[1] = insertTextBox2;
			result[2] = insertTextBox3;
			result[3] = insertTextBox4;
			result[4] = insertTextBox5;
			result[5] = insertTextBox6;
			result[6] = insertTextBox7;
			result[7] = insertTextBox8;
			result[8] = insertTextBox9;
			result[9] = insertTextBox10;
			result[10] = insertTextBox11;
			result[11] = insertTextBox12;
			result[12] = insertTextBox13;

			for (int i = 0; i < x.Length; i++)
			{
				x[i].Visibility = Visibility.Hidden;
			}
		}
		#endregion

		#region Events
		private void buttonRetrieve_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				LinkToData link = new LinkToData();
				link.DisplayContents(selectTableComboBox.SelectedItem.ToString());
			}
			catch(NullReferenceException)
			{
				MessageBox.Show("Select something!");
			}
		}

		private void updateTableSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			try
			{
				InitializeComboBoxTableFields(selectCertainValueComboBox.SelectedItem.ToString(), updateFieldFromTable);
				InitializeComboBoxTableFields(selectCertainValueComboBox.SelectedItem.ToString(), selectFieldFromTable);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SelectSpecific_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				LinkToData link = new LinkToData();
				link.DisplayContents(updateFieldFromTable.SelectedItem.ToString(),
											selectCertainValueComboBox.SelectedItem.ToString(),
											selectFieldFromTable.SelectedItem.ToString(),
											Char.Parse(selectOperators.SelectedItem.ToString()),
											comparisonValue.Text.ToString());
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Complete all fields!");
			}
		}

		private void insertValueComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			LinkToData link = new LinkToData();
			InitTextBoxes(result);
			IList<string> aux = link.PassFields(insertValueComboBox.SelectedItem.ToString());

			for (int i = 0; i < aux.Count; i++)
			{
				result[i].Visibility = Visibility.Visible;
				try
				{
					result[i].Text = aux.ElementAt(i).ToString();
				}
				catch(Exception exe)
				{
					MessageBox.Show(exe.Message);
				}
			}
		}

		private void insertButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				LinkToData link = new LinkToData();
				string[] args = new string[link.PassFields(insertValueComboBox.SelectedItem.ToString()).Count];
				for (int i = 0; i < args.Length; i++)
				{
					args[i] = result[i].Text;
				}

				link.PassInsertingArgs(args);
			}
			catch(NullReferenceException)
			{
				MessageBox.Show("Select something!");
			}
		}

		private void updateTableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			try
			{
				InitializeComboBoxTableFields(updateTableComboBox.SelectedItem.ToString(), updateTableFieldComboBox);
				InitializeComboBoxTableFields(updateTableComboBox.SelectedItem.ToString(), updateTableFieldComboBox2);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void updateButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				LinkToData link = new LinkToData();
				link.UpdateContents(updateTableComboBox.SelectedItem.ToString(),
									updateTableFieldComboBox.SelectedItem.ToString(),
									updateReplaceTextBox.Text,
									updateTableFieldComboBox2.SelectedItem.ToString(),
									Char.Parse(updateOperators.SelectedItem.ToString()),
									updateSearchTextBox.Text);
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Select something!!");
			}
		}

		private void deleteComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			LinkToData link = new LinkToData();
			InitializeComboBoxTableFields(deleteComboBox.SelectedValue.ToString(), deleteFieldCombBox);
		}

		private void deleteButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				LinkToData link = new LinkToData();
				link.DeleteContents(deleteComboBox.SelectedValue.ToString(),
									deleteFieldCombBox.SelectedValue.ToString(),
									deleteTextBox.Text);
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Insert something!");
			}
		}
		#endregion
	}
}
