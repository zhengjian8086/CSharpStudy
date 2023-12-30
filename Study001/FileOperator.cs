using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study001
{
    class FileOperator
    {
        public static void FileOpen(string path, string operateMode)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
        }
    }
}
