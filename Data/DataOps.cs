using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class DataOps 
	{
		private Crud crud = new Crud();
		public void InsertField(string table, string args)
		{
			string query = string.Format("INSERT INTO {0} VALUES ({1})",table, args);
			crud.Create(query);
		}

		public void DeleteByName(string table, string field, string value)
		{
			string query = string.Format("DELETE FROM {0} where {1} = '{2}'", table, field, value);
			crud.Delete(query);
		}

		public void GetCertainRole(string fieldToDisplay, string table, string fieldToLook, char op, string certainValue)
		{

			string query = string.Format("select {0} from {1} where {2} {3} '{4}'",
										 fieldToDisplay, table, fieldToLook, op, certainValue);
			crud.DisplayTextForm(crud.Read(query));

			string path = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Output.txt");
			System.Diagnostics.Process.Start(@path);
		}

		public void GetEverythingText(string tabel)
		{
			string query = "select * from " + tabel;
			crud.DisplayTextForm(crud.Read(query));

			string path = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Output.txt");
			System.Diagnostics.Process.Start(@path);
		}

		public void UpdateRow(string table, string fieldToReplace, string valueReplaced, string fieldToSearch, char op, string valueTolookfor)
		{
			string query = string.Format("UPDATE {0} SET {1} = '{2}' WHERE {3} {4} '{5}'",
										table, fieldToReplace, valueReplaced, fieldToSearch, valueTolookfor);
			crud.Update(query);
		}
	}
}
