using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Valid
    {
		public static bool ValidUsers(string check)
		{
			if((check.Equals("")) || (check.Equals(null)))
			{
				return false;
			}
			else
			{
				return check.All(Char.IsLetter);
			}
		}
    }
}
