using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void outputConsole(List<int>numbers)
        {
            Console.WriteLine("Sentences: {0}", numbers[0]);
            Console.WriteLine("Vowels: {0}", numbers[1]);
            Console.WriteLine("Consonants: {0}", numbers[2]);
            Console.WriteLine("Upper Case Letters: {0}", numbers[3]);
            Console.WriteLine("Lower Case Letters: {0}", numbers[4]);
            Console.WriteLine("Total Characters: {0}", numbers[5]);
        }
        //test file output
        public void testOutputConsole(List<int>numbers)
        {
            Console.WriteLine("Sentences: {0} | Expected: 6", numbers[0]);
            Console.WriteLine("Vowels: {0} | Expected: 189", numbers[1]);
            Console.WriteLine("Consonants: {0} | Expected: N/A", numbers[2]);
            Console.WriteLine("Upper Case Letters: {0} | Expected: 9", numbers[3]);
            Console.WriteLine("Lower Case Letters: {0} | Expected: 497", numbers[4]);
            Console.WriteLine("Total Characters: {0} | Expected: 506", numbers[5]);
        }
    }
}
