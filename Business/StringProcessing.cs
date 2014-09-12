using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	internal class StringProcessing
	{
		public string StringQueryTransform(string []certain)
		{
			string args = "";
			for (int i = 0; i < certain.Length; i++)
			{
				args += "'";
				args += certain[i].ToString();
				if (i != certain.Length - 1)
				{
					args += "', ";
				}
				else
				{
					args += "'";
				}
			}
			return args;
		}
	}
}
