using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //variables
            string vowels = "aeiouAEIOU";
            string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            int[] frqc = new int[(int)char.MaxValue];
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i<6; i++)
            {
                values.Add(0);
            }
            string[] sntcs = input.Split(' ');
            foreach (string lines in sntcs)
            {
                if (lines.EndsWith('.') || lines.EndsWith('*'))
                {
                    values[0]++;
                }
            }
            //check for values then return them
            foreach (char c in input)
            {
                if (c == '*')
                {
                    break;
                }
                frqc[(int)c]++;
                if (char.IsUpper(c))
                {
                    values[3]++;
                    values[5]++;
                }
                else if (char.IsLower(c))
                {
                    values[4]++;
                    values[5]++;
                }
                foreach (char vow in vowels)
                {
                    if (vow == c)
                    {
                        values[1]++;
                    }
                }
                foreach (char cons in consonants)
                {
                    if (cons == c)
                    {
                        values[2]++;
                    }
                }
            }
            // Calculate character frequency
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (frqc[i] > 0 && char.IsLetter((char)i))
                {
                    Console.WriteLine("Letter: {0} appears: {1}", (char)i, frqc[i]);
                }
            }
            
            return values;
        }
    }
}
