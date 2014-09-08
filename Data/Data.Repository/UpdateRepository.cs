using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class UpdateRepository : IDisposable
	{
		public void UpdateRow(string table, string name, string lookfor)
		{
			string query = string.Format("UPDATE {0} SET Name = '{1}' WHERE Name = '{2}'",table, name, lookfor);
			Statics.crud.Update(query);
		}

		public void Dispose(){}
	}
}
