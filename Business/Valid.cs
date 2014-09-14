using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //extension methods? cauta pe net
    // pentu prima veriticare, exista string.IsNullOrEmpty() sau stirng.IsNullOrWhitespace()
    // aici verifici mai exact ce? iti trebuie un naming mai bun. ce inseamna Valid?
    public class Valid
    {
		public bool ValidString(string check)
		{
			if((check.Equals("")) || (check.Equals(null)))
			{
				return false;
			}
			else
			{
				return check.All(Char.IsLetter) || check.All(Char.IsDigit);
			}
		}
    }
}
