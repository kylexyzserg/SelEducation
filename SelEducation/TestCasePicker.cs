using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SelEducation
{
    class TestCasePicker
    {
         static string AddSuffix(string originalFilePath, string suffix)
        {
            string fDir = Path.GetDirectoryName(originalFilePath);
            string fName = Path.GetFileNameWithoutExtension(originalFilePath);
            string fExt = Path.GetExtension(originalFilePath);
            return Path.Combine(fDir, String.Concat(fName, suffix, fExt));
        }

        public static void SelectCases(string originalFilePath, int numberOfCasesToSelect)
        {
        string newFilePath = AddSuffix(originalFilePath, "_res");
        Random random = new Random();

        List<int> randomCasesList = new List<int>();
        List<string> originalFileLineList = (File.ReadAllLines(originalFilePath, Encoding.ASCII)).ToList();
            if (numberOfCasesToSelect> originalFileLineList.Count)
            {
                Console.WriteLine("There are only "+ (originalFileLineList.Count-1)+" cases in the original file. You are trying to select "+ numberOfCasesToSelect);
            }
        List<string> newFileLineList = new List<string>();

            while (randomCasesList.Count < numberOfCasesToSelect)
            {
                int randomNumber = random.Next(1, originalFileLineList.Count);
                if (!randomCasesList.Contains(randomNumber))
                    randomCasesList.Add(randomNumber);
            }       


            using (StreamWriter swn = File.CreateText(newFilePath))
            {
                swn.WriteLine(originalFileLineList.First());

          

                foreach (int n in randomCasesList)
                {
                    swn.WriteLine(originalFileLineList[n]);
                    newFileLineList.Add(originalFileLineList[n]);

                }
                             
            }

         var ResultNewFileList = originalFileLineList.Except(newFileLineList);

            using (StreamWriter swo = File.CreateText(originalFilePath))
            {

                foreach (string str in ResultNewFileList)
                {
                    swo.WriteLine(str);
                   
                }

            }

        }

        
        public static void SelectCases(string originalFilePath)
        {
            SelectCases(originalFilePath, 10);
        }

    }
}

