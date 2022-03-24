using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class LongWords
    {
        private void createFile()
        {
            //Create long words file
            if (!File.Exists("LongWords.txt"))
            {
                var lngwrdfile = File.Create("LongWords.txt");
                lngwrdfile.Close();
            }
        }
        public void checkForLongWords(string input)
        {
            //Check if file already exists
            if (!File.Exists("LongWords.txt"))
            {
                createFile();
            }
            //variables
            string lngwrdsfile = File.ReadAllText("LongWords.txt");
            string[] lngwrds = input.Split(' ', '.', ',');
            string[] lngwrdscheck = lngwrdsfile.Split(' ', '.', '*', ',');
            int ind = 0;
            bool exists = false;
            //add words with lenght of 7+ to Long Words file
            while (ind < lngwrds.Length)
            {
                for (int i = 0; i < lngwrdscheck.Length; i++)
                {
                    if (lngwrdscheck.Contains(lngwrds[ind]))
                    {
                        exists = true;
                    }
                }
                if (File.Exists("LongWords.txt") && lngwrds[ind].Length > 7 && exists == false)
                {
                    if (lngwrds[ind].StartsWith("*"))
                    {
                        break;
                    }
                    using (StreamWriter tw = new StreamWriter("LongWords.txt", true))
                    {
                        tw.Write(lngwrds[ind] + ", ");
                    }
                }
                exists = false;
                ind++;
            }
        }
    }
}
