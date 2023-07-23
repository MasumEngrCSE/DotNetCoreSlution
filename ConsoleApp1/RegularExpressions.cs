using System.Text.RegularExpressions;

class RegularExpressions
{
    internal void initialCall()
    {
		try
		{
			string pat = @"(\s|^)ret(\s|$)";

			Console.WriteLine("retect:"+ Regex.IsMatch("retect", pat,RegexOptions.IgnoreCase));
			Console.WriteLine("khjh ret:"+ Regex.IsMatch("khjh ret", pat, RegexOptions.IgnoreCase));
			Console.WriteLine("He retect:"+ Regex.IsMatch("He retect", pat, RegexOptions.IgnoreCase));
			Console.WriteLine("ret ect:"+ Regex.IsMatch("ret ect", pat,RegexOptions.IgnoreCase));
		}
		catch (Exception)
		{

			throw;
		}
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