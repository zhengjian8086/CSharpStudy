using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study001
{
    class Utils
    {
        public string CreateDate = DateTime.Now.ToString();
        string? UnknowString;
        string? CurrentInstanceName;

        public string GetUnknowString()
        {
            return UnknowString;
        }

        public void SetUnknowString(string unknowString)
        {
            UnknowString = unknowString;
            Console.WriteLine(this.UnknowString);
        }

        public void SetCurrentInstanceName()
        {
            CurrentInstanceName = this.ToString();
        }

        public string GetCurrentInstanceName()
        {
            return CurrentInstanceName;
        }
        static void StartHelloWorld(String inputWord = "")
        {
            if (inputWord != "")
            {
                Console.WriteLine($@"Hello {inputWord} from 'Utils' class");
            }
            else
            {
                Console.WriteLine("Hello world from 'Utils' class");
            }

        }
    }
}
