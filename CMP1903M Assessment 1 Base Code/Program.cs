//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            var LongWords = new LongWords();
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            string output = "null";
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            var input = new Input();
            Console.Write("Enter (1) for manual input or (2) for file input: ");
            string ch = Console.ReadLine();
            while (ch != "1" && ch != "2")
            {   
                Console.Write("Enter correct number: ");
                ch = Console.ReadLine(); 
            }
            //manual input
            if (ch == "1")
            {
                output = input.manualTextInput();
            }
            //file input
            else if (ch == "2")
            {
                Console.WriteLine("Enter a file name (Note: it has to be in this directory) pre-set example: file.txt");
                var fileName = Console.ReadLine();
                output = input.fileTextInput(fileName);
            }
            //Check for long words 7+ and add them to the file.
            LongWords.checkForLongWords(output);
            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            var analyse = new Analyse();

            //Receive a list of integers back
            parameters = analyse.analyseText(output);
            //Report the results of the analysis
            var report = new Report();
            report.outputConsole(parameters);
            //TO ADD: Get the frequency of individual letters?
        }
        
        
    
    }
}
