using System;

/*
 * Write a function that provides change directory (cd) function for an abstract file system.
 * Notes:
 * Root path is '/'.
 * Path separator is '/'.
 * Parent directory is addressable as "..".
 * Directory names consist only of English alphabet letters (A-Z and a-z).
 * The function should support both relative and absolute paths.
 * The function will not be passed any invalid paths.
 * Do not use built-in path-related functions.
 * For example:
 * Path path = new Path("/a/b/c/d");
 * path.Cd("../x");
 * Console.WriteLine(path.CurrentPath);
 * should display '/a/b/c/x'.
*/

namespace Path
{
    class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            this.CurrentPath = path;
        }

        public void Cd(string newPath)
        {
            String[] newP = newPath.Split('/');
            String[] oldP = CurrentPath.Split('/');
            int lnCount = 0;
            foreach (String str in newP)
            {
                if (str.Equals(".."))
                {
                    lnCount++;
                }
            }

            int len = oldP.Length;
            String strOut = "";
            for (int i = 0; i < len - lnCount; i++)
            {
                strOut = strOut + oldP[i] + "/";
            }

            len = newP.Length;
            for (int i = 0; i < len; i++)
            {
                if (!newP[i].Equals(".."))
                {
                    strOut = strOut + newP[i] + "/";
                }
            }
            CurrentPath = strOut.Substring(0, strOut.Length - 1);
            if (CurrentPath.IndexOf("/") < 0)
                throw new Exception("Directory not found");
        }

        public static void Main(string[] args)
        {
            Path path = new Path("/a/b/c/d");
            path.Cd("../x");
            Console.WriteLine(path.CurrentPath);
        }
    }
}
