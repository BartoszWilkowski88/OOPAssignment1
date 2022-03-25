using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = null;
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.Write("Enter text: ");
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            while (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("Enter correct file path e.g. file.txt: ");
                fileName = Console.ReadLine();
            }
            while (true)
            {
                if (File.Exists(fileName))
                {
                    text = File.ReadAllText(fileName);
                    return text;
                    break;
                }
                try
                {
                    if (!File.Exists(fileName))
                    {
                        throw new DirectoryNotFoundException();
                    }
                    text = File.ReadAllText(fileName);
                    return text;
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Enter correct file path: ");
                    fileName = Console.ReadLine();
                }
            }
        }

    }
}
