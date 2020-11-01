using System;
using System.Runtime.ConstrainedExecution;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {

            int dlzka = str1.Length;
            string str = "";

            for (int j = 0; j < dlzka; j++)
            {
                int pocetZhod = 0;
                string tmpStr = str1[j].ToString();
                
                for (int i = j; i < dlzka; i++)
                {
                    if (str2.Contains(tmpStr))
                    {
                        pocetZhod++;
                        if (pocetZhod > str.Length)
                            str = tmpStr;

                        if (i + 1 < dlzka)
                            tmpStr += str1[i + 1].ToString();
                    }
                    else
                    {
                        break;
                    }
                }


            }

            return str;
        }
    }
}
