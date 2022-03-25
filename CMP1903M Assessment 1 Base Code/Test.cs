using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Test
    {
        string text = "null";
        public string testFile()
        {

            text = File.ReadAllText("file.txt");
            return text;
        }
    }
}
