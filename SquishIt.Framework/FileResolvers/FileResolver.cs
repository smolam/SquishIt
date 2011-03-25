using System.Collections.Generic;
using System.IO;
using System.Web;

namespace SquishIt.Framework.FileResolvers
{
    public class FileResolver: IFileResolver
    {
        public static string Type
        {
            get { return "file"; }
        }        

        public IEnumerable<string> TryResolve(string file)
        {
            yield return Path.GetFullPath(file);            
        }
    }
}