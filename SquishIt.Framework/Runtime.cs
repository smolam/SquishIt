using System;
namespace SquishIt.Framework
{
	public class Runtime
	{
		public static bool Mono 
		{
			//assuming this means mono, hoping to avoid a compiler directive / separate assemblies
			get { return Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX; }	
		}
	}
}

