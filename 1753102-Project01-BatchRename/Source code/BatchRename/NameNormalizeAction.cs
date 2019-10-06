using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchRename
{
    class NameNormalizeAction : IAction
    {
        // implement interface
        public string ClassName => "NameNormalizeAction";

        public List<string> KeyWord => new List<string>() { ClassName };

        public string Description => "Normalize name";

        public IAction Create(List<string> arguments)
        {
            IAction result = null;

            result = new NameNormalizeAction();

            return result;
        }

        public string Process(string inputString, bool isFilename)
        {
            // get arguments

            // split
            string name = inputString;
            string extension = "";
            if (isFilename)
            {
                name = Path.GetFileNameWithoutExtension(inputString);
                extension = inputString.Remove(0, name.Length);
            }

            // process
            name = StringProcess.MakeStringNormalized(name);

            // combine and return
            string result = name + extension;
            return result;
        }
    }
}
