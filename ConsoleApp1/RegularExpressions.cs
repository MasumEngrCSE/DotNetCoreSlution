using System.Diagnostics;
using System.Text.RegularExpressions;

class RegularExpressions
{
    internal void initialCall()
    {
		try
		{

            string pat = @"(\s|^)ret(\s|$)";
            #region IsMatch

            //string pat = @"(\s|^)ret(\s|$)";

			//Console.WriteLine("retect:"+ Regex.IsMatch("retect", pat,RegexOptions.IgnoreCase));
			//Console.WriteLine("khjh ret:"+ Regex.IsMatch("khjh ret", pat, RegexOptions.IgnoreCase));
			//Console.WriteLine("He retect:"+ Regex.IsMatch("He retect", pat, RegexOptions.IgnoreCase));
			//Console.WriteLine("ret ect:"+ Regex.IsMatch("ret ect", pat,RegexOptions.IgnoreCase));


			#endregion


			#region matchcollection

			string searchString = teststring();

			pat = @"\d{3}(.|-)\d{3}(.|-|)\S\d{4}";

			MatchCollection matchCollection=Regex.Matches(searchString, pat);
			int c = 0;
			foreach (Match match in matchCollection)
			{
				Console.WriteLine(match.Value);
				c++;
			}
			Console.WriteLine("Total:"+c);
			#endregion


			#region Stopwatch test

			//Stopwatch sw = Stopwatch.StartNew();
			//Regex tst = new Regex(pat, RegexOptions.IgnoreCase);

			//for (int i = 0; i < 100000; i++)
			//{
			//    tst.IsMatch("abc ret");
			//}
			//sw.Stop();
			//Console.WriteLine($"ElapsedMilliseconds :{sw.ElapsedMilliseconds}");

			#endregion


		}
        catch (Exception)
		{

			throw;
		}
    }



	private string teststring()
	{

		string str = "1st District - Central\r\n1718 South State Street\r\nChicago, IL 60616\r\n312.745 4290\r\n\r\n2nd District - Wentworth\r\n5101 South Wentworh Avenue\r\nChicago, IL 60609\r\n312.747.8366  \r\n\r\n3rd District - Grand Crossing\r\n7040 S. Cottage Grove Ave.\r\nChicago, IL 60637\r\n312.747.8201  \r\n\r\n4th District - South Chicago\r\n2255 E. 103rd St\r\nChicago, IL 60617\r\n312.747.7581  \r\n\r\n5th District - Calumet\r\n727 E. 111th St.\r\nChicago, IL 60628\r\n312.747.8210  \r\n\r\n6th District - Gresham\r\n7808 South Halsted Street\r\nChicago, IL 60620\r\n312.745.3617  \r\n\r\n7th District - Englewood\r\n1438 W. 63rd St.\r\nChicago, IL 60636\r\n312.747.8223  \r\n\r\n8th District - Chicago Lawn\r\n3420 West 63rd St.\r\nChicago, IL 60629\r\n312.747.8730 \r\n\r\n9th District - Deering\r\n3120 S. Halsted St.\r\nChicago, IL 60608\r\n312.747.8227  \r\n\r\n10th District - Ogden\r\n3315 W. Ogden Avenue\r\nChicago, IL 60623\r\n312.747.7511  \r\n\r\n11th District - Harrison\r\n3151 W. Harrison St.\r\nChicago, IL 60612\r\n312.746.8386  \r\n\r\n12th District - Near West\r\n1412 S. Blue Island\r\nChicago, IL 60608\r\n312.746.8396\r\n\r\n14th District - Shakespeare\r\n2150 N. California Ave.\r\nChicago, IL 60647\r\n312.744.8290  \r\n\r\n15th District - Austin\r\n5701 W. Madison Ave.\r\nChicago, IL 60644\r\n312.746.8303  \r\n\r\n16th District - Jefferson Park\r\n5151 N. Milwaukee Ave.\r\nChicago, IL 60630\r\n312.742.4510  \r\n\r\n17th District - Albany Park\r\n4650 N. Pulaski Rd.\r\nChicago, IL 60630\r\n312.742.4410  \r\n\r\n18th District - Near North\r\n1160 N. Larrabee Ave.\r\nChicago, IL 60610\r\n312.742.5870  \r\n\r\n19th District - Town Hall\r\n850 West Addison St. \r\nChicago, IL 60613\r\n312.744.8320  \r\n\r\n20th District - Foster\r\n5400 N. Lincoln Avenue\r\nChicago, IL 60625\r\n312.742.8714, 312.742.8715\r\n\r\n22nd District - Morgan Park\r\n1900 W. Monterey Ave.\r\nChicago, IL 60643\r\n312.745.0570\r\n\r\n24th District - Rogers Park\r\n6464 N. Clark St.\r\nChicago, IL 60626\r\n312.744.5907  \r\n\r\n25th District - Grand Central\r\n5555 W. Grand Ave.\r\nChicago, IL 60639\r\n312.746.8605";


		return str;
	}

    /*
	 
	^ - Starts with
	$ - Ends with
	[] - Range
	() - Group
	. - Single character once
	+ - one or more characters in a row
	? - optional preceding character match
	\ - escape character
	\n - New line
	\d - Digit
	\D - Non-digit
	\s - White space
	\S - non-white space
	\w - alphanumeric/underscore character (word chars)
	\W - non-word characters
	{x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" mea
	(x|y) - Alternative - x or y
	[^x] - Anything but x (where x is whatever character you want)

	 */

}