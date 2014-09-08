using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class ReadRepository : IDisposable
	{
		//Metode de legatura intre bl si dal
		public void GetCertainRole(string table, string certain)
		{
			string query = string.Format("select name from {0} where Name = '{1}'",table, certain);
			Statics.res = Statics.crud.Read(query);
			Crud.Display(Statics.res);
		}

		public void GetEverything(string tabel)
		{
			string query = "select * from " + tabel;
			Statics.res = Statics.crud.Read(query);
			Crud.Display(Statics.res);

			Console.WriteLine();
		}

		public void GetEverythingText(string tabel)
		{
			string query = "select * from " + tabel;
			Statics.res = Statics.crud.Read(query);
			Crud.DisplayTextForm(Statics.res);

			System.Diagnostics.Process.Start(@"C:\Users\Adrian\Documents\Visual Studio 2013\Projects\Data\Data\Output.txt");

			Console.WriteLine();
		}

		public void Dispose() { }
	}
}
