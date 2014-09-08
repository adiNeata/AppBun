using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Windows.Forms;

namespace Business
{
	public class LinkToData
	{
		public static void PassString(string passed)
		{
			if (Valid.ValidUsers(passed))
			{
				using (CreateRepository cr = new CreateRepository())
				{
					cr.InsertField("Roles", passed);
				}

				MessageBox.Show("Succesful op");
			}
			else
			{
				MessageBox.Show("Enter valid user!!");
			}
		}

		public static void DisplayContents(string table)
		{
			if (Valid.ValidUsers(table))
			{
				using (ReadRepository readTable = new ReadRepository())
				{
					readTable.GetEverythingText(table);
				}
			}
			else
			{
				MessageBox.Show("Enter valid table!");
			}
		}

		public static IList<string> PassTables()
		{
			return Crud.ListTables();
		}
	}
}
