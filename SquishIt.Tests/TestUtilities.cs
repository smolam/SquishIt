using System;
using SquishIt.Framework;
using System.Text.RegularExpressions;

namespace SquishIt.Tests
{
	public class TestUtilities
	{
		static Regex driveLetter = new Regex(@"[a-zA-Z]{1}:\\");
		
		public static string PreparePath(string windowsPath) {
			var path = windowsPath;
			if(Runtime.Mono){
				path = driveLetter.Replace(path, @"/")
					.Replace(@"\", @"/");
			}
			return path;
		}
	}
}

