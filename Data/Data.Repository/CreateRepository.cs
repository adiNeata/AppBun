using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class CreateRepository : IDisposable
	{
		public void InsertField(string table, string certain)
		{
			string query = string.Format("INSERT INTO {0} VALUES ('{1}')",table, certain);
			Statics.crud.Create(query);
		}

		public void Dispose() { }
	}
}
