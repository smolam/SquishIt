using System;
using System.IO;
using System.Text.RegularExpressions;
using SquishIt.Framework;

namespace SquishIt.Tests.Helpers
{
    public class TestUtilities
    {
        static readonly Regex driveLetter = new Regex(@"[a-zA-Z]{1}:\\");

        public static string PreparePath(string windowsPath)
        {
            var path = windowsPath;
            if (Runtime.Mono)
            {
                path = driveLetter.Replace(path, @"/")
                    .Replace(@"\", @"/");
            }
            return path;
        }
		
		public static string PrepareRelativePath(string windowsPath)
		{
			var path = windowsPath;
			if (Runtime.Mono)
			{
				var extendedPath = PreparePath(path);
				path = 	Environment.CurrentDirectory + extendedPath; //combine won't work here for some reason?
			}
			return path;
		}
    }
}

