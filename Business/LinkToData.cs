using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Windows.Forms;

namespace Business
{
    //naming mai bun, eventual comentarii pe metode. daca pui /// (de slashuri) inainte  de o metoda
    //iti va aparea ceva similar ca la "PassInsertingArgs". In momentl in care iti vei folosi propriile librarii
    //comentariile astea iti vor aparea la intellisense
	public class LinkToData
	{
		private Valid valid = new Valid();
        /// <summary>
        /// Descrii metoda aici.
        /// </summary>
        /// <param name="passed">Ce insemana parametrul asta?</param>
		public void PassInsertingArgs(string []passed)
		{
			bool trueStrings = true;
			foreach (string item in passed)
			{
				if(!valid.ValidString(item))
				{
					trueStrings = false;
					break;
				}
			}
			if (trueStrings)
			{
				DataOps cr = new DataOps();
				StringProcessing str = new StringProcessing();
				cr.InsertField("DreamsparkStudents", str.StringQueryTransform(passed));

				MessageBox.Show("Succesful op");
			}
			else
			{
				MessageBox.Show("Enter valid user!!");
			}
		}

		public void DisplayContents(string table)
		{
			if (valid.ValidString(table))
			{
				DataOps readTable = new DataOps();
				readTable.GetEverythingText(table);
			}
			else
			{
				MessageBox.Show("Enter valid table!");
			}
		}

		public void DisplayContents(string table, string field, string fieldToLookIn, char oper, string text)
		{
			if(valid.ValidString(text))
			{
				DataOps data = new DataOps();
				data.GetCertainRole(table, field, fieldToLookIn, oper, text);
			}
			else
			{
				MessageBox.Show("Insert a valid value!");
			}
		}

		public void UpdateContents(string table, string fieldToReplace, string valueReplace, string fieldToLookIn, char ops,  string valueToSearch )
		{
			if((valid.ValidString(valueReplace) && (valid.ValidString(valueToSearch))))
			{
				DataOps data = new DataOps();
				data.UpdateRow(table, fieldToReplace, valueReplace, fieldToLookIn, ops, valueToSearch);

				MessageBox.Show("Successful update!");
			}
			else
			{
				MessageBox.Show("Insert a valid value!!");
			}
		}

		public void DeleteContents(string table, string field, string name)
		{
			if (valid.ValidString(name))
			{
				DataOps data = new DataOps();
				data.DeleteByName(table, field, name);

				MessageBox.Show("Succesful Delete!");
			}
			else
			{
				MessageBox.Show("Good");
			}
		}
		public IList<string> PassTables()
		{
			Crud crud = new Crud();
			return crud.ListTables();
		}

		public IList<string> PassFields(string table)
		{
			Crud crud = new Crud();
			return crud.ListFields(table);
		}
	}
}
