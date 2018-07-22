using System;
using System.Collections.Generic;
using System.Xml;

/*
 * Implement a function FolderNames, which accepts a string containing an XML file that specifies folder structure and returns 
 * all folder names that start with startingLetter. The XML format is given in the example below.
 * For example, for the letter 'u' and XML file:
*/

namespace Folders
{
    class Folders
    {
        public static IEnumerable<string> FolderNames(string xml, char startingLetter)
        {
            List<string> elem = new List<string>();

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(xml);

            foreach (XmlAttribute folderName in xmldoc.SelectNodes("//folder/@name[starts-with(., '" + startingLetter + "')]"))
            {
                elem.Add(folderName.Value);
            }

            return elem;
        }

        public static void Main(string[] args)
        {
            string xml =
                "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                "<folder name=\"c\">" +
                    "<folder name=\"program files\">" +
                        "<folder name=\"uninstall information\" />" +
                    "</folder>" +
                    "<folder name=\"users\" />" +
                "</folder>";

            foreach (string name in FolderNames(xml, 'u'))
                Console.WriteLine(name);
        }
    }
}
