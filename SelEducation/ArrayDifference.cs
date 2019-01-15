using System;
using System.Collections.Generic;
using System.Linq;

namespace SelEducation
{
    class ArrayDifference
    {
        public void FindArrayDifferenceCollection(List<string> ArrayOne, List<string> ArrayTwo)
        {

            var ResultArray = ArrayOne.Except(ArrayTwo);
            foreach (string str in ResultArray)
                Console.WriteLine(str);
        }

        public void FindArrayDifferenceWithoutCollection(List<string> ArrayOne, List<string> ArrayTwo) { 

            List<string> TempList = new List<string>();
            for (int i = 0; i < ArrayOne.Count(); i++)
            {
                int flag = 0;
                for (int j = 0; j < ArrayTwo.Count(); j++)
                {
                    if (!(ArrayOne[i].ToLower() == ArrayTwo[j].ToLower()))
                    {
                        flag++;
                    }
                }
                if (flag == ArrayTwo.Count())
                    TempList.Add(ArrayOne[i]);
            }
            ArrayOne = TempList;
            foreach (string str1 in ArrayOne)
            Console.WriteLine(str1);
            
        }
        }
        }
    

