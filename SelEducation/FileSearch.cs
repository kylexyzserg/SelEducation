using System;
using System.IO;
using System.Linq;

namespace SelEducation
{
    class FileSearch
    {



        public void  FindLastFile(string extension, string directoryStr )

        {
            var directory = new DirectoryInfo(directoryStr);

            var FirstElement = (from f in directory.GetFiles("*"+extension)
                     orderby f.LastWriteTime descending
                      select f).First();

        var DateOfCreation = FirstElement.LastWriteTime;

        var ListOfElements = (from k in directory.GetFiles("*"+extension)
                              where(k.LastWriteTime >= DateOfCreation.AddSeconds(-10) && k.LastWriteTime <= DateOfCreation.AddSeconds(10))
                              orderby k.LastWriteTime descending
                              select k).ToList();
 
        foreach (var fi in ListOfElements)
            {
                Console.WriteLine(fi.FullName);
            }          
        }
    }
}
