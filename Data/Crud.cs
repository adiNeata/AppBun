using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Data
{
	public class Crud
	{
		internal void Create(string query)
		{
			CreateConnectionAndProcessQuery(query);
		}

		internal DataSet Read(string query)
		{
			return CreateConnectionAndProcessQuery(query);
		}

		internal void Update(string query)
		{
			CreateConnectionAndProcessQuery(query);
		}

		internal void Delete(string query)
		{
			CreateConnectionAndProcessQuery(query);
		}

		internal void Display(DataSet arg)
		{
			foreach (DataRow dataRow in arg.Tables[0].Rows)
			{
				foreach (DataColumn dataColumn in arg.Tables[0].Columns)
				{
					Console.WriteLine(dataRow[dataColumn.ColumnName] + ", ");
				}

				Console.WriteLine();
			}
		}

		internal void DisplayTextForm(DataSet arg)
		{
			string path = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "Output.txt");
			using (StreamWriter file = new StreamWriter(path))
			{
				foreach (DataRow dataRow in arg.Tables[0].Rows)
				{
					foreach (DataColumn dataColumn in arg.Tables[0].Columns)
					{
						var aux = dataRow[dataColumn.ColumnName];
						file.WriteLine(aux);
					}

					file.WriteLine();
				}
			}
		}

		private DataSet CreateConnectionAndProcessQuery(string query)
		{
			using (SqlConnection con = new SqlConnection(Data.Properties.Settings.Default.PortalMSPConnectionString1))
			{
				DataSet result = new DataSet();
				SqlDataAdapter dataAdapter = new SqlDataAdapter();
				dataAdapter.SelectCommand = new SqlCommand(query, con);
				dataAdapter.Fill(result);

				return result;
			}
		}

		public IList<string> ListTables()
		{
			using (SqlConnection conn = new SqlConnection(Data.Properties.Settings.Default.PortalMSPConnectionString1))
			{
				conn.Open();
				List<string> tables = new List<string>();
				DataTable dt = conn.GetSchema("Tables");
				foreach (DataRow row in dt.Rows)
				{
					string tableName = (string)row[2];
					tables.Add(tableName);
				}

				return tables;
			}
		}

		public IList<string> ListFields(string table)
		{
			Crud crud = new Crud();
			string query = "SELECT * FROM " + table;
			DataSet arg = CreateConnectionAndProcessQuery(query);

			using (SqlConnection conn = new SqlConnection(Data.Properties.Settings.Default.PortalMSPConnectionString1))
			{
				conn.Open();
				List<string> fields = new List<string>();

				foreach (var item in arg.Tables[0].Columns)
				{
					fields.Add(item.ToString());
				}

				return fields;
			}
		}
	}
}
