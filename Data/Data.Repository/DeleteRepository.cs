using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class DeleteRepository : IDisposable
	{
		public void DeleteByName(string table, string name)
		{
			string query = string.Format("DELETE FROM {0} where Name = '{1}'", table, name);
			Statics.crud.Delete(query);
		}
		
		public void EraseTable(string table)
		{
			try
			{
				Statics.crud.Delete("DELETE FROM " + table);
			}
			catch(SqlException)
			{
				Console.WriteLine("Can't erase! Database is protected!");
			}
		}

		public void Dispose() { }
	}
}
